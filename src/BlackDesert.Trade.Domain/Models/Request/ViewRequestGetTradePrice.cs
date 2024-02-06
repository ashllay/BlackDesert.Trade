using System.Text.Json.Serialization;

namespace BlackDesert.Trade.Domain.Models.Api;

public class ViewRequestGetTradePrice
{
  [JsonPropertyName("keyType")]
  public int KeyType { get; set; }

  [JsonPropertyName("mainKey")]
  public int MainKey { get; set; }

  [JsonPropertyName("subKey")]
  public int SubKey { get; set; }
}