# DNFS - Salt Stars Day 3

## A. Scenario

The CTO comes rushing down the hall and burst into your mob room. He's out of breath while he gives you the news:

> Cecilia, the CEO, her son built a Star Wars fan site with an API and now, for a reason that only the Force can fathom, she wants us to use that API. ASAP!

He rests his hands on his knees and continues under clenched teeth:

> Can you please just use it and hide it somewhere. But make it proper and test the shit out of that API. I wouldn't mind us finding a bug in the "wünderkid's" work. He's such a menace... joining our board meetings and everything...

You agree and get the URL to the API - <https://swapi.py4e.com/>
Man! This looks proper! The wünderkid knows what he's doing...

## B. What you will be working on today

Today we will hook up the Star Wars API (<https://swapi.py4e.com/>) to our own API, making two endpoints that returns:

- A list of heroes (characters) from the Star Wars universe
- Details about individual characters

In order to do that we need to implement another controller in the `Salt.Stars.API` and a "service" that calls out to the Star Wars API endpoints.

This is a common approach, hiding the implementation logic in a service that our own API then uses. By this we hide the calling of the Star Wars API from our web application, that only need to know about 1 API.

Another common approach is to encapsulate the response to a client in separate class, often we add additional information related to the request, to the actual data. Hence the `HeroesListResponse` class.

## C. Tools and requirements

- Use Visual Studio Code - not Visual Studio Community Edition

## D. Lab instructions

We have left some skeleton code for you, and a bunch of falling tests to guide you through the exercise.

Today we will only work in the `Salt.Stars.API` backend - and we will not display the result until tomorrow.

### Tips

- Be sure to go slow and take break.
- Take some time to use the excellent site at <https://swapi.py4e.com/> to navigate around and get to know the API.
- When the API returns data we often map the JSON returned to a class to return. This is done with the `JsonSerializer.DeserializeAsync<T>` method.
- If you want to see/read the JSON that is returned you can use the following lines of code that will print the result of the asynchronous task:

  ```c#
  var task = client.GetStringAsync(url);
  System.Console.WriteLine(await task);
  ```

---

Good luck and have fun!
