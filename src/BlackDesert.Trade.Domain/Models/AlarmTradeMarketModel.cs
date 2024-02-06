namespace BlackDesert.Trade.Domain.Models;

public class AlarmTradeMarketModel
{
  public string Platform { get; set; }

  public string Region { get; set; }

  public string TargetUserId { get; set; }

  public int ItemKey { get; set; }

  public string Action { get; set; }
}