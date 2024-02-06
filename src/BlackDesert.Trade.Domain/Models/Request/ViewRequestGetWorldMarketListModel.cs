using System.ComponentModel.DataAnnotations;

namespace BlackDesert.Trade.Domain.Models.Api;

public class ViewRequestGetWorldMarketListModel
{
  public ViewRequestGetWorldMarketListModel() {
    // keyType = 2;
    mainCategory = 0;
    subCategory = 0;
  }

  // public int keyType { get; set; }

  public int mainCategory { get; set; }
  public int subCategory { get; set; }
}