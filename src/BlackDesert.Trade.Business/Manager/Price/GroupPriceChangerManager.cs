namespace BlackDesert.Trade.Business.Manager.Price;

public class GroupPriceChangerManager
{
  private static readonly object _locker = new();
  private static volatile GroupPriceChangerManager _singleton;
  private Dictionary<long, List<GroupPriceChanger>> _priceData;

  private GroupPriceChangerManager() {
    clear();
  }

  public IEnumerable<GroupPriceChanger> changerList => _priceData.SelectMany((Func<KeyValuePair<long, List<GroupPriceChanger>>, IEnumerable<GroupPriceChanger>>)(price => price.Value));

  public static GroupPriceChangerManager This() {
    if (_singleton == null)
      lock (_locker) {
        if (_singleton == null)
          _singleton = new GroupPriceChangerManager();
      }

    return _singleton;
  }

  public void clear() {
    _priceData = new Dictionary<long, List<GroupPriceChanger>>();
  }

  public void add(
    ResultWorldMarketAccumulateTrade record,
    long nextPrice,
    long nextGraphPrice) {
    var info = ItemInfoManager.This.GetInfo(record._mainKey, record._subKey);
    if (!_priceData.ContainsKey(info._marketPriceGroup))
      _priceData.Add(info._marketPriceGroup, new List<GroupPriceChanger>());
    _priceData[info._marketPriceGroup].Add(new GroupPriceChanger(record, nextPrice, nextGraphPrice));
  }

  public void update() {
    _priceData.Keys.ToList()
              .ForEach(group => {
                var source1 = _priceData[group];
                var num = source1.Max((Func<GroupPriceChanger, double>)(groupPriceChanger => groupPriceChanger.PriceRatio));
                var flag = false;
                foreach (var groupPriceChanger in source1)
                  if (0.05 < Math.Abs(num - groupPriceChanger.PriceRatio)) {
                    groupPriceChanger.NextPriceRatio = num;
                    flag = true;
                  }

                if (flag)
                  return;
                var source2 = source1.Select((Func<GroupPriceChanger, double>)(groupPriceChanger => groupPriceChanger.NextPriceRatio - groupPriceChanger.PriceRatio))
                                     .Where(ratioDiff => 0.0 != ratioDiff);
                if (!source2.Any())
                  return;
                var validDiffRatioAverage = source2.Average();
                source1.ForEach((Action<GroupPriceChanger>)(groupPriceChanger => groupPriceChanger.NextPriceRatio = groupPriceChanger.PriceRatio + validDiffRatioAverage));
              });
  }
}