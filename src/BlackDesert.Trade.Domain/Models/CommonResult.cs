using BlackDesert.Trade.Domain.Enum;

namespace BlackDesert.Trade.Domain.Models;

public class CommonResult
{
  public CommonResult() {
    resultCode = 0;
    resultMsg = string.Empty;
  }

  public CommonResult(int rv,
                      string sym) {
    resultCode = rv;
    resultMsg = sym;
  }

  public int resultCode { get; set; }

  public string resultMsg { get; set; }

  public static CommonResult Unauthorized(int rv) {
    return new CommonResult(rv, MarketError.TRADE_MARKET_ERROR_MSG_UNAUTHORIZED.GetResourceValue());
  }

  public static CommonResult Exception(int rv) {
    return new CommonResult(rv, MarketError.TRADE_MARKET_ERROR_MSG_EXCEPTION.GetResourceValue());
  }

  public static CommonResult Success() {
    return new CommonResult(0, "");
  }

  public static CommonResult Success(string resultMsg) {
    return new CommonResult(0, resultMsg);
  }

  public static CommonResult DbException(int rv) {
    return new CommonResult(rv, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
  }

  public static CommonResult Error(int resultCode,
                                   string resultMsg) {
    return new CommonResult(resultCode, resultMsg);
  }
}

public class CommonResultData<T>
{
  public CommonResultData() {
    commonResult = new CommonResult();
    data = default;
  }

  public CommonResult commonResult { get; set; }
  public T? data { get; set; }

  //Operator from CommonResult
  public static implicit operator CommonResultData<T>(CommonResult commonResult) {
    return new CommonResultData<T> {
      commonResult = commonResult
    };
  }

  //T to COMMONRESULTDATA<T>
  public static implicit operator CommonResultData<T>(T data) {
    if (data is null) throw new ArgumentException("CommonResultData.Data can not be null");
    return new CommonResultData<T> {
      commonResult = new CommonResult {
        resultCode = 0,
        resultMsg = ""
      },
      data = data
    };
  }
}