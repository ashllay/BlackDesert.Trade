using System.Text.Json.Serialization;

namespace BlackDesert.Trade.Domain.Models.Api;

public class GameTradeMarketRequestAuthPayload
{
  public GameTradeMarketRequestAuthPayload() {
    userNo = 0L;
    certifiedKey = string.Empty;
    payload = 0L;
    keyType = 0;
    mainKey = 0;
    subKey = 0;
    param0 = 0L;
    param1 = 0L;
    param2 = 0L;
    param3 = 0L;
    param4 = 0L;
    count = 0L;
    isSealed = "FALSE";
    isRestoration = "FALSE";
  }

  public long userNo { set; get; }

  public string certifiedKey { set; get; }

  public long payload { set; get; }

  public int keyType { get; set; }

  public int mainKey { set; get; }

  public int subKey { set; get; }

  public long param0 { set; get; }

  public long param1 { set; get; }

  public long param2 { set; get; }

  public long param3 { set; get; }

  public long param4 { set; get; }

    
  public long count { set; get; }

  public string isSealed { set; get; }

  public string isRestoration { set; get; }
}