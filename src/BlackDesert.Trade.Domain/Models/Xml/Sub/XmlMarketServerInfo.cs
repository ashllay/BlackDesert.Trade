using System.Xml.Serialization;

namespace BlackDesert.Trade.Domain.Models.Xml.Sub;

public class XmlMarketServerInfo
{
  [XmlAttribute("Ip")]
  public string Ip { get; set; }

  [XmlAttribute("AllowMainGroupNo")]
  public string AllowMainGroupNo { get; set; }
}