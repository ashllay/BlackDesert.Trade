using System.Xml.Serialization;
using BlackDesert.Trade.Domain.Abstract;
using BlackDesert.Trade.Domain.Models.Xml.Sub;

namespace BlackDesert.Trade.Domain.Models.Xml;

[XmlRoot("XmlMarketCategoryList")]
public class XmlMarketCategoryList : IXmlFile
{
  [XmlElement("XmlMarketCategory")]
  public List<XmlMarketCategory> Categories { get; set; }
}