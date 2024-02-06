using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("RegisterDate", "HostGuildNo", "ReceiveUserNo")]
[Table("TblRequestGuildInviteList", Schema = "PaGamePrivate")]
public class TblRequestGuildInviteList
{
  [Key]
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_hostUserNo")]
  public long HostUserNo { get; set; }

  [Key]
  [Column("_hostGuildNo")]
  public long HostGuildNo { get; set; }

  [Key]
  [Column("_receiveUserNo")]
  public long ReceiveUserNo { get; set; }

  [Column("_contractBenefit")]
  public long ContractBenefit { get; set; }

  [Column("_contractPenalty")]
  public long ContractPenalty { get; set; }

  [Column("_contractDay")]
  public int ContractDay { get; set; }
}