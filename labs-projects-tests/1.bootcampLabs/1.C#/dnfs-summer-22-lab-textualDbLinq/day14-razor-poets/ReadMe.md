# Textual DB LINQ

## A. Scenario

> Don't tell me... did you rebuild GROAN... But in the old way... without using LINQ?

You can barely hear the team lead through the palm over his face.

He looks up and just gives you a sigh and leaves.

> I guess we're gonna rewrite the whole thing?

After a few minutes of awkward silence you get the team into gear. Let's do this.

## B. What you will be working on today

Ok - we're gonna redo the whole exercise from yesterday but using LINQ instead of loops and if-statements. This is the preferred way of doing things nowadays.

So... today you will create a Console Application `dotnet new console` that prints addresses to the console (using `Console.WriteLine`). The application can take a parameter to filter the results on last name.

## C. Solution setup

We have created a skeleton solution for you to help you get started with writing the code and tests for the code.

As yesterday, the data is stored in 4 files:

1. `people.csv` - the names of people
1. `countries.csv` - the countries for the peoples addresses
1. `postalcodes.csv` - the postal codes for the peoples addresses
1. `streets.csv` - the street address and number for the peoples addresses.

In all files `PersonId` is the key and can be used to correlate the information to one person.

### Testing

Write unit tests for the different methods in your solution.

## D. Lab instructions

Follow the instructions from yesterdays lab, but use LINQ

Good luck and have fun!
