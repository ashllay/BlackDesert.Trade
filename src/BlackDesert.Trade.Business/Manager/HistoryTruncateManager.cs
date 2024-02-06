using BlackDesert.Trade.Domain.Abstract;
using BlackDesert.Trade.Domain.DB.Context;

namespace BlackDesert.Trade.Business.Manager;

public class HistoryTruncateManager : SingletonBase<HistoryTruncateManager>
{
  private HistoryTruncateManager() {
    var stopwatch = new Stopwatch();
    ServerControlLogger.LogStart(nameof(HistoryTruncateManager));
    stopwatch.Start();
    var ctxWorld = new WorldDbContext();
    var resultClearTradeAuthHistory = ctxWorld.ClearTradeAuthHistory();
    if (!resultClearTradeAuthHistory) {
      throw new TradeMarketServerInitException(nameof(HistoryTruncateManager), -1, "ClearTradeAuthHistory");
    }

    var gameDbContext = new GameDbContext();
    var resultClearNoticeItemList = gameDbContext.ClearNoticeItemList();
    if (!resultClearNoticeItemList) {
      throw new TradeMarketServerInitException(nameof(HistoryTruncateManager), -1, "ClearNoticeItemList");
    }

    var ctxTrade = new TradeDbContext();
    var resultClearNoticeItemListTrade = ctxTrade.ClearNoticeItemListTrade();
    if (!resultClearNoticeItemListTrade) {
      throw new TradeMarketServerInitException(nameof(HistoryTruncateManager), -1, "ClearNoticeItemListTrade");
    }

    stopwatch.Stop();
    ServerControlLogger.LogComplete(nameof(HistoryTruncateManager), stopwatch.ElapsedMilliseconds);
  }
}