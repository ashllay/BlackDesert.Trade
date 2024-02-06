using BlackDesert.Trade.Business.Services;
using BlackDesert.Trade.Domain.DB.Context;

namespace BlackDesert.Trade.Business.Manager.Timers;

public class UpdateCurrentPriceTimer
{
  private static readonly object _locker = new();
  private static bool _flag;

  public static void Execute(object? state) {
    lock (_locker) {
      if (_flag)
        return;
      _flag = true;
    }

    try {
      UpdateCurrentPrice();
      ServerControlLogger.LogRunTimer(nameof(UpdateCurrentPriceTimer));
    }
    catch (Exception ex) {
      Log.Error(ex, "[Timers Error] UpdateCurrentPriceTimer Exception");
    }

    lock (_locker) {
      _flag = false;
    }
  }

  private static int UpdateCurrentPrice() {
    var commonResult = new CommonResult();
    var tradeProcess = new TradeProcessService(new TradeDbContext());
    var ctxGame = new GameDbContext();
    var dbResult = tradeProcess.UpdateCurrentPriceProcess();
    if (!dbResult.Status) {
      Log.Warning("[DB ERROR] UpdateCurrentPrice() - UpdateCurrentPriceProcess() {@dbResult}", dbResult);
      return dbResult.Rv;
    }

    if (dbResult.Data.Count == 0) {
      Log.Information("[DB INFO] UpdateCurrentPrice() - UpdateCurrentPriceProcess() Count = 0");
      return 0;
    }

    foreach (var currentPriceResult in dbResult.Data) {
      try {
        var result = ctxGame.UpdateCurrentPrice(currentPriceResult._mainKey, currentPriceResult._subKey, currentPriceResult._pricePerOne);
        if (!result.Status) {
          Log.Error("[DB ERROR] UpdateCurrentPrice() - uspUpdateCurrentPrice() rv : {0} , symNo : {1}", result, currentPriceResult._mainKey);
          return -1;
        }
        return result.Rv;
      }
      catch (Exception ex) {
        Log.Error(ex, "[DB ERROR] UpdateCurrentPrice() Exception");
        return 1;
      }
    }
    return 0;
  }
}