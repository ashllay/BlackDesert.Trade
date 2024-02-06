using BlackDesert.Trade.Domain.Abstract;
using BlackDesert.Trade.Domain.DB.Context;
using BlackDesert.Trade.Domain.Models.Xml;

namespace BlackDesert.Trade.Business.Manager;

public class OptionManager : SingletonBase<OptionManager>
{
  private readonly XmlMarketOption _xmlMarketData;

  private OptionManager() {
    var stopwatch = Stopwatch.StartNew();
    ServerControlLogger.LogStart(nameof(OptionManager));
    _xmlMarketData = XmlModule.This.ReadXml<XmlMarketOption>();
    var ctxTrade = new TradeDbContext();
    var resInitOption = ctxTrade.InitMarketOption(_xmlMarketData.RingBuffRate);
    if (!resInitOption.Status) {
      throw new TradeMarketServerInitException(nameof(OptionManager), resInitOption.Rv, "InitMarketOption");
    }

    stopwatch.Stop();
    ServerControlLogger.LogComplete(nameof(OptionManager), stopwatch.ElapsedMilliseconds);
  }

  public double BiddingRatio {
    get => _xmlMarketData.BiddingPercent / 1_000_000.0;
    // set => _biddingRatio = value / 1000000.0;
  }


  public long GetMaxWeight() => _xmlMarketData.Weight;

  public int GetMaxWeightRate() => _xmlMarketData.WeightRate;

  public int GetBiddingPercent() => _xmlMarketData.BiddingPercent;

  public int GetCashGroupNo() => _xmlMarketData.CashGroupNo;

  // public int GetSystemBuyPercent() => _xmlMarketData.BuyPercent;

  // public int GetSystemStockPercent() => _xmlMarketData.StockPercent;


  public int GetPearlItemLimitedMaxCount() => _xmlMarketData.PearlItemLimitedMaxCount;

  public bool IsSleepTime() {
    var hour = DateTime.Now.Hour;
    if (_xmlMarketData.EndSleepHour == _xmlMarketData.StartSleepHour)
      return false;
    return _xmlMarketData.EndSleepHour < _xmlMarketData.StartSleepHour
             ? _xmlMarketData.StartSleepHour <= hour || hour < _xmlMarketData.EndSleepHour
             : _xmlMarketData.StartSleepHour <= hour && hour < _xmlMarketData.EndSleepHour;
  }

  public int GetIncreaseWeightByFamilyPoint(int familyPoint) {
    var weightByFamilyPoint = familyPoint * _xmlMarketData.IncreaseFamilyPointWeightRate;
    if (_xmlMarketData.IncreaseMaxWeight < weightByFamilyPoint)
      weightByFamilyPoint = _xmlMarketData.IncreaseMaxWeight;
    return weightByFamilyPoint;
  }

  public int GetIncreaseWeightByBuff(DateTime buffExpiration) {
    return buffExpiration < CultureModule.GetCustomTimeNow()
             ? 0
             : _xmlMarketData.IncreaseWeightByBuff;
  }

  // public int UpdateRingBuffRateXxx() {
  //   ServerControlLogger.LogStart("OptionManager updateRingBuffRateXXX");
  //   var stopwatch = new Stopwatch();
  //   stopwatch.Start();
  //   try {
  //     Convert.ToString(symNo);
  //     if (rv != 0) {
  //       Log.Warning("OptionManager.InitMarketOption fail {Rv}", rv);
  //       return -1;
  //     }
  //   }
  //   catch (Exception ex) {
  //     Log.Error(ex, "OptionManager.InitMarketOption Exception");
  //     return -2;
  //   }
  //
  //   stopwatch.Stop();
  //   ServerControlLogger.LogComplete("OptionManager updateRingBuffRateXXX", stopwatch.ElapsedMilliseconds);
  //   return 0;
  // }

  public double MinPriceRatio => 1.0 - BiddingRatio;
  public double MaxPriceRatio => 1.0 + BiddingRatio;
}