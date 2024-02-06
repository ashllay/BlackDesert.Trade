using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Table("TblPS4AccessTokenList", Schema = "PaGamePrivate")]
public class TblPs4accessTokenList
{
  [Key]
  [Column("_userId")]
  [StringLength(30)]
  public string UserId { get; set; } = null!;

  [Column("_accessToken")]
  [StringLength(40)]
  public string? AccessToken { get; set; }

  [Column("_ps4UserId")]
  [StringLength(30)]
  public string Ps4UserId { get; set; } = null!;

  [Column("_lastUpdateTime", TypeName = "datetime")]
  public DateTime? LastUpdateTime { get; set; }
}