using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.TradeEntities;

[PrimaryKey("NationCode", "ServerNo", "UserNo")]
[Table("TblBlockUser", Schema = "PaGamePrivate")]
public class TblBlockUser
{
  [Key]
  [Column("_nationCode")]
  public int NationCode { get; set; }

  [Key]
  [Column("_serverNo")]
  public int ServerNo { get; set; }

  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_dueDate", TypeName = "datetime")]
  public DateTime? DueDate { get; set; }
}