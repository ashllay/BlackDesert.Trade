using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("Dim_GuildItemKey", Schema = "PaOperationPublic")]
public class DimGuildItemKey
{
  [Key]
  [Column("_itemKey")]
  public int ItemKey { get; set; }
}