# Task Timer
## Sample .NET Core application with an ever-changing scope.

This project hosts an MVC website in .NET Core 5.0, with a LocalDB instance accessed through Entity Framework for data persistence. 

The rough idea behind the project is to record work sessions by time as they occur, each logged to a particular task.  The tasks can be categorized (the default are fun, work, and education) and eventually there would be reporting summarizing the time spent by category or task for any given date range.  Alas, no reporting has been developed yet. 

## Deployment 

For development and testing the build process should be pretty easy as long as NuGet is enabled and Visual Studio is configured for ASP.NET development and includes LocalDB.
Database files are included with one user created in the ASP.NET Membership tables.  (A relic from when the scope included authentication.)  During the build process the .MDF and .LDF files will be copied to the output folder if the source version is newer, otherwise data entered locally will generally persist across sessions but not be managed as part of the source.  

## Comments on Usability

Right now there are minimal interaction options and navigation is practically non-existent.  When I got to the point of sketching out a UI I realized that this application should be a single-page application, but I haven't had enough time to learn Blazor and try that out yet.  
