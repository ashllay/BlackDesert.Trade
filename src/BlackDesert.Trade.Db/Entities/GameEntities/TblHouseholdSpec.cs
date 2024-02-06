using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   하우징 하우스홀드 기본 테이블
/// </summary>
[Table("TblHouseholdSpec", Schema = "PaGamePrivate")]
public class TblHouseholdSpec
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   _householdNo
  /// </summary>
  [Key]
  [Column("_householdNo")]
  public long HouseholdNo { get; set; }

  /// <summary>
  ///   텐트나 고정집에 대응하는 캐릭터키
  /// </summary>
  [Column("_characterKey")]
  public int CharacterKey { get; set; }

  /// <summary>
  ///   household의 타입 - 0개인텐트,1고정집,2하우징설치물,3장애물,4공성텐트,5마을의 여관방,6성채 텐트7함정,8촌장텐트
  /// </summary>
  [Column("_type")]
  public byte Type { get; set; }

  /// <summary>
  ///   캐릭을 소유한 사용자번호
  /// </summary>
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   소유자 사용자 캐릭터번호
  /// </summary>
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  /// <summary>
  ///   집/텐트가 설치된 구역의 레지온키
  /// </summary>
  [Column("_townRegionKey")]
  public int TownRegionKey { get; set; }

  /// <summary>
  ///   현재는 만료기간이 Auction 에서 하고 있음
  /// </summary>
  [Column("_expiration", TypeName = "datetime")]
  public DateTime? Expiration { get; set; }
}