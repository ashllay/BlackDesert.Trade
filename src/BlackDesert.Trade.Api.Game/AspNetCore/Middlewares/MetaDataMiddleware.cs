namespace BlackDesert.Trade.Domain.AspNetCore.Middlewares;

public class MetaDataMiddleware
{
  private readonly RequestDelegate _next;

  public MetaDataMiddleware(RequestDelegate next) {
    _next = next;
  }

  public async Task InvokeAsync(HttpContext context) {
    SetResponseHeaders(context);
    await _next(context);
  }

  private static void SetResponseHeaders(HttpContext context) {
    try {
      var isReadOnly = context.Response.Headers.IsReadOnly;
      if (isReadOnly) {
        return;
      }
      context.Response.Headers.Remove("Server");
      context.Response.Headers.Remove("X-AspNetMvc-Version");
      context.Response.Headers.Remove("X-AspNet-Version");
      context.Response.Headers.Remove("X-Powered-By");
      context.Response.Headers.Add("Cache-Control", "private");
      // Log.Verbose("MetaDataMiddleware.SetResponseHeaders - Success");
    }
    catch (Exception) {
      // Log.Verbose(ex, "MetaDataMiddleware.SetResponseHeaders - Exception");
    }
  }
}