using BlackDesert.Trade.Business.Manager.Abstract;
using BlackDesert.Trade.Business.Manager.Timers;
using BlackDesert.Trade.Domain.Abstract;

namespace BlackDesert.Trade.Business.Manager.Server;

public class ServerControlManager : SingletonBase<ServerControlManager>
{
  private ServerControlManager() {
    var errorCode = 0;
    ServerControlLogger.LogStart("ServerControlManager");
    var stopwatch = Stopwatch.StartNew();
    XmlModule.This.Init();
    ServerInfoManager.This.Init();
    OptionManager.This.Init ();
    VariedPriceInfoManager.This.Init ();
    ItemInfoManager.This.Init();
    TickCountManager.This.Init();
    VariedTradeCountManager.This.Init();
    BiddingInfoManager.This.Init();
    StockInfoManger.This.Init();
    CategoryInfoManager.This.Init();
    FamilySkillManager.This.Init();
    HistoryTruncateManager.This.Init();
    TimerManager.This.Init();
    DbConnectionCheckTimer.This.Init(); //init
    stopwatch.Stop();
    ServerControlLogger.LogComplete("ServerControlManager ", stopwatch.ElapsedMilliseconds);
    ServerControlLogger.LogOpen("ServerControlManager Service Start!!!");
  }


  // private void UpdateDatabase() {
  //   ServerControlLogger.LogStart("ServerControlManager UpdateDatabase");
  //   var stopwatch = new Stopwatch();
  //   stopwatch.Start();
  //   var repositoryXxx1 = ItemInfoManager.This.UpdateItemInfoToRepositoryXxx();
  //   if (repositoryXxx1 != 0) {
  //     throw new TradeMarketServerInitException(nameof(ServerControlManager), repositoryXxx1 , "updateItemInfoToRepositoryXXX open");
  //   }
  //
  //   var repositoryXxx2 = TickCountManager.This.UpdateTickCountToRepositoryXxx();
  //   if (repositoryXxx2 != 0) {
  //     throw new TradeMarketServerInitException(nameof(ServerControlManager), repositoryXxx2 , "updateTickCountToRepositoryXXX open");
  //   }
  //   var num = OptionManager.This.UpdateRingBuffRateXxx();
  //   if (num != 0) {
  //     throw new TradeMarketServerInitException(nameof(ServerControlManager), num , "updateRingBuffRateXXX open");
  //   }
  //
  //   stopwatch.Stop();
  //   ServerControlLogger.LogComplete("ServerControlManager UpdateDatabase", stopwatch.ElapsedMilliseconds);
  // }
}