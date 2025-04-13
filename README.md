# ABCD

.NET application.

## Architecture

- App: Application
- Business: Services
- Core: Entities, Interfaces
- Data: Repositories, EF Migrations

## Frameworks

- .NET
- Bootstrap

### Tools

Execte following commands in order to get required dotnet tools (defined in .config\dotnet-tools.json) :

`dotnet tool restore`

`dotnet tool list`

The result should look like this:

```cli
Package Id                         Version      Commands
---------------------------------------------------------------------------
dotnet-ef                          8.0.15       dotnet-ef
```
