# CustomersApp-Backend

CustomersApp-Backend is an ASP.Net Core Web API application for adding and viewing customer details. The details include the customer's first name, last name, email, mobile number, and address.

The application uses an in-memory storage which means the saved customer details will be gone when the app is restarted.

### Prerequisites:

You must have ASP.NET Core Runtime 8.0.3 installed.

### How to run the application:

Navigate to your preferred directory and clone the project.
```
git clone https://github.com/daredev127/CustomersApp-Backend.git
```

Navigate to the the CustomersApp.API project directory.
```
cd CustomersApp-Backend\CustomersApp\CustomersApp.API
```

Start the Web API application.
```
dotnet run --launch-profile https
```

The available APIs can be viewed and tested using the Swagger page.
```
https://localhost:7051/swagger/index.html
```

This project also has a frontend application. The git repository for the frontend application can be accessed in the following URL:
```
https://github.com/daredev127/CustomersApp-Frontend
```