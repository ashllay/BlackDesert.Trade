using BlackDesert.Trade.Domain.Abstract;
using BlackDesert.Trade.Domain.Models.Xml;

namespace BlackDesert.Trade.Business.Manager.Info;

public class VariedPriceInfoManager : SingletonBase<VariedPriceInfoManager>
{
  private const long MaxPriceRange = 10_000_000_000_000;
  private readonly List<TradeMarketVariedPriceInfo> _variedPriceInfoStaticStatusList;
  private readonly List<long> _variedPriceUnitList;

  private VariedPriceInfoManager() {
    _variedPriceInfoStaticStatusList = new List<TradeMarketVariedPriceInfo>();
    _variedPriceUnitList = new List<long>();
    var stopwatch = new Stopwatch();
    var index = 0;
    ServerControlLogger.LogStart(nameof(VariedPriceInfoManager));
    stopwatch.Start();
    var xmlData = XmlModule.This.ReadXml<XmlMarketVariedPriceInfoList>();
    foreach (var variedPriceInfo in xmlData.VariedPriceInfoList) {
      _variedPriceInfoStaticStatusList.Add(new TradeMarketVariedPriceInfo(variedPriceInfo.StartRangePrice,
                                                                          variedPriceInfo.EndRangePrice,
                                                                          variedPriceInfo.UnitPrice,
                                                                          index,
                                                                          variedPriceInfo.PassBiddingCount,
                                                                          variedPriceInfo.PricePoint));
      ++index;
    }

    _variedPriceInfoStaticStatusList.Sort((Comparison<TradeMarketVariedPriceInfo>)((a,
                                                                                    b) => {
                                                                                      if (a._startPrice > b._startPrice)
                                                                                        return 1;
                                                                                      return a._startPrice < b._startPrice
                                                                                               ? -1
                                                                                               : 0;
                                                                                    }));
    var rv = InitCalculatePrice();
    if (rv != 0)
      throw new TradeMarketServerInitException(nameof(VariedPriceInfoManager), rv, "InitCalculatePrice");
    stopwatch.Stop();
    ServerControlLogger.LogComplete(nameof(VariedPriceInfoManager), stopwatch.ElapsedMilliseconds);

  }

  public long CalculatePrice(long newPrice,
                             string roundType = "") {
    var variedPriceInfoXxx = FindTradeMarketVariedPriceInfoXxx(newPrice);
    if (variedPriceInfoXxx == null)
      return 0;
    var num1 = (newPrice - variedPriceInfoXxx._startPrice) / variedPriceInfoXxx._uintPrice;
    var num2 = (newPrice - variedPriceInfoXxx._startPrice) % variedPriceInfoXxx._uintPrice;
    return !string.IsNullOrEmpty(roundType) ? !roundType.Equals("UP")
                                                ? !roundType.Equals("DOWN")
                                                    ? 0L
                                                    : variedPriceInfoXxx._startPrice + variedPriceInfoXxx._uintPrice * num1
                                                : variedPriceInfoXxx._startPrice + variedPriceInfoXxx._uintPrice * (num1 + 1L) :
           num2 > variedPriceInfoXxx._uintPrice / 2L ? variedPriceInfoXxx._startPrice + variedPriceInfoXxx._uintPrice * (num1 + 1L) :
           variedPriceInfoXxx._startPrice + variedPriceInfoXxx._uintPrice * num1;
  }

  private int InitCalculatePrice() {

    var stopwatch = new Stopwatch();
    ServerControlLogger.LogStart("VariedPriceInfoManager initCalculatePrice");
    stopwatch.Start();
    if (_variedPriceUnitList.Count == 0)
      for (var index = 0; index < _variedPriceInfoStaticStatusList.Count; ++index) {
        var infoStaticStatus = _variedPriceInfoStaticStatusList[index];
        var num1 = infoStaticStatus._startPrice;
        var num2 = infoStaticStatus._startPrice + infoStaticStatus._uintPrice;
        var num3 = 10000000000000L <= infoStaticStatus._endPrice
                     ? 20000000000000L
                     : infoStaticStatus._endPrice;
        while (num1 <= num3) {
          _variedPriceUnitList.Add(num1);
          num1 = num2;
          num2 += infoStaticStatus._uintPrice;
        }
      }
    stopwatch.Stop();
    ServerControlLogger.LogComplete("VariedPriceInfoManager initCalculatePrice", stopwatch.ElapsedMilliseconds);
    return 0;
  }

  public List<TradeMarketVariedPriceInfo> GetList() {
    return _variedPriceInfoStaticStatusList;
  }

  public List<long> GetPriceUnitList() {
    return _variedPriceUnitList;
  }

  public long GetUnitPrice(long pricePerOne) {
    var variedPriceInfoXxx = FindTradeMarketVariedPriceInfoXxx(pricePerOne);
    return variedPriceInfoXxx == null
             ? 0L
             : variedPriceInfoXxx._uintPrice;
  }

  public List<long> GetBiddingList(
    long basePrice,
    double rate,
    TradeMarketItemInfo itemStaticStatus) {
    var num1 = (long)(basePrice * (1.0 - rate));
    var num2 = (long)(basePrice * (1.0 + rate));
    var biddingList = new List<long>();
    if (num1 < itemStaticStatus._minPrice)
      num1 = itemStaticStatus._minPrice;
    if (itemStaticStatus._maxPrice < num2)
      num2 = itemStaticStatus._maxPrice;
    var pricePerOne1 = basePrice;
    var variedPriceInfoXxx1 = FindTradeMarketVariedPriceInfoXxx(pricePerOne1);
    if (variedPriceInfoXxx1 == null)
      return biddingList;
    while (pricePerOne1 <= num2) {
      pricePerOne1 += variedPriceInfoXxx1._uintPrice;
      if (num2 >= pricePerOne1) {
        biddingList.Add(pricePerOne1);
        if (variedPriceInfoXxx1._endPrice < pricePerOne1) {
          variedPriceInfoXxx1 = GetTradeMarketVariedPriceInfoXxx(variedPriceInfoXxx1._index + 1);
          if (variedPriceInfoXxx1 == null)
            break;
        }
      }
      else {
        break;
      }
    }

    var pricePerOne2 = basePrice;
    var variedPriceInfoXxx2 = FindTradeMarketVariedPriceInfoXxx(pricePerOne2);
    if (variedPriceInfoXxx2 == null)
      return biddingList;
    while (num1 <= pricePerOne2) {
      pricePerOne2 -= variedPriceInfoXxx2._uintPrice;
      if (pricePerOne2 >= num1) {
        biddingList.Add(pricePerOne2);
        if (pricePerOne2 <= variedPriceInfoXxx2._startPrice) {
          variedPriceInfoXxx2 = GetTradeMarketVariedPriceInfoXxx(variedPriceInfoXxx2._index - 1);
          if (variedPriceInfoXxx2 == null)
            break;
        }
      }
      else {
        break;
      }
    }

    biddingList.Add(basePrice);
    biddingList.Sort((a,
                      b) => {
      if (a > b)
        return 1;
      return a < b
               ? -1
               : 0;
    });
    return biddingList;
  }

  public void GetWorldMarketPassCount(
    long pricePerOne,
    ref long passBiddingCount,
    ref long worldMarketPricePoint) {
    var variedPriceInfoXxx = FindTradeMarketVariedPriceInfoXxx(pricePerOne);
    if (variedPriceInfoXxx == null) {
      passBiddingCount = 0L;
      worldMarketPricePoint = 0L;
    }
    else {
      passBiddingCount = variedPriceInfoXxx._passBiddingCount;
      worldMarketPricePoint = variedPriceInfoXxx._worldMarketPricePoint;
    }
  }

  public TradeMarketVariedPriceInfo GetTradeMarketVariedPriceInfoXxx(
    int index) {
    return 0 > index || index >= _variedPriceInfoStaticStatusList.Count
             ? null
             : _variedPriceInfoStaticStatusList[index];
  }

  public TradeMarketVariedPriceInfo FindTradeMarketVariedPriceInfoXxx(
    long pricePerOne) {
    var num1 = 0;
    var num2 = _variedPriceInfoStaticStatusList.Count - 1;
    while (num1 <= num2) {
      var index = (num1 + num2) / 2;
      var infoStaticStatus = _variedPriceInfoStaticStatusList[index];
      if (infoStaticStatus._startPrice <= pricePerOne && pricePerOne <= infoStaticStatus._endPrice)
        return infoStaticStatus;
      if (pricePerOne < infoStaticStatus._startPrice)
        num2 = index - 1;
      else if (infoStaticStatus._endPrice < pricePerOne)
        num1 = index + 1;
    }

    return null;
  }
}