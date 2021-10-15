program name: MvcWatches
program author: Ahmed Abdella
program purpose : Build a ASP.Net core Web app (Model-View-Controller)
Date modified: 2021-10-13

2021-10-13

916 Created an MvcWatches app using VS code 2019
917 Made sure the default application ran 
920 Add a Controller and named it HelloWorldController.cs
925 Add a new floder in the Views folder
Then add an Index.cshtml in the that folder
932 ran the aplication to make sure everything is ok 
935 Changed the title, footer, and menu link in the layout file
938 ran the app to see if Title and anchor have changed 
939 Created a Welcome view template Welcome.cshtml.
940 created a loop in the Welcome.cshtml view template that displays "Hello" NumTimes
1000Add a new class to the Models folder and named it Watch.cs
 Add  int Id , string Name , string Color ,  DateTime Model , decimal Price

1022 Installed the Package Microsoft.EntityFrameworkCore.Design
1030 Add a New Scaffolded item to the Controllers



1930 Try to add Add-Migration InitialCreate
but got an error  ): ): ): ): ):
More than one DbContext was found. Specify which one to use. Use the '-Context' parameter for PowerShell commands and the '--context' parameter for dotnet commands.

2130 Sloved the issue by adding Add-Migration InitialCreate -Context MvcWatchesContext to the Package Manager Console (;

2135 Updates the datebase by adding  Update-Database  -Context MvcWatchesContext to the Package Manager Console.


2208 Examined the the generated database connection string
2210 Examined the Migrations/{timestamp}_InitialCreate.cs migration file
2212 Examined the constructor of MoviesController.cs 
2221 Examined the contents of the Details.cshtml 
2226 Add "Microsoft.EntityFrameworkCore.Database.Command": "Information" & ConnectionStrings to appsettings.Development.json










2021-10-14
  
  
1234 Examined the database by opening Sql Server Object Explorer(SSOX) 
1235 Viewed the Design and Data in the dbo.Watch table

1240 Created the SeedData class
1333 Added 10 products to the SeedData class
1505 Examined the two Edit action in the atches controller
1515 Updated the WatchesController Class
1529 Added a search bar by brand Name
1825 Added A search by model of watches to app

1833 Added a new Rating field to Watches app
1843 Added Add-Migration Rating -Context MvcWatchesContext to the Package Manager Console
1845 Updates the datebase by adding  Update-Database  -Context MvcWatchesContext to the Package Manager Console.

1932  Add A Validation to the Name, Model, MadeIn, Price, Rating 
1939 Examined the Details, Delete and DeleteConfirmed methods of the Watches app
2020 change some style like font, color, background color etc...
2030 Add About US page
 

2212 Add some watches images as well ass some css for the images
2332 Created a Github repository to backup my application.

