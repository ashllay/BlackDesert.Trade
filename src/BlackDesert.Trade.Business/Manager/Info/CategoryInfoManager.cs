using BlackDesert.Trade.Domain.Abstract;
using BlackDesert.Trade.Domain.Models.Xml;

namespace BlackDesert.Trade.Business.Manager.Info;

public class CategoryInfoManager : SingletonBase<CategoryInfoManager>
{
  private readonly Dictionary<int, List<int>> _categoryInfoList;
  private readonly List<KeyValuePair<int, int>> _categoryKeyList;

  private CategoryInfoManager() {
    _categoryInfoList = new Dictionary<int, List<int>>();
    _categoryKeyList = new List<KeyValuePair<int, int>>();
    
    var stopwatch = Stopwatch.StartNew();
 
    ServerControlLogger.LogStart(nameof(CategoryInfoManager));
    var xmlData = XmlModule.This.ReadXml<XmlMarketCategoryList>();
    foreach (var ctg in xmlData.Categories) {
      if (!_categoryInfoList.ContainsKey(ctg.MainCategoryNo)) _categoryInfoList.Add(ctg.MainCategoryNo, new List<int>());
      _categoryInfoList[ctg.MainCategoryNo].Add(ctg.SubCategoryNo);
      _categoryKeyList.Add(new KeyValuePair<int, int>(ctg.MainCategoryNo, ctg.SubCategoryNo));
    }

    stopwatch.Stop();
    ServerControlLogger.LogComplete(nameof(CategoryInfoManager), stopwatch.ElapsedMilliseconds);
  }
  


  public KeyValuePair<int, int> GetNextCategory(ref int currentIndex) {
    if (_categoryKeyList.Count <= currentIndex)
      currentIndex = 0;
    var categoryKey = _categoryKeyList[currentIndex];
    ++currentIndex;
    return categoryKey;
  }
}


// public Dictionary<KeyValuePair<int, string>, List<KeyValuePair<int, string>>> CategoryList {
//   get {
//     var categoryList = new Dictionary<KeyValuePair<int, string>, List<KeyValuePair<int, string>>>();
//     var empty = string.Empty;
//     try {
//       foreach (var categoryInfo in _categoryInfoList) {
//         var key1 = categoryInfo.Key;
//         var key2 = new KeyValuePair<int, string>(key1, StringManager.This().CategoryStringList[string.Format("{0}_0", key1)]);
//         foreach (var key3 in categoryInfo.Value) {
//           var key4 = string.Format("{0}_{1}", key1, key3);
//           if (!StringManager.This().CategoryStringList.ContainsKey(key4)) {
//             var keyValuePair = new KeyValuePair<int, string>(key3, "-");
//             if (!categoryList.ContainsKey(key2))
//               categoryList.Add(key2, new List<KeyValuePair<int, string>>());
//             categoryList[key2].Add(keyValuePair);
//           }
//           else {
//             var keyValuePair = new KeyValuePair<int, string>(key3, StringManager.This().CategoryStringList[key4]);
//             if (!categoryList.ContainsKey(key2))
//               categoryList.Add(key2, new List<KeyValuePair<int, string>>());
//             categoryList[key2].Add(keyValuePair);
//           }
//         }
//       }
//     }
//     catch (Exception ex) {
//       Log.Error(ex,"CategoryInfoManager.CategoryList Exception");
//       return new Dictionary<KeyValuePair<int, string>, List<KeyValuePair<int, string>>>();
//     }
//
//     return categoryList;
//   }
// }