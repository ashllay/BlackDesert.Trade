using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Keyless]
[Table("TblUniqueName_Backup", Schema = "PaOperationPrivate")]
public class TblUniqueNameBackup
{
  [Column("_backupDate")]
  [StringLength(8)]
  public string BackupDate { get; set; } = null!;

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_type")]
  public byte Type { get; set; }

  [Column("_variousNo")]
  public long VariousNo { get; set; }

  [Column("_name")]
  [StringLength(50)]
  public string Name { get; set; } = null!;

  [Column("_worldNo")]
  public short WorldNo { get; set; }

  [Column("_deletedDate", TypeName = "datetime")]
  public DateTime? DeletedDate { get; set; }
}