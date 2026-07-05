# DNFS - Salt Stars Day 7

## A. Scenario

Another wild argument takes place in the kitchen...You heard it from the parking lot

> Is a long, long, time ago ... not a few weeks back.

> That's what I tell you - Leia is born 1346 in earth time.

> Oh fine - that would make her 6000 YEARS OLD AT THE END OF THE RETURN OF THE JEDI?!

You think to yourself... I can solve this. With code. Let's break out the tests.

## B. What you will be working on today

We have supplied you with tests for every day in the bootcamp so far, but that's not very real life like. Writing code also means writing tests for the code that you write. The easiest and most secure way to write those tests is to write it before you write the actual production code. This approach is called Test-First and is sometimes refereed to as TDD (Test Driven Development). You can read [about it here](https://appliedtechnology.github.io/protips/tdd)

Today we are going to add a new simple feature; calculating the earth year that a hero was born and supply that as an extra property. The thing is - none of that code is written for you. We want you to add it:

- Write tests that verifies that that the `Birth_Year` on the `Salt.Stars.API.Models.Hero` is converted to Earth Years
- Write the tests in a new file called `BBY_To_EarthYears_Tests.cs` in the `Salt.Stars.API.Tests` project
- Create a new property on `Salt.Stars.API.Models.Hero` called EarthBirthYear. Make it read only (only have a `get`)
- Write the tests before you write the production code.

Here are the rules for calculating BBY to Earth Years. (It's a combo of reading up on Wookipedia and Redit and my own reasoning, so these **are** the rules weather you agree with them or not ... ):

- BBY - stands for Years Before Battle of Yavin and is the standard way to measure time in the Galaxy. Battle of Yavin is the year 0. 0ABY.
- ABY - stands for Years After Battle of Yavin
- Birth Years for creatures are given in the the for 199BY to indicate 199 years Before the Battle of Yavin. 10ABY is after the Battle of Yavin
- According to [this insightful post](https://www.quora.com/Approximately-what-Earth-year-did-Star-Wars-take-place-1) ABY0 is 1850 A.D.
- So the rule is pretty simple - 0ABY = 1850. 1BBY = 1849.

## C. Tools and requirements

- Work in Visual Studio today

## D. Lab instructions

- Follow the [3 laws of TDD](https://www.thinktocode.com/2018/02/05/what-is-tdd/)

  - You are not allowed to write any production code unless it is to make a failing unit test pass.
  - You are not allowed to write any more of a unit test than is sufficient to fail; and compilation failures are failures.
  - You are not allowed to write any more production code than is sufficient to pass the one failing unit test.

![Red - Green - Refactor](https://www.thinktocode.com/wp-content/uploads/2018/02/red-green-refactor.png)

- Once you have implemented the feature above, show the `EarthBirthYear` on the Hero page

  - This will be small updates on quite a few places
  - Use tests here too - you can follow our earlier examples

- You are done when the `EarthBirthYear` property is calculated correctly and shown on the Hero page

### Tips

- Here's a few test cases to get you started:

  - `Salt.Stars.API.Models.Hero.Birth_Year = 0ABY` should give `Salt.Stars.API.Models.Hero.EarthBirthYear = 1850 A.C.`
  - `Salt.Stars.API.Models.Hero.Birth_Year = 1BBY` should give `Salt.Stars.API.Models.Hero.EarthBirthYear = 1849 A.C.`
  - `Salt.Stars.API.Models.Hero.Birth_Year = 1ABY` should give `Salt.Stars.API.Models.Hero.EarthBirthYear = 1851 A.C.`
  - `Salt.Stars.API.Models.Hero.Birth_Year = 122ABY` should give `Salt.Stars.API.Models.Hero.EarthBirthYear = 1972 A.C.`
  - `Salt.Stars.API.Models.Hero.Birth_Year = 171ABY` should give `Salt.Stars.API.Models.Hero.EarthBirthYear = 1972 A.C.`
  - `Salt.Stars.API.Models.Hero.Birth_Year = 1849BBY` should give `Salt.Stars.API.Models.Hero.EarthBirthYear = 1 A.C.`
  - `Salt.Stars.API.Models.Hero.Birth_Year = 1850BBY` should give `Salt.Stars.API.Models.Hero.EarthBirthYear = 0 A.C.`
  - `Salt.Stars.API.Models.Hero.Birth_Year = 1851BBY` should give `Salt.Stars.API.Models.Hero.EarthBirthYear = 1 B.C.`

- Feel free to add more test cases. What should happen with an empty string for `Birth_Year` for example?

  - For non-integers (there are examples...) return an empty string.
  - Make test-cases for that.

- Help yourselves by adding these comments to structure the test code

- `Math.Abs()` is a nice little function that returns the absolute value of a number. `1` becomes `1` and `-1` becomes `1`. You might find this useful.
- To check if a string contains a string use `"mystring".Contains("s") // true`
- To check if a string contains any of list of strings use `listOfString.Any(s => "mystring".Contains(s)); // true`. You might find this useful

  ```c#
  // arrange

  // act

  // assert
  ```

---

Good luck and have fun!
