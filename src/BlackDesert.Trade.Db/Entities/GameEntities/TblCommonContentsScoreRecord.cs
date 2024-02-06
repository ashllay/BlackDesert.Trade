using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "CharacterNo", "ContentsType", "Mode", "Stage")]
[Table("TblCommonContentsScoreRecord", Schema = "PaGamePrivate")]
public class TblCommonContentsScoreRecord
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  [Key]
  [Column("_contentsType")]
  public short ContentsType { get; set; }

  [Key]
  [Column("_mode")]
  public short Mode { get; set; }

  [Key]
  [Column("_stage")]
  public short Stage { get; set; }

  [Column("_score")]
  public long Score { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }
}