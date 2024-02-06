using System.Data;

namespace BlackDesert.Trade.Domain.DB.Helper;

public readonly struct DbOutParam
{
  public DbOutParam(string name,
                    SqlDbType dbType) {
    Name = name;
    DbType = dbType;
  }

  public string Name { get; init; }
  public SqlDbType DbType { get; init; }
}

public readonly struct DbInParam
{
  public DbInParam(string name,
                   object? value,
                   SqlDbType dbType) {
    Name = name;
    Value = value;
    DbType = dbType;
  }

  public string Name { get; init; }
  public object? Value { get; init; }
  public SqlDbType DbType { get; init; }
}

public readonly struct DbOutParamValues
{
  public string Name { get; init; }
  public object? Value { get; init; }

  public DbOutParamValues(string name,
                          object? value) {
    Name = name;
    Value = value;
  }

  public T? GetValueAs<T>() {
    return (T?)Value;
  }
}