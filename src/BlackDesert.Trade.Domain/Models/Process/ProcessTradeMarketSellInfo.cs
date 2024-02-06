namespace BlackDesert.Trade.Domain.Models.Process;

public class ProcessTradeMarketSellInfo
{
  public ProcessTradeMarketSellInfo() {
    nationCode = 0;
    worldNo = 0;
    userNo = 0L;
    sellKeyType = 0;
    sellMainKey = 0;
    sellSubKey = 0;
    sellPrice = 0L;
    sellCount = 0L;
    sellChooseKey = 0;
    isSealed = false;
    isWebAccess = false;
    isRingBuff = false;
    otp = string.Empty;
    retryBiddingNo = 0L;
  }

  public int nationCode { set; get; }

  public int worldNo { set; get; }

  public long userNo { set; get; }

  public int sellKeyType { set; get; }

  public int sellMainKey { set; get; }

  public int sellSubKey { set; get; }

  public long sellPrice { set; get; }

  public long sellCount { set; get; }

  public int sellChooseKey { set; get; }

  public bool isSealed { set; get; }

  public bool isWebAccess { set; get; }

  public bool isRingBuff { set; get; }

  public long retryBiddingNo { set; get; }

  public string otp { set; get; }
}