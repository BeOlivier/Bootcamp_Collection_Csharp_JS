# DNFS - Salt Stars Day 8

## A. Scenario

You're starting to wonder if this Star Wars thing really was a good idea at all... There have been more arguments and ideas proposed on how to improve the data for the site than it has about your business application. Yesterday in the elevator you found yourself thinking:

> I don't remember what we do to make money here...

Ok - just one more feature, before we close this off. Let's add some information about the planets the hero comes from. That would be both interesting and settle a lot of the arguments in the hallways. You hope ...

## B. What you will be working on today

The [SwAPI](https://swapi.dev/) returns more information about the heroes than we have used. If you take a look at the [response of a hero request](https://swapi.py4e.com/api/people/3/) you can see that we get a link to the home world, a planet, of the hero. This is another form of data aggregation.

Today we're going to add that information in two ways;

1. By showing the name of the home world on the Hero page (hero.cshtml)
1. And, via a link, show some detailed information about the planet on a new page (planet.cshtml). You can decide what information you want to show

To accomplish this we will do mostly things that we have touched already so you have an opportunity to repeat and learn.

## C. Tools and requirements

- Use an IDE to accomplish this lab
- Write tests for the different parts of the solution as you go

## D. Lab instructions

1. Add the name of the home planet to the Hero Page

   1. Add the name and id of the planet in the response that you return from the `GetHero` endpoint in `Salt.Stars.API`.
   1. This means that you will have to call the SwAPI yet again, since the hero response from SwApi only contains the link to a planet (`https://swapi.py4e.com/api/planets/1/` for example)
   1. Add an method `GetPlanet` to the SwAPI Client-class to get the planet information by id and call that endpoint from the `HeroesController`
   1. On the front-end side receive the planet name and id, by adding those properties to the `HeroResponse`
   1. Show the name of the planet on `hero.cshtml` and create a link to a new page `planet.cshtml` using the `id` of the planet

1. Show planet data through a new endpoint in `Salt.Stars.API`
   1. Create a controller `PlanetsController`
   1. Create a `PlanetResponse` model class to hold the data for the response object. The request is not needed as it is just the id in the url
   1. Add an endpoint to get the controller to GET planet data by id
   1. Reuse the method in the SwAPI-client class to get the planet information
   1. Add the information you want to show to the `PlanetResponse` class
   1. Receive the information in the front-end, by creating a `PlanetResponse` class in the `Salt.Stars.Web` project
   1. Show the information on the `planets.cshtml` class
   1. Style the page to look nice

You are done when you can navigate from a Hero to their home world

Extra task would be to:

- Make a list of planets like we have with heroes
- Make a list of heroes on each planet and link to the hero page for each

### Tips

---

Good luck and have fun!
