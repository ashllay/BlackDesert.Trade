using System.Xml.Serialization;

namespace BlackDesert.Trade.Domain.Models.Xml.Sub;

public class XmlMarketCategoryTickCount
{
  [XmlAttribute("MainGroupNo")]
  public int MainGroupNo { get; set; }

  [XmlAttribute("NeedTickForUpdate")]
  public int NeedTickForUpdate { get; set; }
}