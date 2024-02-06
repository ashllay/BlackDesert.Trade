using BlackDesert.Trade.Domain.Abstract;
using BlackDesert.Trade.Domain.DB.Context;

namespace BlackDesert.Trade.Business.Manager.Timers;

public sealed class DbConnectionCheckTimer : SingletonBase<DbConnectionCheckTimer>
{
  private static bool _isStarted;

  private static DbConnectionCheckTimer? _instance;
  private readonly Timer _gameDbCheckTimer;
  private readonly Timer _logDbCheckTimer;
  private readonly Timer _tradeDbCheckTimer;
  private readonly Timer _worldDbCheckTimer;

  private DbConnectionCheckTimer() {
    if (_isStarted) return;

    _isStarted = true;
    const int dueTime = 5000;
    const int period = 5000;
    _logDbCheckTimer = new Timer(CheckLogDb, null, dueTime, period);
    _worldDbCheckTimer = new Timer(CheckWorldDb, null, dueTime, period);
    _gameDbCheckTimer = new Timer(CheckGameDb, null, dueTime, period);
    _tradeDbCheckTimer = new Timer(CheckTradeDb, null, dueTime, period);
  }

  private void CheckLogDb(object? e) {
    var logDb = new LogDbContext();
    var can = logDb.Database.CanConnect();
    if (can) {
      logDb.Dispose();
      return;
    }

    Log.Fatal("LogDb Connection Fail");
  }

  private void CheckWorldDb(object? e) {
    var worldDb = new WorldDbContext();
    var can = worldDb.Database.CanConnect();
    if (can) {
      worldDb.Dispose();
      return;
    }

    Log.Fatal("WorldDb Connection Fail");
  }

  private void CheckGameDb(object? e) {
    var gameDb = new GameDbContext();
    var can = gameDb.Database.CanConnect();
    if (can) {
      gameDb.Dispose();
      return;
    }

    Log.Fatal("GameDb Connection Fail");
  }

  private void CheckTradeDb(object? e) {
    var tradeDb = new TradeDbContext();
    var can = tradeDb.Database.CanConnect();
    if (can) {
      tradeDb.Dispose();
      return;
    }

    Log.Fatal("TradeDb Connection Fail");
  }
}