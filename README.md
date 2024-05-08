# Sleep Tracker WebApi
The Sleep Tracker WebApi is a RESTful API built with .NET Core, designed to handle sleep data for the Sleep Logger application. It provides endpoints for CRUD operations on sleep records and integrates with Swagger for API documentation and testing.

## Features
1. RESTful API endpoints for managing sleep records.
2. Integration with Entity Framework Core for database interactions.
3. Swagger UI for API documentation and testing.

## Technologies Used
1. .NET Core: Backend framework for building Web APIs.
2. Entity Framework Core: ORM for database interactions.
3. Swagger: API documentation and testing tool.

## Installation
1. Clone the repository
2. Open the solution in Visual Studio or your preferred IDE.
3. Configure the database connection in appsettings.json.
4. Run the database migrations to create the necessary tables.
5. Start the Sleep Tracker WebApi server.\
   
## API Endpoints
1. GET /sleep: Retrieve all sleep records.
2. GET /sleep/{id}: Retrieve a specific sleep record by ID.
3. POST /sleep: Create a new sleep record.
4. PUT /sleep/{id}: Update an existing sleep record.
5. DELETE /sleep/{id}: Delete a sleep record by ID.
