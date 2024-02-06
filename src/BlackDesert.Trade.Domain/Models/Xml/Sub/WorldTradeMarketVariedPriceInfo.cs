using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace BlackDesert.Trade.Domain.Models.Xml.Sub;

public class XmlMarketVariedPriceInfo
{
  [XmlAttribute("StartRangePrice")]
  [Range(1, long.MaxValue, ErrorMessage = "StartRangePrice must be higher than 0")]
  public long StartRangePrice { get; set; }

  [XmlAttribute("EndRangePrice")]
  [Range(1, long.MaxValue, ErrorMessage = "EndRangePrice must be higher than 0")]
  public long EndRangePrice {
    get {
      if (_endRangePrice == 0L)
        return long.MaxValue;
      return _endRangePrice;
    }
    set {
      if (value == 0L) {
        _endRangePrice = long.MaxValue;
      }
      else {
        _endRangePrice = value;
      }
    }
  }

  private long _endRangePrice = 0;

  [XmlAttribute("UnitPrice")]
  [Range(1, long.MaxValue, ErrorMessage = "UnitPrice must be higher than 0")]
  public long UnitPrice { get; set; }

  [XmlAttribute("PassBiddingCount")]
  [Range(1, long.MaxValue, ErrorMessage = "PassBiddingCount must be higher than 0")]
  public long PassBiddingCount { get; set; }

  [XmlAttribute("PricePoint")]
  [Range(1, long.MaxValue, ErrorMessage = "PassBiddingCount must be higher than 0")]
  public long PricePoint { get; set; }
}