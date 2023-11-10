# Cat API - C# ASP.NET Core

Welcome to the Cat API repository! This ASP.NET Core API provides endpoints to retrieve information about cats and cat breeds. The API is built using C# and Entity Framework and is designed to serve data related to cats, their fun facts, health issues, and breed information. This README will guide you through the API and how to interact with its endpoints.

# Prerequisites

Before you can run the Cat API, ensure that you have the following prerequisites installed:

    .NET SDK - You'll need the .NET SDK to build and run the API.
    Entity Framework Core - Entity Framework Core is used for database operations.

# Installation
Clone this repository to your local machine:

    git clone https://github.com/your-username/cat-api.git

Open the project in your preferred code editor.
Restore NuGet packages if necessary.

# API Endpoints

The API provides the following endpoints to retrieve information about cats and cat breeds:

    GET /api/cats - Retrieve a list of all cats, including their fun facts, health issues, and breed information.
    GET /api/cats/{breedType} - Retrieve cats of a specific breed type.
    GET /api/cats/{breedType}/{breedName} - Retrieve cats of a specific breed type and breed name.

# Running the API

To run the Cat API, follow these steps:

    Ensure that you have the .NET SDK installed.

    In your code editor, open the project and build the API.

    Run the API application.

The API will start, and you can access it at http://localhost:5097.

# Accessing API Endpoints
To retrieve a list of all cats:

    http://localhost:5097/api/cats

To retrieve cats of a specific breed type (replace {breedType} with the desired breed type):

    GET http://localhost:5097/api/cats/{breedType}

To retrieve cats of a specific breed type and breed name (replace {breedType} and {breedName} with the desired breed type and breed name):

    GET http://localhost:5097/api/cats/{breedType}/{breedName}
