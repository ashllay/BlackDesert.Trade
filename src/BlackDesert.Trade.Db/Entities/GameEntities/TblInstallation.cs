using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   하우징 설치오브젝트 텐트 테이블
/// </summary>
[Table("TblInstallation", Schema = "PaGamePrivate")]
public class TblInstallation
{
  /// <summary>
  ///   _installationNo
  /// </summary>
  [Key]
  [Column("_installationNo")]
  public long InstallationNo { get; set; }

  /// <summary>
  ///   배치된 설치물 아이템 번호
  /// </summary>
  [Column("_itemNo")]
  public long ItemNo { get; set; }

  /// <summary>
  ///   _fieldNo
  /// </summary>
  [Column("_fieldNo")]
  public short FieldNo { get; set; }

  /// <summary>
  ///   _fieldIndex
  /// </summary>
  [Column("_fieldIndex")]
  public short FieldIndex { get; set; }

  /// <summary>
  ///   _posX
  /// </summary>
  [Column("_posX")]
  public double PosX { get; set; }

  /// <summary>
  ///   _posY
  /// </summary>
  [Column("_posY")]
  public double PosY { get; set; }

  /// <summary>
  ///   _posZ
  /// </summary>
  [Column("_posZ")]
  public double PosZ { get; set; }

  /// <summary>
  ///   _quatX
  /// </summary>
  [Column("_quatX")]
  public double QuatX { get; set; }

  /// <summary>
  ///   _quatY
  /// </summary>
  [Column("_quatY")]
  public double QuatY { get; set; }

  /// <summary>
  ///   _quatZ
  /// </summary>
  [Column("_quatZ")]
  public double QuatZ { get; set; }

  /// <summary>
  ///   _quatW
  /// </summary>
  [Column("_quatW")]
  public double QuatW { get; set; }

  /// <summary>
  ///   설비도구 공개설정: 0(공개), 1:(고정집안에서공개) 2:(여관안에서 공개)
  /// </summary>
  [Column("_privateFlag")]
  public byte PrivateFlag { get; set; }

  /// <summary>
  ///   설비도구가 처음 설치된 시간
  /// </summary>
  [Column("_installDate", TypeName = "datetime")]
  public DateTime InstallDate { get; set; }

  /// <summary>
  ///   설비도구가 작물일때, 성장정도
  /// </summary>
  [Column("_progressPercent")]
  public int ProgressPercent { get; set; }

  /// <summary>
  ///   설비도구가 작물일때, 시듦 수치
  /// </summary>
  [Column("_needWaterPercent")]
  public int NeedWaterPercent { get; set; }

  /// <summary>
  ///   설비도구가 작물일때, 작물 수확량 감소%
  /// </summary>
  [Column("_decreaseYieldPercent")]
  public int DecreaseYieldPercent { get; set; }

  /// <summary>
  ///   설비도구가 작물일때, 가지치기가 필요한 상태
  /// </summary>
  [Column("_needLop")]
  public bool NeedLop { get; set; }

  /// <summary>
  ///   설비도구가 작물일때, 병충해정리가 필요한 상태
  /// </summary>
  [Column("_needPestControl")]
  public bool NeedPestControl { get; set; }

  /// <summary>
  ///   고정집이 반납될때 삭제되는 설비도구
  /// </summary>
  [Column("_isErase")]
  public bool IsErase { get; set; }

  /// <summary>
  ///   설비도구 타입에 따라서 맞춰서 사용
  /// </summary>
  [Column("_param0")]
  public long Param0 { get; set; }

  /// <summary>
  ///   설비도구 타입에 따라서 맞춰서 사용
  /// </summary>
  [Column("_param1")]
  public double Param1 { get; set; }

  /// <summary>
  ///   인테리어 추가 점수에 따른 연관 설비도구 번호
  /// </summary>
  [Column("_relativeInstallationNo")]
  public long? RelativeInstallationNo { get; set; }
}