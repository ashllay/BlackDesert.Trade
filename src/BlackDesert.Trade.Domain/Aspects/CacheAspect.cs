using AspectInjector.Broker;
using Microsoft.Extensions.Caching.Memory;

namespace BlackDesert.Trade.Domain.Aspects;

/// <summary>
///   Basic caching aspect for caching method results.
///   Cache key is built from namespace, class name, method name and arguments.
///  
/// </summary>
[Aspect(Scope.Global)]
[Injection(typeof(CacheAspect))]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
public class CacheAspect : Attribute
{
  public int DurationSeconds { get; set; } = 1;
  public bool VaryByArguments { get; set; } = true;

  [Advice(Kind.Around)]
  public object Intercept(
    [Argument(Source.Target)] Func<object[], object> target,
    [Argument(Source.Arguments)] object[] args,
    [Argument(Source.Name)] string methodName,
    [Argument(Source.Type)] Type type,
    [Argument(Source.ReturnType)] Type returnType) {
    var memoryCache = AppServiceAccessor.GetService<IMemoryCache>();
    var cacheKey = BuildCacheKey(type, methodName, args, VaryByArguments);
    var cache = memoryCache.Get(cacheKey);
    if (cache is not null) return cache;
    var result = target(args);
    memoryCache.Set(cacheKey, result, TimeSpan.FromSeconds(DurationSeconds));
    return result;
  }

  private static string BuildCacheKey(Type classType,
                                      string methodName,
                                      object[] args,
                                      bool varyByArguments) {
    var nameSpace = classType.Namespace;
    var classTypeName = classType.Name;
    var cacheKey = $"{nameSpace}.{classTypeName}.{methodName}";
    if (!varyByArguments) return cacheKey;
    if (args.Length == 0) return cacheKey;
    var array = args.Select(x => x.GetHashCode()).ToList();
    var joined = string.Join(", ", array);
    cacheKey += $".{joined}";
    return cacheKey;
  }
}