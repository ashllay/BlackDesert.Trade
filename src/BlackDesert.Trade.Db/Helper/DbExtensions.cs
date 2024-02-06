using System.Data;
using Microsoft.Data.SqlClient;
using Serilog;

namespace BlackDesert.Trade.Domain.DB.Helper;

public static class DbExtensions
{
  public static string GetSymNo(this SqlCommand cmd) {
    return cmd.GetParamValue("symNo");
  }

  public static int GetRv(this SqlCommand cmd) {
    return cmd.GetParamValue("rv", 1);
    // return (int?)cmd.Parameters["@rv"]?.Value ?? throw new Exception("Rv is null");
  }

  public static T GetParamValue<T>(this SqlCommand cmd,
                                   string paramName,
                                   T defaultValue = default) where T : struct {
    if (cmd.Connection.State != ConnectionState.Closed)
      cmd.Connection.Close();
    // throw new Exception("Connection must be closed before accessing Parameters");
    if (string.IsNullOrEmpty(paramName))
      throw new Exception("paramName is null or empty Type: " + typeof(T).Name);
    try {
      if (paramName.StartsWith("@"))
        paramName = paramName.Substring(1);
      var val = (T)cmd?.Parameters["@" + paramName]?.Value;
      return val;
    }
    catch (Exception) {
      return defaultValue;
    }
  }

  public static string GetParamValue(this SqlCommand cmd,
                                     string paramName,
                                     string defaultValue = "") {
    if (cmd.Connection.State != ConnectionState.Closed)
      cmd.Connection.Close();
    // throw new Exception("Connection must be closed before accessing Parameters");
    if (string.IsNullOrEmpty(paramName))
      throw new Exception("paramName is null or empty Type: " + typeof(string).Name);
    try {
      if (paramName.StartsWith("@"))
        paramName = paramName.Substring(1);
      var val = (string)cmd?.Parameters["@" + paramName]?.Value;
      return val;
    }
    catch (Exception) {
      return defaultValue;
    }
  }


  public static T? GetParamValueNullable<T>(this SqlCommand cmd,
                                            string paramName,
                                            T? defaultValue = null) where T : struct {
    if (cmd.Connection.State != ConnectionState.Closed)
      cmd.Connection.Close();
    // throw new Exception("Connection must be closed before accessing Parameters");
    if (string.IsNullOrEmpty(paramName))
      throw new Exception("paramName is null or empty Type: " + typeof(T).Name);
    try {
      if (paramName.StartsWith("@"))
        paramName = paramName.Substring(1);
      var val = cmd.Parameters["@" + paramName].Value as T?;
      return val ?? defaultValue;
    }
    catch (Exception) {
      return defaultValue;
    }
  }

  public static List<T> ReadAsList<T>(this SqlDataReader reader) {
    var list = new List<T>();
    var type = typeof(T);
    var props = type.GetProperties();
    while (reader.Read()) {
      var obj = Activator.CreateInstance<T>();
      foreach (var prop in props) {
        var dbNameAttribute = prop.GetCustomAttributes(typeof(DbNameAttribute), false).FirstOrDefault() as DbNameAttribute;
        var name = prop.Name;
        if (dbNameAttribute is not null) name = dbNameAttribute.Name;

        try {
          var val = reader[name];
          if (val is DBNull)
            val = null;
          prop.SetValue(obj, val);
        }
        catch (Exception ex) {
          Log.Fatal(ex, "DbExtensions.ReadAsList<T> PropReadFail {TypeName} {PropertyName}", type.Name, prop.Name);
        }
      }

      list.Add(obj);
    }

    return list;
  }

  public static T ReadAsSingleObject<T>(this SqlDataReader reader) {
    var type = typeof(T);
    var props = type.GetProperties();
    if (reader.Read()) {
      var obj = Activator.CreateInstance<T>();
      foreach (var prop in props) {
        var dbNameAttribute = prop.GetCustomAttributes(typeof(DbNameAttribute), false).FirstOrDefault() as DbNameAttribute;
        var name = prop.Name;
        if (dbNameAttribute is not null) name = dbNameAttribute.Name;

        try {
          var val = reader[name];
          if (val is DBNull)
            val = null;
          prop.SetValue(obj, val);
        }
        catch (Exception ex) {
          Log.Fatal(ex, "DbExtensions.ReadAsSingleObject<T> PropReadFail {TypeName} {PropertyName}", type.Name, prop.Name);
        }
      }

      return obj;
    }

    return default;
  }

  public static T ReadSingle<T>(this SqlDataReader reader) where T : struct {
    if (reader.Read()) {
      var val = reader[0];
      if (val is DBNull)
        val = null;
      return (T)val;
    }

    return default;
  }

  public static List<DbOutParamValues> ExecuteSpNonQuery(this SqlConnection conn,
                                                         string spName,
                                                         DbInParam[] inParams,
                                                         DbOutParam[] outParams) {
    if (conn.State != ConnectionState.Open)
      return new List<DbOutParamValues>();
    var cmd = conn.CreateCommand();
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = spName;
    cmd.Parameters.Clear();
    if (inParams is not null)
      foreach (var param in inParams) {
        var p = cmd.Parameters.Add(param.Name, param.DbType);
        p.Value = param.Value ?? DBNull.Value;
      }

    if (outParams is not null)
      foreach (var param in outParams) {
        var p = cmd.Parameters.Add(param.Name, param.DbType);
        p.Direction = ParameterDirection.Output;
      }

    _ = cmd.ExecuteNonQuery();
    conn.Close();
    var outParam = new List<DbOutParamValues>();
    if (outParams is not null)
      foreach (var param in outParams) {
        var p = cmd.Parameters["@" + param.Name];
        if (p is null) continue;
        var val = p.Value;
        if (val is DBNull)
          val = null;
        outParam.Add(new DbOutParamValues(param.Name, val));
      }

    return outParam;
  }
}