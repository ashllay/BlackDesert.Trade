﻿namespace BlackDesert.Trade.Domain.Models.Process;

public class ProcessTradeMarketIncludePayloadModel
{
  public ProcessTradeMarketIncludePayloadModel() {
    nationCode = 0;
    serverNo = 0;
    userNo = 0L;
    keyType = 0;
    mainKey = 0;
    subKey = 0;
    param0 = 0L;
    param1 = 0L;
    param2 = 0L;
    param3 = 0L;
    param4 = 0L;
    count = 0L;
    isSealed = false;
    payload = 0L;
    result = new CommonResult();
    isRestoration = false;
  }

  public int nationCode { get; set; }

  public int serverNo { get; set; }

  public long userNo { get; set; }

  public int keyType { get; set; }

  public int mainKey { set; get; }

  public int subKey { set; get; }

  public long param0 { set; get; }

  public long param1 { set; get; }

  public long param2 { set; get; }

  public long param3 { set; get; }

  public long param4 { set; get; }

  public long count { set; get; }

  public bool isSealed { set; get; }

  public long payload { set; get; }

  public bool isRestoration { set; get; }

  public CommonResult result { set; get; }
}