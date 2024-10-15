# DisasterPredict API Mini Project
### Overview
This project aims to create a scalable and well-organized API for managing DisasterPredict data. The API allows for the creation, retrieval, updating, and deletion of DisasterPredict records. The provided CSV file will be used to populate the database, and Swagger will be utilized for API documentation.

## Endpoints
### 1. POST /disasterpredict
- Description: Add a new DisasterPredict.
- Constraints: Ensure no duplicate names.
- Error Handling: Return an error if a duplicate name is detected.
### 2. GET /disasterpredict
- Description: Get a list of DisasterPredict with filtering and sorting.
- Parameters:
  - type (optional): Filter by DisasterPredict type.
  - sort (optional): Sort by name.
  - sortOrder (optional): Sort order, either asc (ascending) or desc (descending).
### 3. GET /disasterpredict/{disasterpredictId}
- Description: Get DisasterPredict details by ID.
### 4. PUT /disasterpredict/{disasterpredictId}
- Description: Update DisasterPredict details by ID and return the updated data.
### 5. DELETE /disasterpredict/{disasterpredictId}
- Description: Delete a DisasterPredict by ID.

## Project Requirements
### Setup
- Scalability: Ensure the API is scalable and well-organized.
- Database: Use SqlServer for the database, prepare the migration in a way that easy to launch the project
- Authentication: Not required.
### Data
- Database Table: Create a table named DisasterPredicts with the following columns:
  - ID: Unique identifier.
  - Name: Name of the DisasterPredict.
  - Type: Type of the DisasterPredict.
  - Speed: Speed of the DisasterPredict.
  - Shiny: Boolean indicating if the DisasterPredict is shiny.
### CSV File
- File: disasterpredict_data.csv containing several hundred rows of DisasterPredict data.
- Usage: Use this file to populate the database.
### Swagger Specification
Documentation: Access the API documentation via Swagger UI at [http://localhost:7174/swagger](https://localhost:7174/swagger/index.html).
## Guidelines
- CSV File: Use the provided CSV file to populate your database.
- Swagger Specification: Follow the provided Swagger specification to implement the API endpoints.
- Code Quality: Ensure your code is clean, well-organized, and scalable.
## How to Run
- Clone this Repository
- Setup the Database:
  - Ensure your database is running and accessible.
  - Update the connection string in appsettings.json.
- Import CSV Data:
  - Use a script or tool to import the disasterpredict_data.csv into the DisasterPredicts table in your database.
- Run the Application
