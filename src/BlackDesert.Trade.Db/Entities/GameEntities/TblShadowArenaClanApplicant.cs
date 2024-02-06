using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblShadowArenaClanApplicant", Schema = "PaGamePrivate")]
public class TblShadowArenaClanApplicant
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_clanNo")]
  public long ClanNo { get; set; }

  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_userNickname")]
  [StringLength(30)]
  public string UserNickname { get; set; } = null!;
}