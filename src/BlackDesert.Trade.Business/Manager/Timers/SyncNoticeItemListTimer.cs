using BlackDesert.Trade.Domain.DB.Context;

namespace BlackDesert.Trade.Business.Manager.Timers;

public class SyncNoticeItemListTimer
{
  private static readonly object _locker = new();
  private static bool _flag;
  private static long _updateTime;

  public static void Execute(object? state) {
    lock (_locker) {
      if (_flag)
        return;
      _flag = true;
    }

    try {
      Sync();
      ServerControlLogger.LogRunTimer(nameof(SyncNoticeItemListTimer));
    }
    catch (Exception ex) {
      Log.Error(ex, "[Timers Error] SyncNoticeItemListTimer Exception");
    }

    lock (_locker) {
      _flag = false;
    }
  }

  private static int Sync() {
    var commonResult = new CommonResult();
    var errorMsg = string.Empty;
    var relResult = string.Empty;
    
    if (_updateTime == 0L)
      _updateTime = DateTime.UtcNow.ConvertUnixTime();
    
    var ctxGame = new GameDbContext();
    var ctxTrade = new TradeDbContext();
    var noticeItemList = ctxTrade.ListNoticeItem(_updateTime);
    if (noticeItemList.Count == 0) {
      Log.Information("[DB INFO] SyncNoticeItemListTimer.Sync() - ListNoticeItem() {@ListNoticeItem}", noticeItemList);
      return 0;
    }

    foreach (var noticeItemResult in noticeItemList)
      try {
        var res = ctxGame.InsertToNoticeItem_Unsafe(noticeItemResult._registTimeStamp,
                                                    noticeItemResult._keyType,
                                                    noticeItemResult._mainKey,
                                                    noticeItemResult._subKey,
                                                    noticeItemResult._price,
                                                    noticeItemResult._changedValue,
                                                    noticeItemResult._noticeType);
        if (!res.Status) {
          Log.Error("[DB ERROR] SyncNoticeItemListTimer.Sync() - uspInsertToNoticeItem() rv : {0} , symNo : {1}", res, noticeItemResult._mainKey);
        }
      }
      catch (Exception ex) {
        Log.Error(ex, "[DB Exception] SyncNoticeItemListTimer.Sync() - uspInsertToNoticeItem() Exception");
      }

    _updateTime = noticeItemList.Last()._registTimeStamp;
    return 0;
  }
}