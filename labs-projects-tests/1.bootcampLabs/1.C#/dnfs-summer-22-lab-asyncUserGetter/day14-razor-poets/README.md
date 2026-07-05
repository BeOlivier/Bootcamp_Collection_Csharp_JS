# Getting users async

## A. Scenario

> Don't tell me... did you rebuild GROAN... But STILL in the old way... without using our API?

The new developer just looks at you in despair. It dawns on you that you have heard something about that she _built_ that API. And that it would make GROAN less of a ... well groan to work with.

> I guess we're gonna rewrite the whole thing?

After a few minutes of awkward silence you get the team into gear.

## B. What you will be working on today

Ok this time around we are going to get the data from an external API rather than reading from files. This feels a bit more modern don't you think.

It will also give us an opportunity to use `async/await` a bit when we call the API.

The functionality of the app should be the same though;

- From the console, print address information
- Pass parameter to filter on last name

## C. Solution setup

We have created a skeleton solution for you to help you get started with writing the code and tests for the code.

- GROAN.Business - holds all the business logic, this is where the API call will be made
- GROAN.Tests - unit tests for the business logic (references GROAN.Business)
- GROAN.App - the console application. (references GROAN.Business)

We will use RandomUser.me as our backend. You can find it at <https://randomuser.me/>
Documentation is simple but enough at <https://randomuser.me/documentation>

Remember that set of users is randomized (hence the name of the API), and will not be the same for each request. But we will use it as a fake-backend and it will work for this little exercise.

### Testing

Write unit tests for the different methods in your solution.

## D. Lab instructions

1. Use `HTTPClient` to make calls to `https://randomuser.me/api/?results=50&inc=name,location,phone,nat` to retrieve 50 random users, with the relevant fields.
1. Write this code in the `GROAN.Business.RandomUserClient` class
1. Print the information as earlier installments of this lab.
1. You can, if you have time over, add other filtering options, like email, country or city.

---

Good luck and have fun!
