# Airport Management System (.NET)

## Project Overview
This project is a complete .NET application for managing airport operations, designed using a layered architecture and object-oriented principles.

It handles core functionalities such as flight management, passenger management, and airport resources.

---

## Objectives
- Apply object-oriented programming concepts
- Design a scalable multi-layer architecture
- Separate concerns between business logic, data access, and presentation
- Build a maintainable and extensible system

---

## Architecture

The project follows a multi-layer (n-tier) architecture:

- AM.UI.Console / AM.UI.Web  
  Presentation layer (user interface)

- AM.Application  
  Application layer (business logic, services)

- AM.Core.Domain  
  Domain layer (entities, models, core logic)

- AM.Infrastructure  
  Data access layer (database, repositories)


---

## Architecture Explanation

- Presentation Layer:
  Handles user interaction (console or web interface)

- Application Layer:
  Contains business rules, services, and use cases

- Domain Layer:
  Core entities and relationships (Plane, Flight, Passenger, etc.)

- Infrastructure Layer:
  Handles database operations and persistence


---

## Domain Model

Main entities:

- Plane
- Flight
- Passenger
- Traveller
- Staff

### Inheritance
- Passenger is a base class
- Traveller and Staff inherit from Passenger

### Relationships
- One Plane → Multiple Flights
- One Flight → One Plane

---

## Features Implemented

- Full domain modeling based on UML
- Multi-layer architecture
- CRUD operations 
- Object instantiation with different constructors
- Navigation properties and relationships
- ToString() override for all entities

---

## Technologies Used

- .NET / .NET Framework
- C#
- Entity Framework 
- SQL Server 

---

## Project Structure

AM.UI.Console / AM.UI.Web  
AM.Application  
AM.Core.Domain  
AM.Infrastructure  

---

## How to Run

1. Open the solution in Visual Studio
2. Configure the database (if applicable)
3. Build the solution
4. Run the application

---

## Notes

This project demonstrates a complete implementation of a layered architecture in .NET with clean separation of concerns.
