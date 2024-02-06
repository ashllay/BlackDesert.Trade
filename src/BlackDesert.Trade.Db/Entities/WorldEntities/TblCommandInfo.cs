using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Table("TblCommandInfo", Schema = "PaOperationPrivate")]
public class TblCommandInfo
{
  [Key]
  [Column("_commandNo")]
  public long CommandNo { get; set; }

  [Column("_worldNo")]
  public int WorldNo { get; set; }

  [Column("_serverNo")]
  public int ServerNo { get; set; }

  [Column("_registerDate")]
  public DateTime? RegisterDate { get; set; }

  [Column("_commandString")]
  public string? CommandString { get; set; }

  [Column("_status")]
  public byte? Status { get; set; }

  [Column("_reserveDate")]
  public DateTime? ReserveDate { get; set; }

  [Column("_interval")]
  public long? Interval { get; set; }

  [Column("_type")]
  public byte Type { get; set; }

  [Column("_isCycleCommand")]
  public bool IsCycleCommand { get; set; }

  [Column("_endDate")]
  public DateTime EndDate { get; set; }
}