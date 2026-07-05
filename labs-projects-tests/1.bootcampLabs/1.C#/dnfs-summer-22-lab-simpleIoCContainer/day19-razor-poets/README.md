# Reflection - Simple IoC Container

## A. Scenario

> What is this crap?! We could build this better ourselves. How hard can it be?!

The moment the words are utter you know that you are doomed. Saying `How hard can it be?` is the sure death for every project.

And now it was said about an IoC container... This will not end well.

## B. What you will be working on

The exercise today is to build a simple IoC container, using reflection. It's not as hard as you would think... How hard can it be?

(Comment from lab-creator: We would never do this in real-life. If you ever do I'll come out and smack you over your fingers... But it is not that hard, and will give you a lot of insights in how classes, constructors, dependencies and inversion of control containers works)

## C. Setup

You'll get three projects in this solution:

1. `SaltIoC.ExampleClasses` - contains all the interfaces and classes we want to register and resolve.
   - You don't need to add anything in here
1. one class library to contain the `SaltIoC.Container` class
1. one class library with tests `SaltIoC.Tests`
   - We have given you some tests but you might want to add more.

## D. Lab instructions

- Implement the `ISaltIoCContainer` in a new class called `SaltIoCContainer`
- Notice the type constraints on the `void Register<I, T>() where T : class, I;`
  - `T : class` says that `T` has to be a class
  - `T: I` means that `T` needs to implement `I`
- `Register` should store which interface (`I`) should resolve to which implementation (`T`)
  - This function will need you to keep state in the class
- `Resolve<T>` should create an instance of the given type `T`

  - This method should instantiate the type using reflection
  - See how we have used this method in `SaltIoC.Test` to see how it should work
  - The method should:

    - Check that `T` only have one, public constructor
      - If not throw an exception
      - See tests `throwsForNoPublicConstructor` and `throwsForMoreThanOnePublicConstructors`
    - If `T` has a constructor with no parameters the class should be instantiated directly using reflection.
      - See `resolvesForOneEmptyConstructor`
    - If `T` has parameters that are registered we need to call `Resolve` again, for that parameter.

      - We have supplied you with a method for this, since it's a bit tricky to do using reflection - `ReflectionResolve`. Here is the method, for you to copy:

        ```csharp
        private object ReflectionResolve(Type t) =>
          this
            .GetType()
            .GetMethod(nameof(Resolve))
            .MakeGenericMethod(t)
            .Invoke(this, null);
        ```

      - See test `oneConstructorParameter_Registered`
      - See test

    - If `Resolve` is called with a class with parameters, but these parameters are not registered and error should be thrown.
      - See `oneConstructorParameter_NotRegistered`

  - Handle `Resolve<T>` where `T` has a constructor with more than one parameter
    - See `twoConstructorParameter_Registered`
  - Handle `Resolve<T>` where `T` have nested dependencies in levels
    - See `nestedDependencies`

---

Good luck and have fun!
