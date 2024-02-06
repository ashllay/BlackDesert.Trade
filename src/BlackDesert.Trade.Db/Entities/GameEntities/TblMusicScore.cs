using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblMusicScore", Schema = "PaGamePrivate")]
public class TblMusicScore
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Key]
  [Column("_musicScoreNo")]
  public long MusicScoreNo { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  [Column("_version")]
  public short Version { get; set; }

  [Column("_size")]
  public short Size { get; set; }

  [Column("_musicScore")]
  public byte[] MusicScore { get; set; } = null!;
}