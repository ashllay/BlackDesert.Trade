using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblItemToInventoryRequest", Schema = "PaOperationPrivate")]
public class TblItemToInventoryRequest
{
  [Column("_requestNo")]
  public int RequestNo { get; set; }

  [Column("_requestUserNo")]
  public long RequestUserNo { get; set; }

  [Column("_confirmUserNo")]
  public long? ConfirmUserNo { get; set; }

  [Column("_requestedDate", TypeName = "datetime")]
  public DateTime RequestedDate { get; set; }

  [Column("_isSended")]
  public bool IsSended { get; set; }

  [Column("_noteNo")]
  [StringLength(50)]
  public string NoteNo { get; set; } = null!;

  [Column("_noteURL")]
  [StringLength(300)]
  public string? NoteUrl { get; set; }

  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  [Column("_toWhere")]
  public byte ToWhere { get; set; }

  [Column("_itemKey")]
  public int ItemKey { get; set; }

  [Column("_enchantLevel")]
  public byte EnchantLevel { get; set; }

  [Column("_isStack")]
  public bool IsStack { get; set; }

  [Column("_isVested")]
  public bool IsVested { get; set; }

  [Column("_endurance")]
  public int Endurance { get; set; }

  [Column("_maxEndurance")]
  public int MaxEndurance { get; set; }

  [Column("_itemCount")]
  public long ItemCount { get; set; }
}