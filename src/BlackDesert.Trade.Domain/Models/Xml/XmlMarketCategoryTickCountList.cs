using System.Xml.Serialization;
using BlackDesert.Trade.Domain.Abstract;
using BlackDesert.Trade.Domain.Models.Xml.Sub;

namespace BlackDesert.Trade.Domain.Models.Xml;

[XmlRoot("XmlMarketCategoryTickCountList")]
public class XmlMarketCategoryTickCountList : IXmlFile
{
  [XmlElement("XmlMarketCategoryTickCount")]
  public List<XmlMarketCategoryTickCount> TickCounts { get; set; }
}