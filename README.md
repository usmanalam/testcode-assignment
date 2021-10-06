"#testassignment-sv" 

TelenorTest folder contains a single page web application (TelenorTest.App) in VueJs and an external backend api in ASPNetCore 2.1. 
In order to run the ASPNetCore api you need to install ASPNetCore 2.1 if you do not have it on your computer. You can install AspNetCore 2.1 from 
https://www.microsoft.com/net/download   

#To run the external backend api TelenorTest.ExternalApi please write following commands using CMD in project root directory (e.g. C:\TelenorTest\TelenorTest.ExternalApi) 

* `dotnet restore`
* `dotnet run`

API must be listen on port 5000   

You will see something like this:

Hosting environment: Development
Content root path: C:\TelenorTest\TelenorTest.ExternalApi
Now listening on: http://localhost:5000
Application started. Press Ctrl+C to shut down.


#To run the SPA TelenorTest.App please write following commands using CMD in project root directory (e.g. C:\TelenorTest\TelenorTest.App)

* install dependencies: `npm install`
* run local server (auto reloads changes in browser, url == http://localhost:8080 ): `npm run dev`

You will see something like this:

DONE  Compiled successfully in 19839ms
Your application is running here: http://localhost:8080
