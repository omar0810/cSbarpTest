Welcome to the C# Coding Challenge. Attempt to complete as many as the tasks below as you can, which will range in difficulty. There will be multiple
ways to complete each task.

To get started, build and run the project. You should be greeted with a basic UI in a new window. The buttons in the menu will allow you to call the backend
and test some of your changes. Press the "people" button to get your results.

Pre-requirements:
Make Sure Visual Studio is updated to 16.8
Angular CLI: 9.1.12
node -v v12.0.0
npm -v 6.9.0
.NET 5.0
https://dotnet.microsoft.com/download/dotnet/5.0

Right click the solution and select "Manage Nuget Packages for Solution" and verify Microsoft.AspNetCore.Mvc.NewtonsoftJson version 5.0.3 is installed. Lines 25-26 of
Start.cs should include:
services.AddControllersWithViews().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

1. Add yourself to the list of people returned from the "People" API defined in the CodingChallengeController.

2. Add a "Friends" property to the Persons object that will return a list of Friends that person has.

3. Map some friends for the People data returned:
 - Make personA a friend of personB
 - Make personB a friend of personC
 - Make personC a friend of personA
 - Make personA, personB, and personC a friend of yourself

 4. Write a method that will calculate the persons Age before returning the list of People.

 5. Write a new POST endpoint/API with route named "Insert" that will call a method to insert a new person named "Jack Thompson" with a random DateOfBirth if someone with that name doesn't already exist.

 6. Write an in-memory caching system for the service layer that caches the results of the GetPeople method