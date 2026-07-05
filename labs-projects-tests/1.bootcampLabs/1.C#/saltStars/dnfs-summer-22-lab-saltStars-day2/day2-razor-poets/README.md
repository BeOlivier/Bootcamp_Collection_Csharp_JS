# DNFS - Salt Stars Day 2

## A. Scenario

> Have to say - didn't think Hans would ever do that.

There's disappointment in the voice of the team lead. He shrugs and take another sip of coffee. He looks really tired.

> Anyway, apparently Hans pulled a commit-and-quit late last night and broke the working version you created last week.

He looks at you with his tired, red eyes and gives a `you probably know what this means`-look.

> What he didn't do was to remove the data - our precious greetings are still there. Can you make sure that we read them from the files instead?

He lobs the coffee paper cup into the dustbin, and walks through the door.

> I'd help you but I just don't have the energy after firing him. All of this due to a skyscraper joke... Poor mr Gruber - he is a trouble soul.

## B. What you will be working on today

Today we will read the greetings from two data-files `politeGreetings.txt` and `impoliteGreetings.txt`. The files contains 6 lines of greeting templates and you will select one at Random (there's a helper method `getRandomGreetingString` that can assist you in the randomness).

The text files will be copied to the same place as the assembly when you build so you can find them in the `data` directory. To find the directory of the assembly you can use the `GreetingFileReader`.

As you can see in the text files there's a placeholder (`{name}`) for where the name should be inserted in the greeting.

You are not totally by yourselves and out in the woods - there are tests to help you forward. As yesterday; run the tests and let them guide you towards how the implementation should be written. You can learn a lot by reading the output from the tests, and the test code itself.

## C. Tools and requirements

- Use Visual Studio Code - not Visual Studio Community Edition
- Much of the work will take place in the terminal today

## D. Lab instructions

Start by running the tests (`dotnet test`) and see how they fail.

The goal of the day is to:

1. implement the `GreetingFileReader.cs` file so that it reads the content of the text files
1. Update the implementation of the `GreetingService` so that it uses the `GreetingFileReader`
1. Make sure that all tests (there are both versions that uses a mock class and a real implementation) passes.
1. Ensure that the entire application works

If you have time over:

1. How does the `data` folder end up next to the compiled assembly? See if you can find this out?
1. The `GreeterService` will probably need two constructors - see if you can do that with `operator overloading` (<= Google this)
1. The way we test randomness now is a bit clunky. Can you come up with a better way? Can the random-function be mocked?
1. Who is Hans G?

### Tips

- Work as a mob
- Ensure that everyone follows along
- Be sure to go slow and take break.
- This code uses something called Interfaces which is like a contract that a class has to implement.
  - A class that implements an interface **has** to implement all methods in the interface, but can implement more functionality.
  - Compare `MockGreetingFileReader.cs` and `GreetingFileReader.cs` as an example.
  - The `MockGreetingFileReader.cs` is useful for us to write unit test that we can ensure that the `GreeterService.cs` does its work as it should.

---

Good luck and have fun!
