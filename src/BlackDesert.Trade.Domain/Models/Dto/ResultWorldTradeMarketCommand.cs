namespace BlackDesert.Trade.Domain.Models.Db;

public class ResultWorldTradeMarketCommand
{
  public long? _commandNo { get; set; }

  public DateTime? _registerDate { get; set; }
  public string _commandString { get; set; }

  public byte? _status { get; set; }
}