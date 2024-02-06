using System.Xml.Serialization;

namespace BlackDesert.Trade.Domain.Models.Xml.Sub;

public class XmlMarketVariedTradeCount
{
  [XmlAttribute("MinFamilyPoint")]
  public long MinFamilyPoint { get; set; }

  [XmlAttribute("MaxFamilyPoint")]
  public long MaxFamilyPoint { get; set; }

  [XmlAttribute("AddTradeCount")]
  public int AddTradeCount { get; set; }
}