using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Table("TblTradeAuthKey", Schema = "PaGamePrivate")]
public class TblTradeAuthKey
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_curKey")]
  public Guid? CurKey { get; set; }

  [Column("_prevKey")]
  public Guid? PrevKey { get; set; }

  [Column("_curUpdateDate", TypeName = "datetime")]
  public DateTime? CurUpdateDate { get; set; }

  [Column("_prevUpdateDate", TypeName = "datetime")]
  public DateTime? PrevUpdateDate { get; set; }
}