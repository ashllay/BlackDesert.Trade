using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblAcoinChargeNumbersByWeb", Schema = "PaGamePrivate")]
public class TblAcoinChargeNumbersByWeb
{
  [Column("_worldNo")]
  public short WorldNo { get; set; }

  [Key]
  [Column("_itemNo")]
  public long ItemNo { get; set; }

  [Column("_chargeNo")]
  [StringLength(50)]
  [Unicode(false)]
  public string? ChargeNo { get; set; }

  [Column("_chargeType")]
  public byte ChargeType { get; set; }

  [Column("_itemKey")]
  public int ItemKey { get; set; }

  [Column("_mailNo")]
  public long? MailNo { get; set; }

  [Column("_isCanceled")]
  public bool IsCanceled { get; set; }

  [Column("_regDate", TypeName = "datetime")]
  public DateTime RegDate { get; set; }

  [Column("_updDate", TypeName = "datetime")]
  public DateTime? UpdDate { get; set; }
}