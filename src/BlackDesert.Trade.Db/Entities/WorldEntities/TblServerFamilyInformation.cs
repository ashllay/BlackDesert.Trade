using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Keyless]
[Table("TblServerFamilyInformation", Schema = "PaGamePrivate")]
public class TblServerFamilyInformation
{
  [Required]
  [Column("_isValid")]
  public bool? IsValid { get; set; }

  [Column("_fromServerNo")]
  public short FromServerNo { get; set; }

  [Column("_toServerNo")]
  public short ToServerNo { get; set; }
}