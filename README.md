\# CleanArchitectureApi



Detta är ett ASP.NET Core Web API-projekt byggt med Clean Architecture. Projektet använder Entity Framework Core, SQL Server LocalDB, Repository Pattern, CQRS och MediatR.



\## Funktioner



\- Skapa produkter

\- Hämta alla produkter

\- Hämta produkt via id

\- Uppdatera produkt

\- Ta bort produkt

\- Produkter har koppling till kategorier

\- Swagger används för att testa API:et



\## Tekniker



\- ASP.NET Core Web API

\- Entity Framework Core

\- SQL Server LocalDB

\- Clean Architecture

\- Repository Pattern

\- CQRS

\- MediatR

\- Swagger



\## Projektstruktur



```text

CleanArchitectureApi.API

\- Controllers

\- Program.cs

\- appsettings.json



CleanArchitectureApi.Application

\- Commands

\- Queries

\- Handlers

\- Interfaces



CleanArchitectureApi.Domain

\- Entities



CleanArchitectureApi.Infrastructure

\- Data

\- Repositories

\- Migrations

