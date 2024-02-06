namespace BlackDesert.Trade.Domain.Models.Api;

public class ViewRequestGetMyWallet
{
  public long userNo { get; set; }
  public string certifiedKey { get; set; }
  public int keyType { get; set; }
  public int mainKey { get; set; }
  public int subKey { get; set; }
  public bool isSealed { get; set; }
}