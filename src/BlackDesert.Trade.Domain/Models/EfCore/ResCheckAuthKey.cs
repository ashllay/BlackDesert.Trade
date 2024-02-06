namespace BlackDesert.Trade.Domain.Models.EfCore;

public class ResCheckAuthKey
{
  /// <summary>
  ///   AKA: Nation Code
  /// </summary>
  public int ServiceType { get; set; }
  public int WorldNo { get; set; }
  public string UserNickname { get; set; }
}