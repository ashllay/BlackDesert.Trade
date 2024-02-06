using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("Dim_itemOption_LongSword", Schema = "PaOperationPublic")]
public class DimItemOptionLongSword
{
  [Column("_itemKey")]
  public double? ItemKey { get; set; }

  [StringLength(255)]
  public string? ItemName { get; set; }

  public double? Enchant { get; set; }

  [Column("DDD")]
  [StringLength(255)]
  public string? Ddd { get; set; }

  [Column("AddedDDD")]
  public double? AddedDdd { get; set; }

  [Column("DHIT")]
  public double? Dhit { get; set; }

  [Column("DDV")]
  public double? Ddv { get; set; }

  [Column("HDDV")]
  public double? Hddv { get; set; }

  [Column("DPV")]
  public double? Dpv { get; set; }

  [Column("HDPV")]
  public double? Hdpv { get; set; }

  [Column("RDD")]
  [StringLength(255)]
  public string? Rdd { get; set; }

  [Column("AddedRDD")]
  public double? AddedRdd { get; set; }

  [Column("RHIT")]
  public double? Rhit { get; set; }

  [Column("RDV")]
  public double? Rdv { get; set; }

  [Column("HRDV")]
  public double? Hrdv { get; set; }

  [Column("RPV")]
  public double? Rpv { get; set; }

  [Column("HRPV")]
  public double? Hrpv { get; set; }

  [Column("MDD")]
  [StringLength(255)]
  public string? Mdd { get; set; }

  [Column("AddedMDD")]
  public double? AddedMdd { get; set; }

  [Column("MHIT")]
  public double? Mhit { get; set; }

  [Column("MDV")]
  public double? Mdv { get; set; }

  [Column("HMDV")]
  public double? Hmdv { get; set; }

  [Column("MPV")]
  public double? Mpv { get; set; }

  [Column("HMPV")]
  public double? Hmpv { get; set; }
}