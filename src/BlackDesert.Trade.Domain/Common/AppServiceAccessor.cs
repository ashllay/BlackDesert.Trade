namespace BlackDesert.Trade.Domain.Common;

public static class AppServiceAccessor
{
  private static IServiceProvider? _serviceProvider;

  public static void SetServiceCollection(this IServiceProvider provider) {
    if (_serviceProvider != null) throw new InvalidOperationException("ServiceCollection is already set");
    _serviceProvider = provider;
  }


  public static T GetService<T>() {
    return _serviceProvider.GetRequiredService<T>();
  }
}