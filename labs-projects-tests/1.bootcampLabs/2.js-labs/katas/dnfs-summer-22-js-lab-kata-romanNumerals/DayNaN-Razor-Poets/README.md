# Salt Kata Series

## Kata 3 - Roman Numerals

### A. Scenario

Being a software developer involves a lot of logical problem solving and being able to do that in a readable and well structured manner. You should also be able to test your logic to make sure it runs as expected even if you were to refactor your code or make additions to it.

### B. What you will be working on

This is a third classic kata. By the end of the lab we want you to:

- Have gained even more Node.js understanding.
- Get even better at unit testing and get comfortable with using the Chai assertion library combined with Mocha.
- Get better at solving problems as a team.

### C. Testing and linting setup

#### Linting

Set up the project to use ESLint with the Salt Linting Config. [Here's](https://github.com/saltsthlm/salt-linting-demo) an instruction repo on how to use linters.

Also, make sure to add a few custom rules to your linter!

#### Testing

Set up the project to use the _Mocha_ as test runner. [Here's](https://github.com/saltsthlm/salt-testing-demo) instructions on how to use this testing framework.

_In addition_ to using Mocha, in this kata we're using [Chai-assertion library](https://www.chaijs.com/) to do our assertions. It's a popular assertion framework that helps us to write very semantic assertion statments.

Use the [should](https://www.chaijs.com/guide/styles/#should)-syntax

### D. Lab instructions

#### Roman Numerals

Another classic kata.

From [Wikipedia](https://en.wikipedia.org/wiki/Roman_numerals)

> The numeric system represented by Roman numerals originated in ancient Rome and remained the usual way of writing numbers throughout Europe well into the Late Middle Ages. Numbers in this system are represented by combinations of letters from the Latin alphabet. Roman numerals, as used today, are based on seven symbols:

| Symbol | I   | V   | X   | L   | C   | D   | M     |
| ------ | --- | --- | --- | --- | --- | --- | ----- |
| Value  | 1   | 5   | 10  | 50  | 100 | 500 | 1,000 |

_Note that Roman numerals are not defined for zero or negative numbers!_

#### The Kata

Create a _roman numeral convert_ that converts Arabic numbers to roman numerals.
Develop the code TDD style.
Make sure it works for all Arabic numbers between 1 and 3000. You don't have to test all numbers, but you have to test enough to be confident you have a working solution.

If you have time, you can also convert in the opposite direction, i.e. convert from Roman numerals to Arabic Numbers.

#### TDD

Develop the code TDD style, i.e. follow the work flow **Red**, **Green**, **Refactor**.

---

Good luck and have fun!
