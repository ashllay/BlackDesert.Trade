using BlackDesert.Trade.Business.Manager.Timers;
using BlackDesert.Trade.Domain.Abstract;

namespace BlackDesert.Trade.Business.Manager.Server;

public class TimerManager : SingletonBase<TimerManager>
{
  private readonly List<Timer> _timerList = new();

  private TimerManager() {
    var stopwatch =  Stopwatch.StartNew();
    ServerControlLogger.LogStart("TimerManager");
    _timerList.Add(new Timer(SyncNoticeItemListTimer.Execute, null, 10000, 10000));
    ServerControlLogger.LogSetTimer("TimerManager TimerSet - SyncNoticeItemListTimer");
    _timerList.Add(new Timer(UpdateCurrentPriceTimer.Execute, null, 60000, 60000));
    ServerControlLogger.LogSetTimer("TimerManager TimerSet - UpdateCurrentPriceTimer");
    _timerList.Add(new Timer(UpdateTickCountTimer.Execute, null, 1800000, 1_800_000));
    ServerControlLogger.LogSetTimer("TimerManager TimerSet - UpdateTickCountTimer");
    // _timerList.Add(new Timer(UpdateSystemCountTimer.Execute, null, 600000, 600000));
    // ServerControlLogger.LogSetTimer("WorldMarketServerInfoManager TimerSet - UpdateSystemCountTimer");
    _timerList.Add(new Timer(WaitSellItemTimer.Execute, null, 10000, 10000));
    ServerControlLogger.LogSetTimer("TimerManager TimerSet - waitSellItem");
    stopwatch.Stop();
    ServerControlLogger.LogComplete("TimerManager", stopwatch.ElapsedMilliseconds);
  }

}