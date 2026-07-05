# Pattern builder

## A. Scenario

> Well, that's the gist of it. I want you to create an abstract factory that returns a mediator from which we can spawn a visitor for our strategy. And obviosly we use the Repository pattern to encapsulate the Should not be that hard.

You look around the room. Your buddy to the right makes a twirling motion around his temple... Lisa is wording `I. DONT. UNDERSTAND. A. SINGLE. WORD.` almost audible. What was that noise? Did Bill just faint?

This new architect is on a whole other level. You better break out the Gang Of Four Pattern book. I think he is trying to communicate with us.

## B. What you will be working on

One of the big benefits of using patterns is that we can communicate a lot with few words, we can talk about code on a higher abstraction level. This exists for all professions, but is particularly geeky in our word.

Today we will practice that. These instructions will not be long, but might require research to turn into code. It's also not guaranteed that the code will make something that works, but rather just create a structure.

## C. Setup

We have created a class library and a test library for you.

- `Patterns.Business` put your production code in this project. We suggest that you create a folder (and namespace) for each exercises
- `Patterns.Tests` - put your test code here. You should write tests for the code that you create in order to get a feel for how it will be to work with.

## D. Lab instructions

1. Implement the repository pattern for Customers, saved to an in-memory list
   1. Create `Customer` class with a few appropiate fields   
   1. Create a generic `IRepository` with CRUD-methods
   1. Create an `ICustomerRepository` and implements the generic interface
   1. Let the `ICustomerRepository` have methods to find customers by city and shoe-size
   1. Create an implementation of `ICustomerRepository` called `InMemoryRepository`
   1. Create a backing field that is an in-memory `IList<Customner>`, make it private
   1. Implement all the methods of the `ICustomerRepository` in `InMemoryRepository`
   1. Write tests for the `InMemoryRepository`
1. Implement a fluent interface (chain of responsibility) calculator interface that allows me to use it code like this:

   ```csharp
   var result = calculator
     .Add(1)
     .Add(1)
     .Add(1)
     .Subtract(1)
     .Multiply(2)
     .Divide(2);
   result.Should().Be(2);
   ```

1. Implement a Facade for handling text files for `List<string>` that supports the following interface:

   ```csharp
   public interface ITextFileManager {
     void Create(string fileName, List<string> lines);
     List<string> Read(string fileName);
     void Delete(string fileName);
     bool Exists(string fileName)
   }
   ```

   1. Make it use the standard .NET File interface
   1. Write tests that uses the methods

---

Good luck and have fun!
