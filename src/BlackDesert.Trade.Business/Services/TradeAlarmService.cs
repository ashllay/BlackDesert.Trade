using BlackDesert.Trade.Business.Common;

using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;

namespace BlackDesert.Trade.Business.Services;

public sealed class TradeAlarmService
{
  private static TradeAlarmService? _instance;
  private TradeAlarmService() { }

  public static TradeAlarmService This {
    get {
      _instance ??= new TradeAlarmService();
      return _instance;
    }
  }


  private static TaskQueue _task = new();

  public void SendAlarm(List<string> userIdList,
                        int itemKey,
                        string action) {
    if (!Convert.ToBoolean(ConstantContainer.DoSendAlarm))
      return;

    var task = new Action(() => {
      foreach (var userId in userIdList) {
        try {
          var alarmMarket = new AlarmTradeMarketModel {
            Platform = ConstantContainer.ServiceType,
            Region = ConstantContainer.ServiceType,
            TargetUserId = userId,
            ItemKey = itemKey,
            Action = action
          };
          var sendAlarmModel = new SendAlarmModel {
            topic = "TradeMarket|" + ConstantContainer.ServiceType + "|" + ConstantContainer.ServiceType,
            param = JsonConvert.SerializeObject(alarmMarket)
          };
          //TODO: Save or send alarm
        }
        catch (Exception ex) {
          Log.Error(ex, "TradeAlarmService.SendAlarm - Exception {UserId}", userId);
        }
      }
    });
    _task.AddToQueue(task);
  }
}