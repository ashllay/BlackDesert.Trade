using System.Diagnostics;
using BlackDesert.Trade.Domain.Common;

namespace BlackDesert.Trade.Domain.AspNetCore.Middlewares;

public class EndpointPerformanceLoggerMiddleware
{
  private readonly RequestDelegate _next;

  public EndpointPerformanceLoggerMiddleware(RequestDelegate next) {
    _next = next;
  }

  public async Task Invoke(HttpContext context) {
    if (!ConstantContainer.CheckAndLogPerformance) {
      await _next(context);
      return;
    }
    var stopwatch = new Stopwatch();
    stopwatch.Start();
    await _next(context);
    stopwatch.Stop();
    var str = context.Request.Path.ToString();
    if (context.Request.QueryString.HasValue)
      str += context.Request.QueryString.Value;
    var num = (int)stopwatch.ElapsedMilliseconds;
    if (num > ConstantContainer.CheckAndLogPerformanceCheckMs) 
      Log.Warning("Endpoint process time is too long. {TimeElapsedMs}ms {Path}", num, str);
    else {
      Log.Verbose("Endpoint process time {TimeElapsedMs}ms {Path}", num, str);
    }
  }
}