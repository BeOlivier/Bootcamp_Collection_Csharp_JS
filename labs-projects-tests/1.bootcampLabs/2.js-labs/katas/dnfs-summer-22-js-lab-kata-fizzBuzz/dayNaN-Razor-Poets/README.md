# Salt Kata Series

## Kata 1 - FizzBuzz

### A. Scenario

Being a software developer involves a lot of logical problem solving and being able to do that in a readable and well structured manner. You should also be able to test your logic to make sure it runs as expected even if you were to refactor your code or make additions to it.

### B. What you will be working on

Today you will be solving the classic FizzBuzz kata. By the end of the lab we want you to:

- Have gained even more Node.js understanding.
- Get even better at unit testing and get comfortable with using the Chai assertion library combined with Mocha.
- Get better at solving problems as a team.

### C. Testing and linting setup

#### Linting

Set up the project to use ESLint with the Salt Linting Config. [Here's](https://github.com/saltsthlm/salt-linting-demo) an instruction repo on how to use linters.

#### Testing

Set up the project to use the _Mocha_ as test runner. [Here's](https://github.com/saltsthlm/salt-testing-demo) instructions on how to use this testing framework.

_In addition_ to using Mocha, in this kata we're using [Chai-assertion library](https://www.chaijs.com/) to do our assertions. It's a popular assertion framework that helps us to write very semantic assertion statments.

Use the [assert](https://www.chaijs.com/guide/styles/#assert)-syntax. (This is very similar to Node.js's standard library, but with additional )

### D. Lab instructions

We're going to do the classic FizzBuzz kata described [here](http://codingdojo.org/kata/FizzBuzz/) and below.

#### TDD

Here's a quick refresher on how we write tests:

- Red

  - Write a trivial test and make sure it fails.

- Green

  - Write the simplest possible implementation to make the test pass.

- Refactor

  - Refactor the implementation until you're satisfied with the code.

- Go back to red
  - Write a new test

#### Problem Description

Imagine the scene. You are eleven years old, and in the five minutes before the end of the lesson, your Maths teacher decides he should make his class more “fun” by introducing a “game”. He explains that he is going to point at each pupil in turn and ask them to say the next number in sequence, starting from one. The “fun” part is that if the number is divisible by three, you instead say “Fizz” and if it is divisible by five you say “Buzz”.

So now your maths teacher is pointing at all of your classmates in turn, and they happily shout “one!”, “two!”, “Fizz!”, “four!”, “Buzz!”… until he very deliberately points at you, fixing you with a steely gaze… time stands still, your mouth dries up, your palms become sweatier and sweatier until you finally manage to croak “Fizz!”. Doom is avoided, and the pointing finger moves on.

So of course in order to avoid embarrassment in front of your whole class, you have to get the full list printed out so you know what to say. Your class has about 33 pupils and he might go round three times before the bell rings for break time. Next maths lesson is on Thursday. Get coding!

#### Technical Requirements

Write a program that, based on an array containing numbers between 1-100, prints the number or, if the number is a multiple of three, prints “Fizz” instead of the number and for the multiples of five prints “Buzz”. For numbers which are multiples of both three and five print “FizzBuzz“.

However, if the elements in the array are of any other value than numbers between 1-100 you should signal to the user **without throwing any errors!** whether the operation was successful or not. This means that if the call has invalid input, _e.g._ with an array including `-4` or `"foo"`, they should get a message back that says there was an error and some indication on what went wrong and how to fix it.

Sample output when input is _valid_

```text
1
2
Fizz
4
Buzz
Fizz
7
8
Fizz
Buzz
11
Fizz
13
14
FizzBuzz
16
17
Fizz
19
Buzz
... etc up to 100
```

Sample output when input is _invalid_

```text
1
2
Bogus ... "Please provide a number. Try again"
4
5
-4  ... "Please provide a positive number. Try again"
100012031411 ... "Please provide a number below 100"

```

#### Done? Challenge yourselves

- A number is fizz if it is divisible by 3 or if it has a 3 in it
- A number is buzz if it is divisible by 5 or if it has a 5 in it
- A number is fizzbuzz if it divisible by 3 and 5 or has 15 in it.

---

Good luck and have fun!
