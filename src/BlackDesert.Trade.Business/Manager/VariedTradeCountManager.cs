using BlackDesert.Trade.Domain.Abstract;
using BlackDesert.Trade.Domain.Models.Xml;
using BlackDesert.Trade.Domain.Models.Xml.Sub;

namespace BlackDesert.Trade.Business.Manager;

public class VariedTradeCountManager : SingletonBase<VariedTradeCountManager>
{
  private readonly List<XmlMarketVariedTradeCount> _variedTradeCountInfoStaticStatusList;

  private VariedTradeCountManager() {
    _variedTradeCountInfoStaticStatusList = new List<XmlMarketVariedTradeCount>();
    var stopwatch = Stopwatch.StartNew();
    ServerControlLogger.LogStart(nameof(VariedTradeCountManager));
    var xmlData = XmlModule.This.ReadXml<XmlMarketVariedTradeCountList>();
    _variedTradeCountInfoStaticStatusList.Clear();
    xmlData.VariedTradeCountList.ForEach(x => _variedTradeCountInfoStaticStatusList.Add(x));
    _variedTradeCountInfoStaticStatusList.Sort((Comparison<XmlMarketVariedTradeCount>)((a,
                                                                                               b) => {
                                                                                                 if (a.MinFamilyPoint > b.MinFamilyPoint)
                                                                                                   return 1;
                                                                                                 return a.MinFamilyPoint < b.MinFamilyPoint
                                                                                                          ? -1
                                                                                                          : 0;
                                                                                               }));

    stopwatch.Stop();
    ServerControlLogger.LogComplete(nameof(VariedTradeCountManager), stopwatch.ElapsedMilliseconds);
  }


  public int GetAddPearlItemLimitTradeCountByFamilyPoint(long familyPoint) {
    foreach (var infoStaticStatus in _variedTradeCountInfoStaticStatusList)
      if (infoStaticStatus.MinFamilyPoint <= familyPoint && familyPoint <= infoStaticStatus.MaxFamilyPoint)
        return infoStaticStatus.AddTradeCount;
    return 0;
  }

  public double GetAddTaxDiscountRateByFamilyPoint(long familyPoint) {
    double rateByFamilyPoint;
    if (0L <= familyPoint && familyPoint < 1000L) {
      rateByFamilyPoint = 0.0;
    }
    else if (1000L <= familyPoint && familyPoint < 4000L) {
      rateByFamilyPoint = 5000.0;
    }
    else if (4000L <= familyPoint && familyPoint < 7000L) {
      rateByFamilyPoint = 10000.0;
    }
    else if (7000L <= familyPoint) {
      rateByFamilyPoint = 15000.0;
    }
    else {
      rateByFamilyPoint = 0.0;
      Log.Warning("GetAddTaxDiscountRateByFamilyPoint {familyPoint}", familyPoint);
    }

    return rateByFamilyPoint;
  }
}