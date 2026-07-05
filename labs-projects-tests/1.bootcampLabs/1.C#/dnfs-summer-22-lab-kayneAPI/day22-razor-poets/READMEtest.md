# Kanye West Quoter Tester

## A. Scenario

> Haha - and then we didn't even write a single test for it

The short comment in the elevator hits you in the stomach like fist of ice... Tests - we haven't written any tests for the code I wrote yesterday. This is just not finished...

Luckily there is still time - not due until tomorrow

## B. What you will be working on

Today we are going to write tests for our Kanye West Quote application. For all levels in the testing pyramid

- Unit tests
  - which probably will need some refactoring to make code testable
  - use mock (Moq - <https://www.nuget.org/packages/Moq/>)
  - try to make a pure function somewhere in your code
- Integration tests
  - Using AspNetCore.Mvc.Testing (<https://www.nuget.org/packages/Microsoft.AspNetCore.Mvc.Testing/>)
- End2End test
  - Using plain old HttpClient

I suggest that you create one xUnit test project per type of test.

## C. Setup

Continue to work in the solution that you created yesterday.

## D. Lab instructions

- First create a few unit tests
  - `How can I verify the code here as a unit` is a good starting point
  - Use Moq and xUnit
  - Ensure that you take every edge-case;
    - what if it throws an error
    - what if I get another return value
    - what if I get null
    - what if I get exactly what I was looking for
- Then create a few integration tests
  - Verify that the unit integrates together
  - Use AspNetCore.MVC.Test and the example code from the slides
- Finally create one or two e2e tests
  - Use the HTTPClient
  - Remember that you will need to start `dotnet run` the API in order to access it through your tests

---

Good luck and have fun!
