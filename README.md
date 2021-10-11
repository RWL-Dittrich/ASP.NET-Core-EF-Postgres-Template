# What is this?

This project is a template for ASP.NET Core with Entity Framework running in Docker

The project is optimized for use with Rider. Everything should "just work".
You might have to select Docker-Compose as the launch setting in Rider.

The project should also work with Visual Studio, although I haven't tested this yet.

## Solving possible problems

To get debugging to work with Rider you have to turn off Docker-Compose V2 in your Docker Desktop settings

# Database commands:

When one or more database entries have been added/removed/changed you need to create a migration.
This migration contains the information on how to change the database.

**Run the following command to create a migration:**

```
dotnet ef migrations add "[Migration name]" --project App-Database -s App-Server
```
DONT USE ANY PUNCTUATION OR SPECIAL CHARACTERS IN THE MIGRATION NAME!

**If you want to delete a migration that hasn't been applied yet use the following command:**

```
dotnet ef migrations remove --project RMA-Database -s RMA-Web --force
```

# Authors
* **Robin Dittrich** - *Project creator* - [[Github](https://github.com/RWL-Dittrich)] [[LinkedIn](https://www.linkedin.com/in/robin-dittrich-b43b92195/)]
