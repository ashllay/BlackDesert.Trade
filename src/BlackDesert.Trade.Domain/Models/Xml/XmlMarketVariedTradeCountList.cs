using System.Xml.Serialization;
using BlackDesert.Trade.Domain.Abstract;
using BlackDesert.Trade.Domain.Models.Xml.Sub;

namespace BlackDesert.Trade.Domain.Models.Xml;

[XmlRoot("XmlMarketVariedTradeCountList")]
public class XmlMarketVariedTradeCountList : IXmlFile
{
  [XmlElement("XmlMarketVariedTradeCount")]
  public List<XmlMarketVariedTradeCount> VariedTradeCountList { get; set; }
}