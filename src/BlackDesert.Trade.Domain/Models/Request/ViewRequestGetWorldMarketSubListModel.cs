namespace BlackDesert.Trade.Domain.Models.Api;

public class ViewRequestGetWorldMarketSubListModel
{
  public ViewRequestGetWorldMarketSubListModel() {
    keyType = 2;
    mainKey = 0;
  }

  public int keyType { get; set; }

  public int mainKey { get; set; }
}