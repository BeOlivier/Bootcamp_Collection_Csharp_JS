# Kanye West Quoter

## A. Scenario

> Yes, you heard me. This new interface just need a wrapper for our front-end-convince. Please ensure that we have proper request and response DTOs coming in and out of the endpoints.

It's amazing how much information that can be expressed with so few words, you think to yourself and move back to the workstation. At least Kanye is here to help you.

## B. What you will be working on

Today we are going to build an API that does two things;

- Get some quotes from Kanye West, using the API at <https://kanye.rest/>
- "Store" comments by calling a fake API <https://jsonplaceholder.typicode.com/>

We will do this by starting from scratch and build out a solution step by step. You will recognize some parts from Salt.Stars... only that you will know what you are doing this time around.

## C. Setup

The setup is minimal - you get to build just about everything about this solution.

We will not write tests, today, but you can verify the code through the Swagger client - or use a tool like [Postman](https://www.postman.com/) (installed on your computers) or [Insomnia](https://insomnia.rest/)

## D. Lab instructions

- Create a solution "Kanye" and add a Web API "Kanye.API" to it
- Remove the `WeatherForecast` stuff
- Create the `GetKanyeQuote` endpoint `/api/quote/`
  - Make it respond to GET-requests only
  - Create a `GetKanyeQuoteResponse` DTO
    - Add the quote in a `Quote` property to the DTO   
    - Add a `ResponseAt` property to the DTO that holds the `Date` the response was created
    - Add an `Id` property that is a unique id `Guid.NewGuid().ToString()`
  - Make a call to <https://api.kanye.rest/> using the HTTPClient
- Create a `AddComments` endpoint at `/api/quote/comment`

  - Make the endpoint respond to POST-requests
  - Create an `AddQuotesCommentRequest` DTO (Data Transfer Object, which is a variant of a command object) that holds:
    - `UserName` - a string
    - `CommentedAt` - a date
    - `Comment` a string
    - `QuoteID` an id for a quote
  - Create an `AddQUotesCommentResponse` DTO
    - Add a `ResponseAt` property to the DTO that holds the `Date` the response was created
    - Add an `CommentId` property that contains the generated id, that is returned in the response.
  - Post to <https://jsonplaceholder.typicode.com/posts> to fake a call to a storage.
    - See this for information on how to accomplish that <https://jsonplaceholder.typicode.com/guide/>

- If you finish those exercises - add the following endpoints:
  - Delete comment - DEL `/api/quote/comment/{id}`
  - Update comment - PUT `/api/quote/comment/{id}`

---

Good luck and have fun!
