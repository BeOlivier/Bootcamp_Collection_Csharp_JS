# Manual Dependency Injection

## A. Scenario

> THIS SUCKS!? How am I going to test this code?

Your own reaction scares you. Have you already become a testing-purist? But the fact remains... Someone has given you this stupid code that you need to fix a bug in. And nowhere there's a single test. Obviously you don't want to start pulling this apart without knowing what you break.

But then it dawned on you ... this code cannot be tested, without running the whole application. It just can't.

We need to fix that first.

Then we'll go on to fix the bug... what was that now again

> There are only 3 report types but I can pass in any number (4 for example) and don't get to know that it was wrong

## B. What you will be working on

The exercise today is to refactor the code base in `DIP.ReportGenerator` so that it can be unit tested. Meaning the tests runs without using any of the code in the `DIP.Reports` that is very slow... sometimes ...

In order to do that you will need to introduce abstractions (interfaces) to represent the different type of reports and ensure that the `ReportGenerator` can handle these abstractions. You'll notice that the `Generator`-method has a lot of hard coded dependencies.

We will not have an IoC container to help us this time, but the _real_ implementations should be created in the `DIP.App` console application.

## C. Setup

We have supplied you with a starting point for the solution. Notice how this solution is hardwired to the implementations of `DIP.Reports` and runs slow, and is used for testing as well.

### D. Lab instructions

1. Read through the code and make sure you understand how it works
   1. You can run the application by `dotnet run -p DIP.App {reportType}` where `reportType` can be 1,2,3
   1. This is the bug... if you pass in 4 ... it will not tell you that the report type is not supported
1. Now try to write unit tests for the `ReportGenerator.Generator` class
   1. You should write your own fake versions of the report types, in the test project
   1. You will need to pass these in as dependencies to the `ReportGenerator.Generator` class
1. Fix the `DIP.App`
   1. Once you have all the code in the `ReportGenerator.Generator` class tested
   1. with fake versions of the `Reports`-classes
   1. make sure that the `DIP.App` creates the report of the correct type
   1. and pass it in as dependencies
1. Finally fix the bug... what should happen when I pass in `4` as reportType...How about an informative error message?

---

Good luck and have fun!
