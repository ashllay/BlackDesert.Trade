using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblAlchemyRecordNoOverlap", Schema = "PaGamePrivate")]
public class TblAlchemyRecordNoOverlap
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_type")]
  public byte Type { get; set; }

  [Column("_mentalCardKey")]
  public int MentalCardKey { get; set; }

  [Column("_resultItemKey")]
  public int ResultItemKey { get; set; }

  [Column("_itemKey0")]
  public int? ItemKey0 { get; set; }

  [Column("_itemCount0")]
  public long? ItemCount0 { get; set; }

  [Column("_itemKey1")]
  public int? ItemKey1 { get; set; }

  [Column("_itemCount1")]
  public long? ItemCount1 { get; set; }

  [Column("_itemKey2")]
  public int? ItemKey2 { get; set; }

  [Column("_itemCount2")]
  public long? ItemCount2 { get; set; }

  [Column("_itemKey3")]
  public int? ItemKey3 { get; set; }

  [Column("_itemCount3")]
  public long? ItemCount3 { get; set; }

  [Column("_itemKey4")]
  public int? ItemKey4 { get; set; }

  [Column("_itemCount4")]
  public long? ItemCount4 { get; set; }

  [Column("_itemKey5")]
  public int? ItemKey5 { get; set; }

  [Column("_itemCount5")]
  public long? ItemCount5 { get; set; }

  [Column("_itemKey6")]
  public int? ItemKey6 { get; set; }

  [Column("_itemCount6")]
  public long? ItemCount6 { get; set; }

  [Column("_itemKey7")]
  public int? ItemKey7 { get; set; }

  [Column("_itemCount7")]
  public long? ItemCount7 { get; set; }
}