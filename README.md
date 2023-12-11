# CoffeeShop
1-Building the project CoffeApi

> dotnet build

2-Preparing migration

> dotnet ef migrations add "InitCoffe" --context sqldbcontext

3-drop database

> dotnet ef database drop -- context sqldbcontext

4-Updating database

> dotnet ef database update --context sqldbcontext
