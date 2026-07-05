namespace SaltIoC.Container
{
  public interface ISaltIoCContainer
  {
    void Register<I, T>() where T : class, I;

    T Resolve<T>();
  }
}
