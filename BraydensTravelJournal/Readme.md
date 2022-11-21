# TravelJournal

## Name: Brayden Robert

### Theme: Traveller

### Github Link (https://github.com/braydenrobert/WEB315_ASPDOTNET_Assignments_F22)

Description: Favorite places to travel








### Process:

To create new  project 

```bash
 dotnet new webapp -o BraydensTravelJournal

 cd BraydensTravelJournal

 dotnet run

```

add Entity Framework core

```bash

dotnet add package Microsoft.EntityFrameworkCore.SqlServer

dotnet add package Microsoft.EntityFrameworkCore.SQLite

dotnet tool install --global dotnet-ef

dotnet tool install --global dotnet-aspnet-codegenerator --version 6.0.0-preview.1

dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet add Microsoft.EntityFrameworkCore.Tools


```

Add migration 

```bash

dotnet ef migrations add InitialCreate

dotnet ef database update

```
Update migration 

```bash

 cd BraydensTravelJournal

dotnet ef migrations add TimesVisited

dotnet ef migrations add VisitAgain

dotnet ef database update

```
```bash

 cd BraydensTravelJournal

dotnet ef migrations add New_ValidationRules

dotnet ef database update

```