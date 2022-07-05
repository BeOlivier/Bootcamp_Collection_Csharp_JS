### This is my hackday project that i made during my salt-bootcamp

Name inspired by the well-known and loved code-wars website that gave me the space and knowledge to build my language coding skills, but here with a twist. Using movie knowledge!

### Database setup

Ever project has to start with something, so in order to organize the data and create the appopriate class structure (ORM) from it I start by creating a database and populating it.

### Starting the database

- Taken from the database lab from the second day.

Create or 

```bash
docker-compose up -d
```

This will start the database. The first time you run this command it will take about 1-5 minutes. But then it will be lightning fast.

The credentials for the `sa`-account is found in the `docker-compose.yml`-file.

Once the `docker-compose` command has finished you can use Azure Data Studio (should also be installed on your computers) to access the database with those credentials.

### Shutting the database down

Note the `-d` in the command above. This means that the docker container will run in the background. You can see it through the Docker client but other than that it's hidden.

But you want to shut the database down. This can be done through:

```bash
docker stop sql-server-db
```

Note that the database is held in the container so when you shut it down the data is gone.

## D. Lab instructions

The main difference from yesterday is that we're going to list this at the command prompt.

- Create an console application `dotnet new console UserAddressDbEf`
- Read up on how to [parse command line arguments here](https://docs.microsoft.com/en-us/archive/msdn-magazine/2019/march/net-parse-the-command-line-with-system-commandline)
- Create 3 features
  - List all users, without addresses
  - Filter the list of all users by giving the start of the user name, as a parameter
  - List one user, by passing in the id of the user, and show all addresses for that user

Go back to the IT team and demo it. They will ask you to add edit capabilities - if you have time start doing that so that you could change the address.

They will also tell you that you are crazy trying to access the database with raw SQL directly, and ask you to create stored procedures for the use cases above. Update your EF-code to use those stored procedures

---

Good luck and have fun!
