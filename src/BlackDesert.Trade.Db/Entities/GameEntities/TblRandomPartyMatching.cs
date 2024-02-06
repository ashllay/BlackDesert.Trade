using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("InstanceFieldKey", "RegisterDate", "UserNo")]
[Table("TblRandomPartyMatching", Schema = "PaGamePrivate")]
public class TblRandomPartyMatching
{
  [Key]
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_instanceFieldKey")]
  public int InstanceFieldKey { get; set; }

  [Column("_enterServerNo")]
  public long EnterServerNo { get; set; }
}