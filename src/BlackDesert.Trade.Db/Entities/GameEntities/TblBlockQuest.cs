using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblBlockQuest", Schema = "PaGamePrivate")]
public class TblBlockQuest
{
  [Key]
  [Column("_blockNo")]
  public long BlockNo { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_questType")]
  public byte? QuestType { get; set; }

  [Column("_questGroupNo")]
  public int? QuestGroupNo { get; set; }

  [Column("_questNo")]
  public int? QuestNo { get; set; }

  [Column("_reasonMemo")]
  [StringLength(200)]
  public string? ReasonMemo { get; set; }
}