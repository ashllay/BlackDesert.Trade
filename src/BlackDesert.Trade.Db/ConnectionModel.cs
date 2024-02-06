namespace BlackDesert.Trade.Db;

public class ConnectionModel
{
  public string World { get; set; }
  public string Game { get; set; }
  public string Log { get; set; }
  public string Trade { get; set; }

  public List<string> All => new() { World, Game, Log, Trade }; 
}