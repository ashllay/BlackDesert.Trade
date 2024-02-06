using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Table("TblTeenageUserInformation", Schema = "PaGamePrivate")]
public class TblTeenageUserInformation
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Key]
  [Column("_userId")]
  [StringLength(30)]
  public string UserId { get; set; } = null!;

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_teenAgeType")]
  public byte TeenAgeType { get; set; }
}