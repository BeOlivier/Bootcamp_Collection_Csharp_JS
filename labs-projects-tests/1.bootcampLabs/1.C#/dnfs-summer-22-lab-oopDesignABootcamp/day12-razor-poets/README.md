# OOP Design - Making Salt Employee System (S.E.S.)

## A. Scenario

> Basically ... we haven't found anything that supports us in our needs. And since y'all knows this we thought that you could do it for us.

Did he really say that? Was he serious? You look up to Richard, CEO of Salt, but he doesn't flinch nor looks like he was joking.

No - he really wanted you to build an employee management system for Salt. All of it...

Better break out the pens and start to model the classes for this.

## B. What you will be working on today

Today will be a bit different as you will not build a complete system, rather just a model that a system would operate on.
This is a key trait of how object oriented programming applications are written. It is also a skill that takes practices and making a lot of mistakes. That is what we're going to practice today.

You are going to design the object model for this system and then write some code (unit tests are a good candidate for this) to use that code.

## C. Tools and requirements

- Draw on a whiteboard, but use the UML-diagram shapes that we showed in the lecture
- Then write the classes in C#
- You can also use Visual Studio to draw the diagram and turn it into code, if you rather do it in that tool

## D. Lab instructions

Here are the requirements for the system. And just as in real life this is probably not complete or correct. But that is what you will find out by designing the system.

> It is in doing the work we discover the work we need to do
>
> > Woody Zuill, inventor of Mob Programming

- Salt is an organization
  - An organization has an organizational number and a name
- Salt has a number of People associated to it, of different types
  - Salt Employees
  - Salt Contacts
- A Person has a name, personal number, phone number and a list of email addresses
  - An email address is just a string, but also has a property called Current
- Salt Employees are of two types
  - Core are people that work in the core team
  - Consultants are people that has taken the bootcamp and is now working for us
- All Salt Employees has a bank account number where Salary can be paid out to
- Salt Contacts are people that we have had different contacts with:
  - Applicants - people that have applied to the bootcamp but didn't get accepted
  - Bootcampers - people that took the bootcamp and did, or did not, complete it.
    - We need to indicate how completed the bootcamp is
    - Bootcampers have a list of test results
      - A test result has a name of the test, a score (0-100%) and a comment string
  - Alumni - people that has taken the bootcamp, worked for us as consultants and then moved on
  - Clients - our customers
  - Clients has a list of Contracts that work for Salt at the client
    - A client is an organization
    - A client has a contact address
    - A Contract has a start and stop date, an hourly rate and a Consultant
    - This list of contracts can be empty

1. Draw this object on the whiteboard
1. Turn it into C#
1. Write the following tests, by creating some tests data:
   1. Make a Contact list that doesn't include employees
   1. Make a salary list that shows all people that we need to pay salary too, and their bank account
   1. Make list of all our clients and for each show who is working there, or not

### Tips

---

Good luck and have fun!
