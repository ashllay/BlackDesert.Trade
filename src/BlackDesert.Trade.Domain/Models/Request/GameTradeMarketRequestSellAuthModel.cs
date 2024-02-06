namespace BlackDesert.Trade.Domain.Models.Api;

public class GameTradeMarketRequestSellAuthModel
{
  public GameTradeMarketRequestSellAuthModel() {
    userNo = 0L;
    certifiedKey = string.Empty;
    sellKeyType = 0;
    sellMainKey = 0;
    sellSubKey = 0;
    sellPrice = 0L;
    sellCount = 0L;
    sellChooseKey = 0;
    isSealed = "FALSE";
    isRingBuff = "FALSE";
    otp = string.Empty;
    retryBiddingNo = 0L;
    ticketNo = string.Empty;
  }

  public long userNo { set; get; }

  public string certifiedKey { set; get; }

  public int sellKeyType { set; get; }

  public int sellMainKey { set; get; }

  public int sellSubKey { set; get; }

  public long sellPrice { set; get; }

  public long sellCount { set; get; }

  public int sellChooseKey { set; get; }

  public string isSealed { set; get; }
  public string isRingBuff { set; get; }

  public string otp { set; get; }

  public long retryBiddingNo { set; get; }

  public string ticketNo { set; get; }
}