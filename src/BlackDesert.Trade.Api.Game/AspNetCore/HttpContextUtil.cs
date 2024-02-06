namespace BlackDesert.Trade.Domain.AspNetCore;

public static class HttpContextUtil
{
  // public static HttpContext Current => Accessor.HttpContext;


  private static readonly List<string> HeaderRealIpNames = new() {
    "X-Forwarded-For",
    "HTTP_X_FORWARDED_FOR",
    "X-PA-IP",
    "REMOTE_ADDR"
  };

  private static HttpContextAccessor Accessor => new();

  public static string GetRemoteIpAddress(this HttpContext context) {
    foreach (var header in HeaderRealIpNames)
      if (context.Request.Headers.TryGetValue(header, out var values)) {
        var ip = values.FirstOrDefault();
        if (!string.IsNullOrEmpty(ip)) return ip;
      }

    var remoteIpAddress = context.Connection.RemoteIpAddress;
    if (remoteIpAddress is null) return string.Empty;
    if (remoteIpAddress.IsIPv4MappedToIPv6) remoteIpAddress = remoteIpAddress.MapToIPv4();
    return remoteIpAddress.ToString();
  }

  public static string[] GetUserLanguages(this HttpContext httpContext) {
    var strArray = new string[0];
    if (httpContext.Request.Headers.ContainsKey("Accept-Language"))
      strArray = httpContext.Request.Headers["Accept-Language"].ToString().Split(',');
    return strArray;
  }
}