using System.Data;
using Microsoft.Data.SqlClient;

namespace BlackDesert.Trade.Domain.DB.Helper;

public static class DbConst
{
  public static object DbNull => DBNull.Value;

  public static SqlParameter SymNo() {
    return new SqlParameter("@symNo", SqlDbType.NVarChar, 50) {
      Direction = ParameterDirection.Output
    };
  }

  public static SqlParameter Rv() {
    return new SqlParameter("@rv", SqlDbType.Int) {
      Direction = ParameterDirection.Output
    };
  }
}