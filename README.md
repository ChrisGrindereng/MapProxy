# MapProxy

###Technologies, Frameworks and Programming Languages:
C#  .NET Core, RESTful Web API, Google Geocode API, JSON, Swagger.ui

###Overview
- A Web Application built as my first experiment with API connections and serving data back out a JSON API.
-This application is purely back-end API. It can take a search term and requests information from googles geocode API. It then takes some of that info and serves it back out as JSON to the user. 
- The application does use Swagger.ui to provide a front facing interface for testing the API.
- This web application is built on the .NET Core Boilerplate. More information below.
###Challenges
- Being my first API application the issue I faced here was learning how to work with JSON APIs and how to properly implement the key. I found many answers to these problems simply by reading through googles own documentation about its API. Google is clear on how to obtain and implement a key into the header of the JSON. 

- The next challenge was de-serializing the JSON into my class structure. This turns out to be simple with the use of a JSON2#C translator. 

###Error Handling and Troubleshooting
- Most of my trouble shooting was done with the use of Postman, an API test application, for testing how to implement the security key. 
- I also used Swagger.ui, a nuget pakage, for providing an interface to test my own API. 




# .NET Core Boilerplate

> note: alpha stages

# How to use

1. Optional: fork to your own account on GitHub
2. clone to your machine
3. `dotnet restore`
4. modify Models/*.cs to create your csharp Models for Entity Framework Core; add any seeded data to the `Seeder` class
5. `dotnet ef migrations add init` - create the initial migrations for the database seeding
6. `dotnet ef database update` - write the migrations to the database
7. `dotnet watch run` - run and watch the file changes;
8. if at any point you install a package through NuGet or change the project.json file - stop the watcher and re-run step 3 and step 7
9. if at any point you change a model, rerun steps 5 and 6
10. open `http://localhost:5000` to view local server
11. to deploy:

    To https://now.sh:
    - `npm install -g now`
    - from project folder: `now`
    - open the url provided

    To https://heroku.com
    - install the heroku CLI (https://devcenter.heroku.com/articles/heroku-command-line)
    - (update and commit all your local git files)
    - `heroku create --buildpack http://github.com/noliar/dotnet-buildpack.git`
    - `git push heroku master`
    - `heroku open`

# Support

1. Please submit issues on GitHub with proper taggings / labels.
2. Reach out to [@matthiasak](https://twitter.com/matthiasak).
