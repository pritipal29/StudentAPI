# Student Management API

 Features

* CRUD Operations (Create, Read, Update, Delete)
* JWT Authentication (Secure APIs)
* SQL Server (LocalDB)
* Swagger for API testing
* Global Exception Handling Middleware
* Logging using ILogger

##  Technologies Used

* ASP.NET Core Web API (.NET 8)
* Entity Framework Core
* SQL Server LocalDB
* JWT Bearer Authentication

##  How to Run the Project

1. Open the project in Visual Studio
2. Run the following commands in Package Manager Console:
   Add-Migration InitialCreate
   Update-Database
3. Press F5 to run the project
4. Open Swagger:
   [http://localhost:xxxx/swagger](http://localhost:xxxx/swagger)

##  Authentication

* Use `POST /api/auth/login` to generate JWT token
* Click **Authorize** in Swagger
* Enter:
  Bearer YOUR_TOKEN

##  API Endpoints

* GET /api/student → Get all students
* POST /api/student → Add student
* PUT /api/student/{id} → Update student
* DELETE /api/student/{id} → Delete student

##  Additional Features

* Exception Middleware for global error handling
* Logging implemented using ILogger

##  Project Status

✔ Completed with all required features and enhancements
