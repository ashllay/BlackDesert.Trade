namespace BlackDesert.Trade.Domain.Models.Api;

public class GameTradeMarketRequestUserAuthModel
{
  public GameTradeMarketRequestUserAuthModel() {
    userNo = 0L;
    certifiedKey = string.Empty;
  }

  public long userNo { set; get; }

  public string certifiedKey { set; get; }
}