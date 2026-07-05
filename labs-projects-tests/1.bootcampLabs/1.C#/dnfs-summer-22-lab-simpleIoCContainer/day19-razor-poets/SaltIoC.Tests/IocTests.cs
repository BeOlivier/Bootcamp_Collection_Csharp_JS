using System;
using SaltIoC.Container;
using SaltIoC.ExampleClasses;
using Xunit;

namespace SaltIoC.Tests
{
  public class IocTests
  {
    private readonly SaltIoCContainer ioc;
    public IocTests()
    {
      ioc = new SaltIoCContainer();
    }
    [Fact]
    public void throwsForNoPublicConstructor()
    {
      // act
      Assert.Throws<Exception>(() => ioc.Resolve<NoPublicConstructor>());
    }

    [Fact]
    public void throwsForMoreThanOnePublicConstructors()
    {
      // act
      Assert.Throws<Exception>(() => ioc.Resolve<TwoPublicConstructors>());
    }

    [Fact]
    public void resolvesForOneEmptyConstructor()
    {
      // act
      var obj = ioc.Resolve<OnePublicConstructor>();

      // assert
      Assert.NotNull(obj);
      Assert.IsType<OnePublicConstructor>(obj);
    }

    [Fact]
    public void oneConstructorParameter_Registered()
    {
      // arrange
      ioc.Register<IPerson, Person>();

      // act
      var obj = ioc.Resolve<OneConstructorParameter>();

      // assert
      Assert.NotNull(obj);
      Assert.IsType<OneConstructorParameter>(obj);
      Assert.IsType<Person>(obj.Person);
    }

    [Fact]
    public void throwsForRegisteringAlreadyRegistered()
    {
      // arrange
      ioc.Register<IPerson, Person>();

      // act
      Action act = () => ioc.Register<IPerson, VIPPerson>();

      // assert
      Assert.Throws<ArgumentException>(act);
    }

    [Fact]
    public void oneConstructorParameter_NotRegistered()
    {
      // act
      Action act = () => ioc.Resolve<OneConstructorParameter>();

      // assert
      Assert.Throws<Exception>(act);
    }


    [Fact]
    public void twoConstructorParameter_Registered()
    {
      // arrange
      ioc.Register<IPerson, VIPPerson>();
      ioc.Register<INameable, Thing>();

      // act
      var obj = ioc.Resolve<TwoConstructorParameters>();

      // assert
      Assert.NotNull(obj);
      Assert.IsType<TwoConstructorParameters>(obj);
      Assert.IsType<VIPPerson>(obj.Person);
      Assert.True(obj.Nameable.GetName() != string.Empty);
    }

    [Fact]
    public void nestedDependencies()
    {
      // arrange
      ioc.Register<IPerson, VIPPerson>();
      ioc.Register<INameable, SubLevelClass>();

      // act
      var obj = ioc.Resolve<Levels>();

      // assert
      Assert.NotNull(obj);
      Assert.IsType<Levels>(obj);
      Assert.IsType<VIPPerson>(obj.person);
      Assert.True(obj.nameable.GetName() != string.Empty);
    }
  }

}
