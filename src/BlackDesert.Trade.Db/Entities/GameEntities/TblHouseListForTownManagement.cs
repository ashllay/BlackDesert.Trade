﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   마을 관리 유저가 소유한 집 목록
/// </summary>
[PrimaryKey("UserNo", "HouseKey")]
[Table("TblHouseListForTownManagement", Schema = "PaGamePrivate")]
public class TblHouseListForTownManagement
{
  /// <summary>
  ///   유저번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   _houseKey
  /// </summary>
  [Key]
  [Column("_houseKey")]
  public int HouseKey { get; set; }

  /// <summary>
  ///   0은 용도없음
  /// </summary>
  [Column("_useType")]
  public int UseType { get; set; }

  /// <summary>
  ///   이전레벨
  /// </summary>
  [Column("_prevLevel")]
  public int PrevLevel { get; set; }

  /// <summary>
  ///   현재레벨
  /// </summary>
  [Column("_level")]
  public int Level { get; set; }

  /// <summary>
  ///   돌려받을 탐험포인트 지역키
  /// </summary>
  [Column("_territoryKey")]
  public long TerritoryKey { get; set; }

  /// <summary>
  ///   돌려받을 탐험포인트
  /// </summary>
  [Column("_returnExplorePoint")]
  public int ReturnExplorePoint { get; set; }

  /// <summary>
  ///   사용 가능한 시간(용도 변경시 세팅)
  /// </summary>
  [Column("_usableTime", TypeName = "datetime")]
  public DateTime UsableTime { get; set; }
}