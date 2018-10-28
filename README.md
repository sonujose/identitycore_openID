# .NET CORE WEB API WITH EF

Create new dot.net core app
- `dotnet new mvc --auth individual`

- `dotnet build`
- `dotnet restore`
- `dotnet run`

Create Migration
- Run `dotnet build` before performing database migration
- `dotnet ef migrations add "First Migration"`

Update database
- `dotnet ef database update`