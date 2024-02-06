namespace BlackDesert.Trade.Domain.Models.Process;

public class ProcessTradeMarketBuyInfo
{
  public ProcessTradeMarketBuyInfo() {
    nationCode = 0;
    worldNo = 0;
    userNo = 0L;
    buyKeyType = 0;
    buyMainKey = 0;
    buySubKey = 0;
    buyPrice = 0L;
    buyCount = 0L;
    buyChooseKey = 0;
    isWebAccess = false;
    otp = string.Empty;
    retryBiddingNo = 0L;
  }

  public int nationCode { set; get; }

  public int worldNo { set; get; }

  public long userNo { set; get; }

  public int buyKeyType { set; get; }

  public int buyMainKey { set; get; }

  public int buySubKey { set; get; }

  public long buyPrice { set; get; }

  public long buyCount { set; get; }

  public int buyChooseKey { set; get; }

  public bool isWebAccess { set; get; }

  public string otp { set; get; }

  public long retryBiddingNo { set; get; }
}