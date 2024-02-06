using System.Data;
using Microsoft.Data.SqlClient;

namespace BlackDesert.Trade.Domain.DB.Abstract;

public abstract class BaseDbManager : IBaseDbManager
{
  protected readonly string ConnectionString;

  public BaseDbManager(string connectionString) {
    ConnectionString = connectionString;
  }

  public virtual bool CanConnect() {
    try {
      using var connection = new SqlConnection(ConnectionString);
      connection.Open();
      return true;
    }
    catch (Exception) {
      return false;
    }
  }

  protected SqlConnection OpenConnection() {
    var connection = new SqlConnection(ConnectionString);
    connection.Open();
    return connection;
  }

  protected SqlCommand CreateSpCommand(SqlConnection connection,
                                       string spName) {
    var command = new SqlCommand(spName, connection) {
      CommandType = CommandType.StoredProcedure
    };
    return command;
  }

  protected SqlCommand CreateSpCommand(SqlConnection connection,
                                       string spName,
                                       IEnumerable<SqlParameter> parameters) {
    var command = new SqlCommand(spName, connection) {
      CommandType = CommandType.StoredProcedure
    };
    if (parameters is not null)
      foreach (var param in parameters)
        command.Parameters.Add(param);
    return command;
  }
}