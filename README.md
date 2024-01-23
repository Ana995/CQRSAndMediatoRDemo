# CQRS and Mediator Demo

This repository contains a demonstration of the Command Query Responsibility Segregation (CQRS) pattern along with the Mediator pattern in a .NET application. The project aims to showcase the implementation of these patterns to provide a clear separation between read and write operations and to reduce dependencies between various components of the application.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

What things you need to install the software and how to install them:

- .NET 5.0 SDK or later
- An IDE like Visual Studio or Visual Studio Code
- SQL Server (or another database if you adjust the connection string accordingly)

### Installing

A step-by-step series of examples that tell you how to get a development environment running:

1. Clone the repository:
   ```bash
   git clone https://github.com/Ana995/CQRSAndMediatoRDemo.git
2. Navigate to the project directory:
   ```bash
   cd CQRSAndMediatoRDemo
3. Restore the dependencies:
   ```bash
   dotnet restore
4. Update the database connection string in appsettings.json to match your local or development database.
5. Run the application:
   ```bash
   dotnet run
6. Built With:
- .NET 5.0 - The web framework used
- Entity Framework Core - ORM for database access
- MediatR - Used to implement the Mediator pattern
7. Authors
Ana Maria Renta - Initial work - Ana995
