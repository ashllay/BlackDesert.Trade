using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "MarbleKey")]
[Table("TblMarbleGameMap", Schema = "PaWebGamePrivate")]
public class TblMarbleGameMap
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_marbleKey")]
  public byte MarbleKey { get; set; }

  [Column("_nowPosition")]
  public int NowPosition { get; set; }

  [Column("_nextPlayDiceDate", TypeName = "datetime")]
  public DateTime? NextPlayDiceDate { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_useCardKey")]
  public int UseCardKey { get; set; }
}