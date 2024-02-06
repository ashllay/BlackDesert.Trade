using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblMainQuestGroupInfo", Schema = "PaGamePrivate")]
public class TblMainQuestGroupInfo
{
  [Key]
  [Column("_questGroupNo")]
  public int QuestGroupNo { get; set; }
}