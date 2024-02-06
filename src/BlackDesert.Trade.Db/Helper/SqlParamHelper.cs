using Microsoft.Data.SqlClient;

namespace BlackDesert.Trade.Domain.DB.Helper;

public static class SqlParamHelper
{
  public static SqlParameter CreateSqlParameter<T>(this T? value,
                                                   string parameterName) where T : struct {
    return value.HasValue
             ? new SqlParameter(parameterName, value)
             : new SqlParameter(parameterName, DBNull.Value);
  }

  public static SqlParameter CreateSqlParameter(this string value,
                                                string parameterName) {
    return string.IsNullOrEmpty(value)
             ? new SqlParameter(parameterName, DBNull.Value)
             : new SqlParameter(parameterName, value);
  }
}