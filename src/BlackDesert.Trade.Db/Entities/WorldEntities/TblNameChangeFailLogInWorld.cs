using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Keyless]
[Table("TblNameChangeFailLogInWorld", Schema = "PaOperationPrivate")]
public class TblNameChangeFailLogInWorld
{
  [Column("_mDate")]
  [StringLength(8)]
  public string? MDate { get; set; }

  [Column("_ownerNo")]
  public long? OwnerNo { get; set; }

  [Column("_nameChangeType")]
  public int? NameChangeType { get; set; }

  [Column("_name")]
  [StringLength(30)]
  public string? Name { get; set; }

  [Column("_beforeName")]
  [StringLength(30)]
  public string? BeforeName { get; set; }

  [Column("_result")]
  public int? Result { get; set; }

  [Column("_rv")]
  public int? Rv { get; set; }
}