using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblCompositionNotesCount", Schema = "PaWebGamePrivate")]
public class TblCompositionNotesCount
{
  [Column("_noteNo")]
  public long NoteNo { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_type")]
  public byte Type { get; set; }

  [Column("_flag")]
  public bool Flag { get; set; }
}