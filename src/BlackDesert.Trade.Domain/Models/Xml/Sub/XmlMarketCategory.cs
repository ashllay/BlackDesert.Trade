using System.Xml.Serialization;

namespace BlackDesert.Trade.Domain.Models.Xml.Sub;

public class XmlMarketCategory
{
  [XmlAttribute("MainCategoryNo")]
  public int MainCategoryNo { get; set; }

  [XmlAttribute("SubCategoryNo")]
  public int SubCategoryNo { get; set; }
}