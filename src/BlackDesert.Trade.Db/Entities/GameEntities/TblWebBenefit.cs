using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblWebBenefit", Schema = "PaGamePrivate")]
public class TblWebBenefit
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_isUserNo")]
  public bool IsUserNo { get; set; }

  [Column("_ownerNo")]
  public long OwnerNo { get; set; }

  [Column("_benefitType")]
  public int BenefitType { get; set; }

  [Column("_param0")]
  public long Param0 { get; set; }

  [Column("_param1")]
  public long Param1 { get; set; }
}