namespace BlackDesert.Trade.Domain.Common;

public static class DataHelper
{
  public static void ValidateUserNo(long userNo) {
    ArgumentNullException.ThrowIfNull(userNo, nameof(userNo));
    if (userNo < 1) throw new ArgumentOutOfRangeException(nameof(userNo), userNo, "UserNo must be greater than 0");
  }

  public static void ValidateCertifiedKey(string certifiedKey) {
    ArgumentNullException.ThrowIfNull(certifiedKey, nameof(certifiedKey));
    if (string.IsNullOrEmpty(certifiedKey)) throw new ArgumentOutOfRangeException(nameof(certifiedKey), certifiedKey, "CertifiedKey must not be empty");
    // if (certifiedKey.Length != 36) {
    //   throw new ArgumentOutOfRangeException(nameof(certifiedKey), certifiedKey, "CertifiedKey must be 36 characters long");
    // }
  }

  public static void NullCheck(object obj,
                               string name) {
    ArgumentNullException.ThrowIfNull(obj, name);
  }
}