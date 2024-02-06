namespace BlackDesert.Trade.Domain.Models.Process;

public class ProcessTradeMarketBiddingInfo
{
  public ProcessTradeMarketBiddingInfo() {
    keyType = 0;
    mainKey = 0;
    subKey = 0;
    isSealed = false;
    count = 0L;
    nationCode = 0;
    serverNo = 0;
    userNo = 0L;
    isWebAccess = false;
  }

  public long biddingNo { set; get; }

  public int keyType { set; get; }

  public int mainKey { set; get; }

  public int subKey { set; get; }

  public bool isSealed { set; get; }

  public long count { set; get; }

  public int nationCode { set; get; }

  public int serverNo { set; get; }

  public long userNo { set; get; }

  public bool isWebAccess { set; get; }
}