namespace BlackDesert.Trade.Domain.Models.Api;

public class GameTradeMarketRequestBuyBiddingAuthModel
{
  public GameTradeMarketRequestBuyBiddingAuthModel() {
    userNo = 0L;
    certifiedKey = string.Empty;
    keyType = 0;
    mainKey = 0;
    subKey = 0;
    count = 0L;
  }

  public long userNo { set; get; }

  public string certifiedKey { set; get; }

  public long buyNo { set; get; }

  public int keyType { set; get; }

  public int mainKey { set; get; }

  public int subKey { set; get; }

  public long count { set; get; }
}