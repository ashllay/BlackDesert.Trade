namespace BlackDesert.Trade.Domain.DB.Helper;

public class DbNameAttribute : Attribute
{
  public DbNameAttribute(string name) {
    Name = name;
  }

  public string Name { get; }
}