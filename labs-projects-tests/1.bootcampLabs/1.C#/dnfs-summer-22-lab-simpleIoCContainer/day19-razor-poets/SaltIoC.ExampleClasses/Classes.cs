namespace SaltIoC.ExampleClasses
{
  public interface IPerson
  {
    string GetFullName();
  }
  public class Person : IPerson
  {
    public string GetFullName()
    {
      return "The full name";
    }
  }

  public class VIPPerson : IPerson
  {
    public string GetFullName()
    {
      return "The full name, sir!";
    }
  }


  public class NoPublicConstructor
  {
    private NoPublicConstructor() { }
  }

  public class OnePublicConstructor
  {
    public OnePublicConstructor() { }
  }
  public class TwoPublicConstructors
  {
    public TwoPublicConstructors() { }
    public TwoPublicConstructors(string parameter) { }
  }

  public class OneConstructorParameter
  {
    public readonly IPerson Person;

    public OneConstructorParameter(IPerson person)
    {
      this.Person = person;
    }
  }

  public class TwoConstructorParameters
  {
    public readonly IPerson Person;
    public readonly INameable Nameable;

    public TwoConstructorParameters(IPerson person, INameable nameable)
    {
      this.Person = person;
      Nameable = nameable;
    }

  }

  public interface INameable
  {
    string GetName();
  }

  public class Thing : INameable
  {
    public string GetName()
    {
      return "My name";
    }
  }

  public class SubLevelClass : INameable
  {
    private readonly IPerson person;

    public SubLevelClass(IPerson person)
    {
      this.person = person;
    }
    public string GetName()
    {
      return person.GetFullName();
    }
  }

  public class Levels
  {
    public readonly INameable nameable;
    public readonly IPerson person;

    public Levels(INameable nameable, IPerson person)
    {
      this.nameable = nameable;
      this.person = person;
    }

  }
}
