using System.Runtime.Serialization;
using BlackDesert.Trade.Domain.Enum;

namespace BlackDesert.Trade.Domain.Models.EfCore;

public class DbResult
{
  internal DbResult() {

  }

  public string SymNo { get; init; } = "";
  public int Rv { get; init; } = 0;

  [IgnoreDataMember]
  [JsonIgnore]
  public bool Status => Rv == 0;

  public static DbResult Success(
    string symNo = "") {
    return new DbResult() {
      SymNo = symNo
    };
  }

  public static DbResult Error(int rv,
                               string symNo) {
    return new DbResult() {
      Rv = rv,
      SymNo = symNo
    };
  }

  public static DbResult Error(int rv,
                               GameErrorType symNo) {
    return new DbResult() {
      Rv = rv,
      SymNo = symNo.ToString()
    };
  }  
  
  public static DbResult Error(int rv,
                               MarketError symNo) {
    return new DbResult() {
      Rv = rv,
      SymNo = symNo.GetResourceValue()
    };
  }

  public static DbResult DbException(int rv) {
    return new DbResult() {
      Rv = rv,
      SymNo = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue()
    };
  }
  
  public CommonResult ToCommonResult() {
    return new CommonResult {
      resultCode = Rv,
      resultMsg = SymNo
    };
  }
}

public readonly struct DbResult<T>
{
  private DbResult(T data,
                   int rv = 0,
                   string symNo = "") {
    if (data is null) throw new ArgumentException("EfCore.Data can not be null");
    Data = data;
  }

  private DbResult(int rv,
                   string symNo) {
    Rv = rv;
    SymNo = symNo;
  }

  public string SymNo { get; init; } = "";
  public int Rv { get; init; } = 0;
  public T? Data { get; init; } = default;

  [IgnoreDataMember]
  [JsonIgnore]
  public bool Status => Rv == 0 || Data is not null; //TODO CHECK

  public static DbResult<T> Success<T>(T data,
                                       int rv = 0,
                                       string symNo = "") {
    return new DbResult<T>(data, rv, symNo);
  }

  public static DbResult<T> Error(int rv,
                                  string symNo) {
    return new DbResult<T>(rv, symNo);
  }

  public static DbResult<T> Error(int rv,
                                  GameErrorType symNo) {
    return new DbResult<T>(rv, symNo.ToString());
  }

  //Add operator conversion to EfCore<T> from T
  public static implicit operator DbResult<T>(T data) {
    return new DbResult<T>(data);
  }

  public CommonResult ToCommonResult() {
    return new CommonResult {
      resultCode = Rv,
      resultMsg = SymNo
    };
  }
}