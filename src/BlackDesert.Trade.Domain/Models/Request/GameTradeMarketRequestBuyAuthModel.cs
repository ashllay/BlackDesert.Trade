namespace BlackDesert.Trade.Domain.Models.Api;

public class GameTradeMarketRequestBuyAuthModel
{
  public GameTradeMarketRequestBuyAuthModel() {
    userNo = 0L;
    certifiedKey = string.Empty;
    buyKeyType = 0;
    buyMainKey = 0;
    buySubKey = 0;
    buyPrice = 0L;
    buyCount = 0L;
    buyChooseKey = 0;
    otp = string.Empty;
    retryBiddingNo = 0L;
    ticketNo = string.Empty;
  }

  public long userNo { set; get; }

  public string certifiedKey { set; get; }

  public int buyKeyType { set; get; }

  public int buyMainKey { set; get; }

  public int buySubKey { set; get; }

  public long buyPrice { set; get; }

  public long buyCount { set; get; }

  public int buyChooseKey { set; get; }

  public string otp { set; get; }

  public long retryBiddingNo { set; get; }

  public string ticketNo { set; get; }
}