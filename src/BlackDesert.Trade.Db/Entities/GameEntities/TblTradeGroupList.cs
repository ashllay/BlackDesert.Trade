using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("OwnerUserNo", "TradeGroupIndex")]
[Table("TblTradeGroupList", Schema = "PaGamePrivate")]
public class TblTradeGroupList
{
  [Key]
  [Column("_ownerUserNo")]
  public long OwnerUserNo { get; set; }

  [Key]
  [Column("_tradeGroupIndex")]
  public short TradeGroupIndex { get; set; }

  [Column("_workerNo1")]
  public long WorkerNo1 { get; set; }

  [Column("_workerNo2")]
  public long WorkerNo2 { get; set; }

  [Column("_money")]
  public long Money { get; set; }

  [Column("_carriage")]
  public int Carriage { get; set; }

  [Column("_amulet")]
  public int Amulet { get; set; }

  [Column("_porter")]
  public int Porter { get; set; }

  [Column("_guard")]
  public int Guard { get; set; }

  [Column("_state")]
  public byte State { get; set; }

  [Column("_moveSpeed")]
  public int MoveSpeed { get; set; }

  [Column("_luck")]
  public double Luck { get; set; }

  [Column("_defense")]
  public double Defense { get; set; }

  [Column("_transportCapacity")]
  public double TransportCapacity { get; set; }

  [Column("_curDestIndex")]
  public short CurDestIndex { get; set; }

  [Column("_moveDistance")]
  public double MoveDistance { get; set; }

  [Column("_itemKey1")]
  public int? ItemKey1 { get; set; }

  [Column("_itemCount1")]
  public int ItemCount1 { get; set; }

  [Column("_buyPrice1")]
  public int BuyPrice1 { get; set; }

  [Column("_contractedPrice1")]
  public int ContractedPrice1 { get; set; }

  [Column("_itemKey2")]
  public int? ItemKey2 { get; set; }

  [Column("_itemCount2")]
  public int ItemCount2 { get; set; }

  [Column("_buyPrice2")]
  public int BuyPrice2 { get; set; }

  [Column("_contractedPrice2")]
  public int ContractedPrice2 { get; set; }

  [Column("_itemKey3")]
  public int? ItemKey3 { get; set; }

  [Column("_itemCount3")]
  public int ItemCount3 { get; set; }

  [Column("_buyPrice3")]
  public int BuyPrice3 { get; set; }

  [Column("_contractedPrice3")]
  public int ContractedPrice3 { get; set; }

  [Column("_itemKey4")]
  public int? ItemKey4 { get; set; }

  [Column("_itemCount4")]
  public int ItemCount4 { get; set; }

  [Column("_buyPrice4")]
  public int BuyPrice4 { get; set; }

  [Column("_contractedPrice4")]
  public int ContractedPrice4 { get; set; }

  [Column("_itemKey5")]
  public int? ItemKey5 { get; set; }

  [Column("_itemCount5")]
  public int ItemCount5 { get; set; }

  [Column("_buyPrice5")]
  public int BuyPrice5 { get; set; }

  [Column("_contractedPrice5")]
  public int ContractedPrice5 { get; set; }

  [Column("_itemKey6")]
  public int? ItemKey6 { get; set; }

  [Column("_itemCount6")]
  public int ItemCount6 { get; set; }

  [Column("_buyPrice6")]
  public int BuyPrice6 { get; set; }

  [Column("_contractedPrice6")]
  public int ContractedPrice6 { get; set; }

  [Column("_itemKey7")]
  public int? ItemKey7 { get; set; }

  [Column("_itemCount7")]
  public int ItemCount7 { get; set; }

  [Column("_buyPrice7")]
  public int BuyPrice7 { get; set; }

  [Column("_contractedPrice7")]
  public int ContractedPrice7 { get; set; }

  [Column("_itemKey8")]
  public int? ItemKey8 { get; set; }

  [Column("_itemCount8")]
  public int ItemCount8 { get; set; }

  [Column("_buyPrice8")]
  public int BuyPrice8 { get; set; }

  [Column("_contractedPrice8")]
  public int ContractedPrice8 { get; set; }

  [Column("_itemKey9")]
  public int? ItemKey9 { get; set; }

  [Column("_itemCount9")]
  public int ItemCount9 { get; set; }

  [Column("_buyPrice9")]
  public int BuyPrice9 { get; set; }

  [Column("_contractedPrice9")]
  public int ContractedPrice9 { get; set; }

  [Column("_itemKey10")]
  public int? ItemKey10 { get; set; }

  [Column("_itemCount10")]
  public int ItemCount10 { get; set; }

  [Column("_buyPrice10")]
  public int BuyPrice10 { get; set; }

  [Column("_contractedPrice10")]
  public int ContractedPrice10 { get; set; }

  [Column("_tradeNode1")]
  public int? TradeNode1 { get; set; }

  [Column("_tradeNode2")]
  public int? TradeNode2 { get; set; }

  [Column("_tradeNode3")]
  public int? TradeNode3 { get; set; }

  [Column("_tradeNode4")]
  public int? TradeNode4 { get; set; }

  [Column("_tradeNode5")]
  public int? TradeNode5 { get; set; }

  [Column("_tradeNode6")]
  public int? TradeNode6 { get; set; }

  [Column("_tradeNode7")]
  public int? TradeNode7 { get; set; }

  [Column("_tradeNode8")]
  public int? TradeNode8 { get; set; }

  [Column("_tradeNode9")]
  public int? TradeNode9 { get; set; }

  [Column("_tradeNode10")]
  public int? TradeNode10 { get; set; }
}