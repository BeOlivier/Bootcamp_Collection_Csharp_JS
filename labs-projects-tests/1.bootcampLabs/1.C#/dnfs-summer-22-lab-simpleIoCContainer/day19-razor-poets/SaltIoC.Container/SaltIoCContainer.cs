using System;

namespace SaltIoC.Container
{

  public class SaltIoCContainer : ISaltIoCContainer
  {
    public void Register<I, T>() where T : class, I
    {
      throw new NotImplementedException();
    }

    public T Resolve<T>()
    {
      throw new NotImplementedException();
    }
  }
}
