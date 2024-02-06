using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblThumbsUpInformation", Schema = "PaGamePrivate")]
public class TblThumbsUpInformation
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_thumbsUpVoteCount")]
  public short ThumbsUpVoteCount { get; set; }

  [Column("_lastVoteTime", TypeName = "datetime")]
  public DateTime LastVoteTime { get; set; }
}