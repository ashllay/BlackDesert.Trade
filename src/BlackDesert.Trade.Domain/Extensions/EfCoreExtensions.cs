namespace BlackDesert.Trade.Domain.Extensions;

public static class EfCoreExtensions
{
  // public static int TruncateTable<T>(this DbContext context) where T : class {
  //   var entity = context.Model.FindEntityType(typeof(T));
  //   var tableName = entity.GetTableName();
  //   var schemaName = entity.GetSchema();
  //   if (tableName is null) throw new Exception("Table name cannot be null");
  //   var sb = new StringBuilder();
  //   if (!string.IsNullOrEmpty(schemaName)) sb.Append($"[{schemaName}].");
  //   sb.Append($"[{tableName}]");
  //   var fullTableName = sb.ToString();
  //   return context.Database.ExecuteSqlInterpolated($"TRUNCATE TABLE {fullTableName}");
  // }

  // public static void TruncateTable<T>(this DbSet<T> dbSet) where T : class {
  //   var tableName = dbSet.EntityType.GetTableName();
  //   var schemaName = dbSet.EntityType.GetSchema();
  //   if (tableName is null) throw new Exception("Table name cannot be null");
  //   var sb = new StringBuilder();
  //   if (!string.IsNullOrEmpty(schemaName)) sb.Append($"[{schemaName}].");
  //   sb.Append($"[{tableName}]");
  //   var fullTableName = sb.ToString();
  //   dbSet.FromSqlInterpolated($"TRUNCATE TABLE {fullTableName}").ToList();
  // }
}