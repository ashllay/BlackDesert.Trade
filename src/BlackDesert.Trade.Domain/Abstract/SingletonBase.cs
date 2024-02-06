namespace BlackDesert.Trade.Domain.Abstract;

public abstract class SingletonBase<T> where T : SingletonBase<T>
{
  private static readonly Lazy<T> Lazy =
    new(() => (Activator.CreateInstance(typeof(T), true) as T)!, LazyThreadSafetyMode.ExecutionAndPublication);

  public static T This => Lazy.Value;

  public void Init() {
    //do nothing
  }
}