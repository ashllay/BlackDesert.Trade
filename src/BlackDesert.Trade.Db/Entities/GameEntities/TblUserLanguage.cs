using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblUserLanguage", Schema = "PaGamePrivate")]
public class TblUserLanguage
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_userLanguage")]
  public int UserLanguage { get; set; }
}