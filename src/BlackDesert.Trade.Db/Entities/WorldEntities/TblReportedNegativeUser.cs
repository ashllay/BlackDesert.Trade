using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Keyless]
[Table("TblReportedNegativeUser", Schema = "PaGamePrivate")]
public class TblReportedNegativeUser
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_type")]
  public byte Type { get; set; }

  [Column("_serverNo")]
  public short ServerNo { get; set; }

  [Column("_ownerUserNo")]
  public long OwnerUserNo { get; set; }

  [Column("_ownerUserCharacterNo")]
  public long OwnerUserCharacterNo { get; set; }

  [Column("_ownerCharacterName")]
  [StringLength(30)]
  public string OwnerCharacterName { get; set; } = null!;

  [Column("_targetUserNo")]
  public long TargetUserNo { get; set; }

  [Column("_targetUserCharacterNo")]
  public long TargetUserCharacterNo { get; set; }

  [Column("_targetCharacterName")]
  [StringLength(30)]
  public string TargetCharacterName { get; set; } = null!;

  [Column("_positionX")]
  public long PositionX { get; set; }

  [Column("_positionY")]
  public long PositionY { get; set; }

  [Column("_positionZ")]
  public long PositionZ { get; set; }

  [Column("_report")]
  [StringLength(100)]
  public string? Report { get; set; }
}