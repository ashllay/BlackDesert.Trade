using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Keyless]
[Table("TblTradeAuthKeyHistory", Schema = "PaGamePrivate")]
public class TblTradeAuthKeyHistory
{
  [Column("_historyNo")]
  public long HistoryNo { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_type")]
  public byte? Type { get; set; }

  [Column("_userNo")]
  public long? UserNo { get; set; }

  [Column("_requestKey")]
  [StringLength(50)]
  public string? RequestKey { get; set; }

  [Column("_curKey")]
  [StringLength(50)]
  public string? CurKey { get; set; }

  [Column("_curUpdateDate", TypeName = "datetime")]
  public DateTime? CurUpdateDate { get; set; }

  [Column("_prevKey")]
  [StringLength(50)]
  public string? PrevKey { get; set; }

  [Column("_prevUpdateDate", TypeName = "datetime")]
  public DateTime? PrevUpdateDate { get; set; }

  [Column("_returnValue")]
  public long? ReturnValue { get; set; }
}