# Web Application with Swagger - README

This README file provides an overview of a web application built using C# code and Swagger for API documentation. It includes instructions for setting up and running the application, as well as information on using Swagger to explore and test the API endpoints.

## Table of Contents
1. [Introduction](#introduction)
2. [Prerequisites](#prerequisites)
3. [Installation](#installation)
4. [Running the Application](#running-the-application)
5. [Using Swagger](#using-swagger)
6. [Additional Resources](#additional-resources)

## Introduction

This web application is developed using C# programming language and utilizes Swagger, an open-source framework, for API documentation. Swagger provides a user-friendly interface to explore and test the available API endpoints, making it easier to understand and interact with the application.

## Prerequisites

Before running the web application, ensure you have the following prerequisites installed:

- [.NET Core SDK](https://dotnet.microsoft.com/download)
- Code editor (e.g., Visual Studio Code, Visual Studio)

## Installation

1. Clone the repository to your local machine -> https://github.com/astanastya/WebApplication_Swagger.git

## Running the Application

To run the web application, follow these steps:

1. Open VS or Rider
2. Navigate to the folder with repository
3. Add more data in repos\WebApplication_Swagger\WebApplication_Test\DB\Users.json file
ex:[
  {
    "Id": 1,
    "Name": "Anastasiya Astafieva",
    "Email": "asta.nastya@gmail.com",
    "Skype": "anto-nastya",
    "Designation": "Middle AQA Engineer",
    "Department": "Department"
  },
  {
    "Id": 2,
    "Name": "New User",
    "Email": "user@gmail.com",
    "Skype": "user",
    "Designation": "Middle AQA Engineer",
    "Department": "Department"
  }
]

4. Open WebApplication_Swagger.sln
5. Correct path in UserRepository.cs file where is located you Users.Json.
  for ex:
  public static string _jsonPath = "C:\\Users\\aastafieva\\source\\repos\\WebApplication_Swagger\\WebApplication_Test\\DB\\Users.json";

7. Run WebApplication_test from the VS
8. The application will now be running locally. You can access it by navigating to `http://localhost:7017` in your web browser, if not opened from VS.

## Using Swagger

Swagger provides a convenient way to explore and interact with the API endpoints of the web application. To access the Swagger UI, follow these steps:

1. Open your web browser.

2. Navigate to `http://localhost:7017/swagger`.

3. The Swagger UI will be displayed, showing a list of available API endpoints, request/response models, and other documentation.

4. Click on an endpoint to expand it and view details such as HTTP methods, request parameters, and response formats.

5. Use the Swagger UI to test the API endpoints by providing input values and executing requests directly from the interface.

6. Feel free to explore and familiarize yourself with the available endpoints and their functionalities.

## Additional Resources

For more information on C# development and Swagger, refer to the following resources:

- [C# Programming Guide](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/)
- [Swagger Documentation](https://swagger.io/docs/)
- [Swagger GitHub Repository](https://github.com/swagger-api/swagger-ui)

That's it! You should now have a basic understanding of the web application built using C# code and Swagger. Feel free to customize and enhance the application based on your specific requirements.
