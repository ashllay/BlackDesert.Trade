using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("ChatRoomNo", "UserNo")]
[Table("TblThumbsUpCountInformation", Schema = "PaGamePrivate")]
public class TblThumbsUpCountInformation
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_chatRoomNo")]
  public long ChatRoomNo { get; set; }

  [Column("_thumbsUpCount")]
  public int ThumbsUpCount { get; set; }

  [Column("_thumbsUpGrade")]
  public int ThumbsUpGrade { get; set; }
}