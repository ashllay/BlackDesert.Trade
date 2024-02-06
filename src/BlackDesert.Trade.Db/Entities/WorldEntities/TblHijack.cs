using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[PrimaryKey("AdminUserNo", "HijackUserNo")]
[Table("TblHijack", Schema = "PaGamePrivate")]
[Microsoft.EntityFrameworkCore.Index("AdminUserNo", Name = "UQ__TblHijac__3B4EB7571B6D25FD", IsUnique = true)]
[Microsoft.EntityFrameworkCore.Index("HijackUserNo", Name = "UQ__TblHijac__647D4392E18D9723", IsUnique = true)]
public class TblHijack
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   _adminUserNo
  /// </summary>
  [Key]
  [Column("_adminUserNo")]
  public long AdminUserNo { get; set; }

  /// <summary>
  ///   _hijackUserNo
  /// </summary>
  [Key]
  [Column("_hijackUserNo")]
  public long HijackUserNo { get; set; }
}