using BlackDesert.Trade.Domain.Abstract;
using BlackDesert.Trade.Domain.DB.Context;
using BlackDesert.Trade.Domain.Models.EfCore;
using BlackDesert.Trade.Domain.Models.Xml;

namespace BlackDesert.Trade.Business.Manager.Info;

public class ItemInfoManager : SingletonBase<ItemInfoManager>
{
  // private const string ManagerName = "ItemInfoManager";
  // private static volatile ItemInfoManager _singleton;
  // private static readonly object Locker = new();
  private readonly TradeMarketItemInfo _emptyStockInfo;
  private readonly Dictionary<KeyValuePair<int, int>, int> _itemEnchantMaxGroupList;
  private readonly Dictionary<int, int> _itemEnchantMaxLevelList;
  private readonly Dictionary<KeyValuePair<int, int>, TradeMarketItemInfo> _itemInfoList;
  private readonly Dictionary<long, MarketPriceGroup> _marketPriceGroupList;
  private readonly Dictionary<KeyValuePair<int, int>, TradeMarketItemInfo> _servantInfoList;
  private readonly XmlMarketItemList _xmlMarketItemList;
  // private bool _isOpen;

  private ItemInfoManager() {
    _emptyStockInfo = new TradeMarketItemInfo();
    _itemInfoList = new Dictionary<KeyValuePair<int, int>, TradeMarketItemInfo>();
    _itemEnchantMaxLevelList = new Dictionary<int, int>();
    _itemEnchantMaxGroupList = new Dictionary<KeyValuePair<int, int>, int>();
    _marketPriceGroupList = new Dictionary<long, MarketPriceGroup>();
    _servantInfoList = new Dictionary<KeyValuePair<int, int>, TradeMarketItemInfo>();
    // _isOpen = false;

    var sw = Stopwatch.StartNew();
    ServerControlLogger.LogStart(nameof(ItemInfoManager));
    _xmlMarketItemList = XmlModule.This.ReadXml<XmlMarketItemList>();
    foreach (var item in _xmlMarketItemList.Items) {
      var tradeMarketItemInfo = new TradeMarketItemInfo(0,
                                                        item.ItemKey,
                                                        item.EnchantLevel,
                                                        item.MainCategory,
                                                        item.SubCategory,
                                                        item.EnchantAddPercent,
                                                        item.MaxPricePercent,
                                                        item.MinPricePercent,
                                                        item.BasePrice,
                                                        item.IsEnhanceable,
                                                        item.EnchantGroup,
                                                        item.EnchantNeedCount,
                                                        item.IsPersonalTrade,
                                                        item.EnchantMaterialKey,
                                                        item.Weight,
                                                        item.MaxStackCount,
                                                        item.TradeCountToUpdate,
                                                        item.AccumulatePassCount,
                                                        item.MaxRegisterCount,
                                                        item.IsNoticeItem,
                                                        item.Grade,
                                                        item.MarketPriceGroup,
                                                        true,
                                                        item.RealMaxPrice, //TODO Validate this
                                                        item.RealMinPrice);

      var itemIdentityKp = new KeyValuePair<int, int>(tradeMarketItemInfo._mainKey, tradeMarketItemInfo._subKey);
      _itemInfoList[itemIdentityKp] = tradeMarketItemInfo;

      if (!_itemEnchantMaxLevelList.ContainsKey(tradeMarketItemInfo._mainKey))
        _itemEnchantMaxLevelList[tradeMarketItemInfo._mainKey] = tradeMarketItemInfo._subKey;
      else if (_itemEnchantMaxLevelList[tradeMarketItemInfo._mainKey] < tradeMarketItemInfo._subKey)
        _itemEnchantMaxLevelList[tradeMarketItemInfo._mainKey] = tradeMarketItemInfo._subKey;

      var itemEnchantIdentityKp = new KeyValuePair<int, int>(tradeMarketItemInfo._mainKey, tradeMarketItemInfo._enchantGroup);
      if (!_itemEnchantMaxGroupList.ContainsKey(itemEnchantIdentityKp))
        _itemEnchantMaxGroupList[itemEnchantIdentityKp] = tradeMarketItemInfo._subKey;
      else if (_itemEnchantMaxGroupList[itemEnchantIdentityKp] < tradeMarketItemInfo._subKey)
        _itemEnchantMaxGroupList[itemEnchantIdentityKp] = tradeMarketItemInfo._subKey;

      if (tradeMarketItemInfo._marketPriceGroup != 0L) {
        if (!_marketPriceGroupList.ContainsKey(tradeMarketItemInfo._marketPriceGroup)) {
          _marketPriceGroupList.Add(tradeMarketItemInfo._marketPriceGroup, new MarketPriceGroup());
          _marketPriceGroupList[tradeMarketItemInfo._marketPriceGroup]._enchantKeyList.Add(itemIdentityKp);
          continue;
        }

        if (!_marketPriceGroupList[tradeMarketItemInfo._marketPriceGroup]._enchantKeyList.Contains(itemIdentityKp))
          _marketPriceGroupList[tradeMarketItemInfo._marketPriceGroup]._enchantKeyList.Add(itemIdentityKp);
      }
    }

    sw.Stop();
    ServerControlLogger.LogComplete(nameof(ItemInfoManager), sw.ElapsedMilliseconds);


    #if !DEBUG
    var rv = UpdateItemInfoToRepositoryXxx();
    if (rv != 0) {
      throw new TradeMarketServerInitException(nameof(ItemInfoManager), rv, "updateItemInfoToRepositoryXXX open");
    }
    #else
    // var rv = UpdateItemInfoToRepositoryXxx();
    // if (rv != 0) {
    //   throw new TradeMarketServerInitException(nameof(ItemInfoManager), rv, "updateItemInfoToRepositoryXXX open");
    // }
    #endif
  }


  private int UpdateItemInfoToRepositoryXxx() {
    ServerControlLogger.LogStart("ItemInfoManager updateItemInfoToRepositoryXXX");
    var stopwatch = new Stopwatch();
    stopwatch.Start();
    var listLoadItemInfo = new TradeMarketListLoadItemInfo();

    try {
      var itemList = GetItemListXxx();
      var list = new List<UpdateItemInfoData>();

      foreach (var keyValuePair in itemList) {
        if (keyValuePair.Value._enchantGroup != keyValuePair.Value._subKey) continue;
        long num = 0;

        if (keyValuePair.Value.HasPriceGroup() && OptionManager.This.GetCashGroupNo() != keyValuePair.Value._mainGroupNo)
          num = keyValuePair.Value._marketPriceGroup;

        var updateItemInfoData = new UpdateItemInfoData {
          KeyType = keyValuePair.Value._keyType,
          MainKey = keyValuePair.Value._mainKey,
          SubKey = keyValuePair.Value._subKey,
          MainGroupNo = keyValuePair.Value._mainGroupNo,
          SubGroupNo = keyValuePair.Value._subGroupNo,
          BasePrice = keyValuePair.Value._basePrice,
          MinPrice = keyValuePair.Value._minPrice,
          MaxPrice = keyValuePair.Value._maxPrice,
          RealMinPrice = keyValuePair.Value._realMinPrice,
          RealMaxPrice = keyValuePair.Value._realMaxPrice,
          MarketPriceGroupKey = num,
        };
        list.Add(updateItemInfoData);
      }

      var ctxTrade = new TradeDbContext();
      var dbResult = ctxTrade.UpdateItemInfoBulk(list);
      if (!dbResult.Status) {
        Log.Error("ItemInfoManager UpdateItemInfoBulk fail - {DbResult}", dbResult);
        return -1;
      }

      // Parallel.ForEach(itemList,
      //                  new ParallelOptions {
      //                    MaxDegreeOfParallelism = 100
      //                  },
      //                  keyValuePair => {
      //                    if (keyValuePair.Value._enchantGroup != keyValuePair.Value._subKey) return;
      //                    long num = 0;
      //
      //                    if (keyValuePair.Value.hasPriceGroup() && OptionManager.This.GetCashGroupNo() != keyValuePair.Value._mainGroupNo)
      //                      num = keyValuePair.Value._marketPriceGroup;
      //
      //                    TradeDbManager.This.uspUpdateItemInfo(keyValuePair.Value._keyType,
      //                                                          keyValuePair.Value._mainKey,
      //                                                          keyValuePair.Value._subKey,
      //                                                          keyValuePair.Value._mainGroupNo,
      //                                                          keyValuePair.Value._subGroupNo,
      //                                                          0L,
      //                                                          0L,
      //                                                          0L,
      //                                                          keyValuePair.Value._basePrice,
      //                                                          keyValuePair.Value._maxPrice,
      //                                                          keyValuePair.Value._minPrice,
      //                                                          keyValuePair.Value._realMaxPrice,
      //                                                          keyValuePair.Value._realMinPrice,
      //                                                          num,
      //                                                          keyValuePair.Value._isForceDisplay,
      //                                                          out var symNo,
      //                                                          out var rv);
      //                  });
    }
    catch (Exception ex) {
      Log.Error(ex, "ItemInfoManager.uspUpdateItemInfo");
      return -2;
    }

    stopwatch.Stop();
    ServerControlLogger.LogComplete("ItemInfoManager updateItemInfoToRepositoryXXX", stopwatch.ElapsedMilliseconds);
    return 0;
  }

  public stockInfoListWrapper GetItemListXxx() {
    return new stockInfoListWrapper(_itemInfoList);
  }

  public int GetMaxEnchantLevel(int mainKey) {
    var maxEnchantLevel = 0;
    if (_itemEnchantMaxLevelList.ContainsKey(mainKey))
      maxEnchantLevel = _itemEnchantMaxLevelList[mainKey];
    return maxEnchantLevel;
  }

  public int GetEnchantMaxGroup(int mainKey,
                                int groupLevel) {
    var key = new KeyValuePair<int, int>(mainKey, groupLevel);
    var enchantMaxGroup = 0;
    if (_itemEnchantMaxGroupList.ContainsKey(key))
      enchantMaxGroup = _itemEnchantMaxGroupList[key];
    return enchantMaxGroup;
  }

  public TradeMarketItemInfo GetInfo(int itemKey,
                                     int enchantLevel) {
    var key = new KeyValuePair<int, int>(itemKey, enchantLevel);
    return !_itemInfoList.ContainsKey(key)
             ? _emptyStockInfo
             : _itemInfoList[key];
  }

  // public stockInfoListWrapper GetServantListXxx() {
  //   return new stockInfoListWrapper(_servantInfoList);
  // }
  //
  // public TradeMarketItemInfo GetServantInfo(int servantMainKey,
  //                                           int subKey) {
  //   var key = new KeyValuePair<int, int>(servantMainKey, subKey);
  //   return !_servantInfoList.ContainsKey(key)
  //            ? _emptyStockInfo
  //            : _servantInfoList[key];
  // }
}


//
// var xmlFile = CommonModule.GetXmlFile("/" + ConstantContainer._serviceProject + "WorldTradeMarketItemData/" + ConstantContainer._serviceType, "XmlMarketItemList.xml");
// while (xmlFile.Read())
//   if ((xmlFile.Name.CompareTo("ItemMarket") == 0 || xmlFile.Name.CompareTo("trademarketiteminfo") == 0) && XmlNodeType.Element == xmlFile.NodeType) {
//     var keyType = 0;
//     var itemKey = 0;
//     var enchantLevel = 0;
//     var mainGroupNo = 0;
//     var subGroupNo = 0;
//     long enchantAddPercent = 0;
//     long basePrice = 0;
//     long maxPrice = 0;
//     long minPrice = 0;
//     long maxPriceNew = 0;
//     long minPriceNew = 0;
//     var isEnchantable = false;
//     var enchantGroup = 0;
//     long enchantNeedCount = 0;
//     var isPersonalTrade = false;
//     var enchantMaterialKey = 0;
//     long weight = 0;
//     long maxStackCount = 0;
//     long tradeCountToUpdate = 0;
//     var accumulatePassCount = 0;
//     long maxRegisterForWorldMarket = 0;
//     var noticeAbleItemForWorldMarket = false;
//     var grade = 0;
//     long marketPriceGroup = 0;
//     var isForceDisplay = false;
//     try {
//       if (xmlFile.MoveToFirstAttribute())
//         do {
//           var name = xmlFile.Name;
//           if (name.CompareTo("KeyType") == 0)
//             keyType = Convert.ToInt32(xmlFile.Value);
//           else if (name.CompareTo("ItemKey") == 0)
//             itemKey = Convert.ToInt32(xmlFile.Value);
//           else if (name.CompareTo("EnchantLevel") == 0)
//             enchantLevel = Convert.ToInt32(xmlFile.Value);
//           else if (name.CompareTo("MainCategory") == 0)
//             mainGroupNo = Convert.ToInt32(xmlFile.Value);
//           else if (name.CompareTo("SubCategory") == 0)
//             subGroupNo = Convert.ToInt32(xmlFile.Value);
//           else if (name.CompareTo("BasePrice") == 0)
//             basePrice = Convert.ToInt64(xmlFile.Value);
//           else if (name.CompareTo("MinestPercent") == 0)
//             minPrice = Convert.ToInt64(xmlFile.Value);
//           else if (name.CompareTo("MaxestPercent") == 0)
//             maxPrice = Convert.ToInt64(xmlFile.Value);
//           else if (name.CompareTo("MinestPrice") == 0)
//             minPriceNew = Convert.ToInt64(xmlFile.Value);
//           else if (name.CompareTo("MaxestPrice") == 0)
//             maxPriceNew = Convert.ToInt64(xmlFile.Value);
//           else if (name.CompareTo("EnchantAddPercent") == 0)
//             enchantAddPercent = Convert.ToInt64(xmlFile.Value);
//           else if (name.CompareTo("isEnchatable") == 0)
//             isEnchantable = Convert.ToBoolean(xmlFile.Value);
//           else if (name.CompareTo("EnchantGroup") == 0)
//             enchantGroup = Convert.ToInt32(xmlFile.Value);
//           else if (name.CompareTo("EnchantNeedCount") == 0)
//             enchantNeedCount = Convert.ToInt64(xmlFile.Value);
//           else if (name.CompareTo("isPersonalTrade") == 0)
//             isPersonalTrade = Convert.ToBoolean(xmlFile.Value);
//           else if (name.CompareTo("EnchantMaterialKey") == 0)
//             enchantMaterialKey = Convert.ToInt32(xmlFile.Value);
//           else if (name.CompareTo("Weight") == 0)
//             weight = Convert.ToInt64(xmlFile.Value);
//           else if (name.CompareTo("MaxStackCount") == 0)
//             maxStackCount = Convert.ToInt64(xmlFile.Value);
//           else if (name.CompareTo("TradeCountToUpdate") == 0)
//             tradeCountToUpdate = Convert.ToInt64(xmlFile.Value);
//           else if (name.CompareTo("AccumulatePassCount") == 0)
//             accumulatePassCount = Convert.ToInt32(xmlFile.Value);
//           else if (name.CompareTo("MaxRegisterCountForWorldMarket") == 0)
//             maxRegisterForWorldMarket = Convert.ToInt32(xmlFile.Value);
//           else if (name.CompareTo("NoticeAbleItemForWorldMarket") == 0)
//             noticeAbleItemForWorldMarket = Convert.ToBoolean(xmlFile.Value);
//           else if (name.CompareTo("Grade") == 0)
//             grade = Convert.ToInt32(xmlFile.Value);
//           else if (name.CompareTo("MarketPriceGroup") == 0)
//             marketPriceGroup = Convert.ToInt64(xmlFile.Value);
//           else if (name.CompareTo("IsForceDisplay") == 0)
//             isForceDisplay = Convert.ToBoolean(xmlFile.Value);
//         } while (xmlFile.MoveToNextAttribute());
//     }
//     catch (Exception ex) {
//       LogUtil.WriteLog(string.Format("ItemInfoManager fail read Attribute - {0}", ex), "ERROR");
//       return -1;
//     }
//
//     var tradeMarketItemInfo = new TradeMarketItemInfo(keyType,
//                                                       itemKey,
//                                                       enchantLevel,
//                                                       mainGroupNo,
//                                                       subGroupNo,
//                                                       enchantAddPercent,
//                                                       maxPrice,
//                                                       minPrice,
//                                                       basePrice,
//                                                       isEnchantable,
//                                                       enchantGroup,
//                                                       enchantNeedCount,
//                                                       isPersonalTrade,
//                                                       enchantMaterialKey,
//                                                       weight,
//                                                       maxStackCount,
//                                                       tradeCountToUpdate,
//                                                       accumulatePassCount,
//                                                       maxRegisterForWorldMarket,
//                                                       noticeAbleItemForWorldMarket,
//                                                       grade,
//                                                       marketPriceGroup,
//                                                       isForceDisplay,
//                                                       maxPriceNew,
//                                                       minPriceNew);
//     switch ((KeyType)keyType) {
//       case KeyType.eItem:
//         var key1 = new KeyValuePair<int, int>(tradeMarketItemInfo._mainKey, tradeMarketItemInfo._subKey);
//         _itemInfoList[key1] = tradeMarketItemInfo;
//         if (!_itemEnchantMaxLevelList.ContainsKey(tradeMarketItemInfo._mainKey))
//           _itemEnchantMaxLevelList[tradeMarketItemInfo._mainKey] = tradeMarketItemInfo._subKey;
//         else if (_itemEnchantMaxLevelList[tradeMarketItemInfo._mainKey] < tradeMarketItemInfo._subKey)
//           _itemEnchantMaxLevelList[tradeMarketItemInfo._mainKey] = tradeMarketItemInfo._subKey;
//         var key2 = new KeyValuePair<int, int>(tradeMarketItemInfo._mainKey, tradeMarketItemInfo._enchantGroup);
//         if (!_itemEnchantMaxGrouplList.ContainsKey(key2))
//           _itemEnchantMaxGrouplList[key2] = tradeMarketItemInfo._subKey;
//         else if (_itemEnchantMaxGrouplList[key2] < tradeMarketItemInfo._subKey)
//           _itemEnchantMaxGrouplList[key2] = tradeMarketItemInfo._subKey;
//         if (tradeMarketItemInfo._marketPriceGroup != 0L) {
//           if (!_marketPriceGroupList.ContainsKey(tradeMarketItemInfo._marketPriceGroup)) {
//             _marketPriceGroupList.Add(tradeMarketItemInfo._marketPriceGroup, new MarketPriceGroup());
//             _marketPriceGroupList[tradeMarketItemInfo._marketPriceGroup]._enchantKeyList.Add(key1);
//             continue;
//           }
//
//           if (!_marketPriceGroupList[tradeMarketItemInfo._marketPriceGroup]._enchantKeyList.Contains(key1))
//             _marketPriceGroupList[tradeMarketItemInfo._marketPriceGroup]._enchantKeyList.Add(key1);
//         }
//
//         continue;
//       case KeyType.eServant:
//         _servantInfoList[new KeyValuePair<int, int>(tradeMarketItemInfo._mainKey, tradeMarketItemInfo._subKey)] = tradeMarketItemInfo;
//         continue;
//       default:
//         LogUtil.WriteLog(string.Format("ItemInfoManager fail load xml - KeyType Fail : {0}", keyType), "WARN");
//         return -1;
//     }
//   }


// Parallel.ForEach(servantList,
//                  new ParallelOptions {
//                    MaxDegreeOfParallelism = 100
//                  },
//                  keyValuePair => {
//                    if (keyValuePair.Value._enchantGroup != keyValuePair.Value._subKey) return;
//                    long num = 0;
//                    if (keyValuePair.Value.hasPriceGroup() && OptionManager.This.GetCashGroupNo() != keyValuePair.Value._mainGroupNo)
//                      num = keyValuePair.Value._marketPriceGroup;
//                    TradeDbManager.This.uspUpdateItemInfo(keyValuePair.Value._keyType,
//                                                          keyValuePair.Value._mainKey,
//                                                          keyValuePair.Value._subKey,
//                                                          keyValuePair.Value._mainGroupNo,
//                                                          keyValuePair.Value._subGroupNo,
//                                                          0L,
//                                                          0L,
//                                                          0L,
//                                                          keyValuePair.Value._basePrice,
//                                                          keyValuePair.Value._maxPrice,
//                                                          keyValuePair.Value._minPrice,
//                                                          keyValuePair.Value._realMaxPrice,
//                                                          keyValuePair.Value._realMinPrice,
//                                                          num,
//                                                          keyValuePair.Value._isForceDisplay,
//                                                          out var symNo,
//                                                          out var rv);
//                  });