using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using BlackDesert.Trade.Domain.Abstract;

namespace BlackDesert.Trade.Domain.Models.Xml;

[XmlRoot("XmlMarketOption")]
public class XmlMarketOption : IXmlFile
{
  [XmlElement("Weight")]
  [Range(1, 214_748, ErrorMessage = nameof(Weight) + " must be greater than 0")]
  public long Weight { get; set; }

  [XmlElement("WeightRate")]
  [Range(1, long.MaxValue, ErrorMessage = nameof(WeightRate) + " must be greater than 0")]
  public int WeightRate { get; set; }

  [XmlElement("BiddingPercent")]
  [Range(1, long.MaxValue, ErrorMessage = nameof(BiddingPercent) + " must be greater than 0")]
  public int BiddingPercent { get; set; }

  [XmlElement("CashGroupNo")]
  [Range(1, long.MaxValue, ErrorMessage = nameof(CashGroupNo) + " must be greater than 0")]
  public int CashGroupNo { get; set; }

  [XmlElement("BuyPercent")]
  [Range(1, long.MaxValue, ErrorMessage = nameof(BuyPercent) + " must be greater than 0")]
  public int BuyPercent { get; set; }

  // [XmlElement("StockPercent")]
  // [Range(1, long.MaxValue, ErrorMessage = nameof(StockPercent) + " must be greater than 0")]
  // public int StockPercent { get; set; }

  [XmlElement("PearlItemLimitedMaxCount")]
  [Range(1, long.MaxValue, ErrorMessage = nameof(PearlItemLimitedMaxCount) + " must be greater than 0")]
  public int PearlItemLimitedMaxCount { get; set; }

  [XmlElement("StartSleepHour")]
  [Range(1, long.MaxValue, ErrorMessage = nameof(StartSleepHour) + " must be greater than 0")]
  public int StartSleepHour { get; set; }

  [XmlElement("EndSleepHour")]
  [Range(1, long.MaxValue, ErrorMessage = nameof(EndSleepHour) + " must be greater than 0")]
  public int EndSleepHour { get; set; }

  [XmlElement("IncreasefamilyPointWeightRate")]
  [Range(0, long.MaxValue, ErrorMessage = nameof(IncreaseFamilyPointWeightRate) + " must be greater than 0")]
  public int IncreaseFamilyPointWeightRate { get; set; }

  [XmlElement("IncreaseMaxWeight")]
  [Range(1, long.MaxValue, ErrorMessage = nameof(IncreaseMaxWeight) + " must be greater than 0")]
  public int IncreaseMaxWeight { get; set; }

  [XmlElement("IncreaseWeightByBuff")]
  [Range(1, long.MaxValue, ErrorMessage = nameof(IncreaseWeightByBuff) + " must be greater than 0")]
  public int IncreaseWeightByBuff { get; set; }

  [XmlElement("RingBuffRate")]
  [Range(1, long.MaxValue, ErrorMessage = nameof(RingBuffRate) + " must be greater than 0")]
  public int RingBuffRate { get; set; }
}