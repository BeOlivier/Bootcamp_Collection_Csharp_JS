# Textual DB

## A. Scenario

> Welcome to the team! I'm so happy that you are here, but I'm a bit sad to inform you about our first task. We need to rewrite the GROAN system.

And that's the sound the comes out of the rest of the team-members mouths too. Apparently GROAN is an old system. It's a bit hard to understand what it does because it either means Grump Rickety Old A\*\* Noodle, or Grave Read Order Address Noise... None of them seem likely.

But it is an old file-based system to track addresses. The hard part of it is that the information is spread out into several files.

> What we want to do is to be able to print address labels, based on a search criteria.

Some raises their hand:

> Will this be a console application?

The team leads smiles a wry smile and goes:

> You can bet your last terminal window on that ...

## B. What you will be working on today

Today you will create a Console Application `dotnet new console` that prints addresses to the console (using `Console.WriteLine`). The application can take a parameter to filter the results on last name.

We want you to use collections, arrays and loops to solve this lab. There are other ways, but right now we want to practice these parts.

All the data is supplied in files that you will find in the `./data`-directory of the solution.

The console application will be called like this:

```bash
dotnet run -p GROAN.App ./data -name:ande
```

Which should produce a result like this, printed to the console:

```text
3 addresses found:
====
Mr John Andersson
Street name 1
City 125
1512 POSTAL CODE
COUNTRY
====
Mr John Anderssoun
Street name 1
City 125
1512 POSTAL CODE
COUNTRY
====
Mr John Ander
Street name 1
City 125
1512 POSTAL CODE
COUNTRY
====
```

## C. Solution setup

We have created a skeleton solution for you to help you get started with writing the code and tests for the code.

The data is stored in 4 files:

1. `people.csv` - the names of people
1. `countries.csv` - the countries for the peoples addresses
1. `postalcodes.csv` - the postal codes for the peoples addresses
1. `streets.csv` - the street address, number, city for the peoples addresses.

In all files `PersonId` is the key and can be used to correlate the information to one person.

### Testing

Write unit tests for your method.

## D. Lab instructions

The solution follows a structure like this:

- GROAN.Business - holds all the business logic
- GROAN.Tests - unit tests for the business logic (references GROAN.Business)
- GROAN.App - the console application. (references GROAN.Business)

1. GROAN.App should only
   1. Receive and parse command arguments (there's a little loop that lists them right now)
   1. Pass the arguments on to `GROAN.Business.AddressHandler.PrintAddresses(string directory, string lastNameFilter)`
   1. Print the result of `PrintAddresses` to the console
1. The GROAN.Business library have a single class called `AddressHandler` that holds all the business logic
   1. `PrintAddresses` is the main method that then calls out to the other methods
   1. `ReadAddresses` reads the contents of the files into collections.
      1. You will have to create classes to hold the data for each file and then put each file content into a list.
      1. Then loop over those classes and aggregate a `List<PrintAddress>` that holds all the information that we want to print
      1. Remember to only include the addresses that for the passed in filter.
      1. Check [out this for how](https://docs.microsoft.com/en-us/dotnet/api/system.io.file.readalllines?view=net-5.0) on to read the lines of a text file into an array
   1. `FormatAddresses` takes the addresses and formats it to `List<FormattedAddress>`
   1. Finally the `List<FormattedAddress>` is converted to a single string that is returned from `PrintAddresses`
1. Write unit test for each method
   1. Remember that a unit test doesn't use the file system, but preferably only operate on data
   1. Break out the reading of files to a helper function

---

Good luck and have fun!
