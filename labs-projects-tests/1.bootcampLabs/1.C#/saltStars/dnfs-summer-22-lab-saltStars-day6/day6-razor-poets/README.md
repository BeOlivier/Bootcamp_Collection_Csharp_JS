# DNFS - Salt Stars Day 6

## A. Scenario

> Great news, everyone - we get to play with new tools!

The tech lead walks into the team room and smiles. After a budget meeting, that's a first.

> I'm not kidding - we can checkout some of the new tooling that exists around .NET. So for this one day - go crazy and find a tool that you like and rock on.

He didn't come to the end of that sentence until the room was buzzing with people looking for great IDEs...

## B. What you will be working on today

Visual Studio Code is an amazing tool, but still just a code editor. There is a lot of terminal typing and it's not super snappy. Also, there are other parts to development that you often need to do that you need to go outside of VS Code to find tooling for.

Today we will look at another type of tools; IDE (Integrated Development Environments) that is geared towards .NET development. The most common is called Visual Studio. There are other powerful IDEs, too, such as Rider. For today, we can choose between using either of those.

We will build the entire application that we have worked on, from scratch. The goal of today is not to write code, but to get aquatinted with the tools. Hence we will copy the contents of the files from a finished version of day 5. These files are included in this repository and is a **suggested** solution.

The rest of the week will be spent in using an IDE, to give you some familiarly with such a powerful tool. In the rest of the course we will go back and forth.

## C. Tools and requirements

- An IDE (like Visual Studio or Rider)

## D. Lab instructions

1. Create a blank solution called `Salt.Stars`
1. Salt.Stars.Greeter

   1. Add a new xUnit test project called `Salt.Stars.Greeter.Tests` to the solution
   1. Add a new Class library project called `Salt.Stars.Greeter` to the solution
   1. Reference the `Salt.Stars.Greeter` from `Salt.Stars.Greeter.Tests`
   1. Run the tests
   1. Add a NuGet package called `FluentAssertions` to `Salt.Stars.Greeter.Tests`
   1. Copy the tests from this repo (`Salt.Stars.Greeter.Tests`)
   1. Copy the implementation from this repo (`Salt.Stars.Greeter`)
   1. Run the tests and try to find out how to debug it

1. Salt.Stars.WebAPI

   1. Add a new xUnit test project called `Salt.Stars.API.Tests` to the solution
   1. Add a new WebAPi project called `Salt.Stars.API` to the solution
   1. Reference the `Salt.Stars.API` from `Salt.Stars.API.Tests`
   1. Add a NuGet package called `FluentAssertions` to `Salt.Stars.API.Tests`
   1. Add a NuGet package called `Moq` to `Salt.Stars.API.Tests`
   1. Run the tests
   1. Run `Salt.Stars.API` and see how it looks in the browser
   1. Make `Salt.Stars.API` run on port 6001
   1. Copy all the files from `Salt.Stars.API` and `Salt.Stars.API.Test` to the new solution
   1. Make the test pass

1. Salt.Stars.Web

   1. Add a new xUnit test project called `Salt.Stars.Web.Tests` to the solution
   1. Add a new Razor Pages (Web Application) project called `Salt.Stars.Web` to the solution
   1. Reference the `Salt.Stars.Web` from `Salt.Stars.Web.Tests`
   1. Add a NuGet package called `FluentAssertions` to `Salt.Stars.Web.Tests`
   1. Add a NuGet package called `Moq` to `Salt.Stars.Web.Tests`
   1. Run the tests
   1. Run `Salt.Stars.Web` and see how it looks in the browser
   1. Make `Salt.Stars.Web` run on port 5001
   1. Copy all the files from `Salt.Stars.Web` and `Salt.Stars.Web.Test` to the new solution
   1. Make the test pass

1. Run the entire application

   1. Make sure that both the `Salt.Stars.API` and `Salt.Stars.Web` starts when you start the application.
   1. Test the application
   1. Add a new xUnit test project called `Salt.Stars.End2End` to the solution
   1. Add a NuGet package called `Selenium.WebDriver` to `Salt.Stars.Web.Tests`
   1. Copy all the files from `Salt.Stars.E2E` to the new solution
   1. Run the tests in `Salt.Stars.E2E` and make the pass

### Tips

- You can run this exercise several times and try it in Visual Studio Community Edition for Windows, in Rider, in Visual Studio For Mac etc.
- Discussions such as (some tool) VS (some other tool) could become a never ending discussion. Use that time to learn some tool AND some other tool ;-)

---

Good luck and have fun!
