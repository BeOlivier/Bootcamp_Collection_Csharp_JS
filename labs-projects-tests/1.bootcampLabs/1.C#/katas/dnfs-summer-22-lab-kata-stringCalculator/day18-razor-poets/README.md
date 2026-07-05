# Salt Kata Series

## Kata 2 - String Calculator

### A. Scenario

Being a software developer involves a lot of logical problem solving and being able to do that in a readable and well structured manner. You should also be able to test your logic to make sure it runs as expected even if you were to refactor your code or make additions to it.

### B. What you will be working on

Today you will be solving the classic FizzBuzz kata. By the end of the lab we want you to:

- Have gained even more C# and `dotnet` understanding.
- Get even better at unit testing and get comfortable with using `xUnit` and `NUnit`
- You will also learn about different ways to
- Get better at solving problems as a team.

**Use TDD - this is part of what makes a kata useful**. We have already solved this katas problem - that's is not why we ask you to do it again. See the exercise like a barbell in a gym. It's not lifting it up to it's place that is the value - it's a tool to train a muscle. Or two.

### C. Setup

- Add a solution `StringCalculator.Kata`
- Create test project `StringCalculator.Tests` with a test framework and assertion library of you choice
- Create a class library `StringCalculator` to hold your production code
- Add a reference from the tests to the production code.

### D. Lab instructions

#### The Salt String Calculator Kata

This kata is heavily inspired by [Roy Osherove's classic String Calculator kata](http://osherove.com/tdd-kata-1/).
However, there are slight modifications to the Salt version, so stay alert!

#### The Kata

These are the rules to implement the kata.
Each rule makes for one or more tests that you will need to write and implement.
Implement one rule at a time.
_Do not read ahead!_

(Hint: Some of the rules may be split into multiple tests)

1. Calling the function `Add` without any parameters should throw an `Exception` with the message `No input.`.
2. Calling the function `Add` with an empty string should return `0`.
3. The function `Add` should only accept a string with integers separated by the delimiter comma: `,`
   - The code should throw an `Exception` with the message `Invalid input.` if the input does not conform to this rule.
4. The `Add` function should return a sum of all the integers.
5. Trailing or repeated delimiters (i.e. strings that ends with a delimiter or contains delimiters without numbers in between) are not allowed and the function should throw an `Exception` with the message `Invalid input.`.
6. Negative numbers are not allowed and an `Exception` should be thrown with the message `Negative numbers are not allowed: [n1,n2,...,nn].`. (Here, `n1,n2, etc` refers to all the negative numbers that the input contains)
7. Alternatively, the client may use line break as the delimiter. Line breaks may be repeated and mixed with `,`. However, `,` is still not allowed to be repeated with any delimiters. That means that the input may contain both `,` and line breaks, but `,` cannot be used without any numbers in between.
8. Numbers larger than `1000` should be treated as `0`.
