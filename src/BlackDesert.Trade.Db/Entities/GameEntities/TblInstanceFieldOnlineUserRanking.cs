using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("Ranking", "InstanceFieldKey", "IsNormal")]
[Table("TblInstanceFieldOnlineUserRanking", Schema = "PaGamePrivate")]
public class TblInstanceFieldOnlineUserRanking
{
  [Key]
  [Column("_ranking")]
  public int Ranking { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_instanceFieldKey")]
  public int InstanceFieldKey { get; set; }

  [Key]
  [Column("_isNormal")]
  public bool IsNormal { get; set; }
}