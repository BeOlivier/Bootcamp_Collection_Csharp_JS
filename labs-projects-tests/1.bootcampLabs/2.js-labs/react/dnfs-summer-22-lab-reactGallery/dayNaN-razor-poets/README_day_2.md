# Salt React Gallery - Day 2 - Adding new functionality

## A. Scenario

The MVP was a stunning success! The client has come back and wants to expand functionality with the following:
* A splash/start page, i.e. `/`
* A search result page, i.e. `/search?`
* An about page, i.e. `/about`

## B. MVP specifications

### Tech stack specifications

The project _must_:

* Be tested up using Jest as a testrunner, and utilize React Testing Library.
  * At the end of the day at least one more test with snapshot testing.
* Still only have _one_ `index.html` (our 'Single Page') and then use ReactJS as frontend framework.
* Have _multiple_ React components and any imports from one file to another should be made using ES6 import/export syntax (e.g. `import fetcher from './fetcher'`).
  * The components should be written in functional style.
* Utilize React Router for dealing with the different urls/pages.
* Reuse the search box component between the splash page and the search result page.

The project shall also:

* Ensure yesterdays snapshot tests are still working.
* Follow your design cues from yesterday to get a nice coherent feeling
* This goes without saying, but should look good in a professional kind of style.

### MVP requirements

The technical requirements are fairly few, so feel free to add features if you have time. However, we require that the application:

1. The splash page should welcome the user, but also present the search box.

2. When the search is made it should redirect to the search result page, but also provide the search capability on the search result page.

3. Always have a menu to choose between the 3 pages splash (start), search result (the latest or empty) and about.

4. Use a static text from a JSON file which the client can change by him- or herself for the `/about` page content.
 * Think about flickering here on when you want to load this data.

---

GLHF!
