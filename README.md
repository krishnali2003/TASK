# Company API with JWT Authentication

This is a simple REST API built with C# and ASP.NET Core that features JWT-based authentication and basic CRUD operations for managing company records.

## 🔑 Authentication
To authenticate, use the following credentials:
```json
{
  "username": "admin",
  "password": "password"
}
```
A JWT token will be returned, which you will use for all other API requests.

## 🚀 Features
- ✅ JWT-based login
- ✅ In-memory storage for company records
- ✅ CRUD operations on company data
- ✅ Token-protected endpoints
- ✅ Tested with Postman

## 🛠 Setup Instructions

### 📌 Prerequisites
- .NET SDK 8.0
- Visual Studio 2022+ or VS Code
- Postman (for API testing)

### 📌 How to Run
1. Open the project in Visual Studio.
2. Build the solution: `Ctrl + Shift + B`
3. Run the project: Press `F5` or click the Run button.
4. The API will be available at:
   ```
   https://localhost:7054
   ```

### 📌 How to Test with Postman
1. Send a `POST` request to `https://localhost:7054/authenticate` with the login credentials.
2. Copy the returned JWT token.
3. Include the token in the `Authorization` header as `Bearer <token>` for all other API requests.
4. Test CRUD operations on company records using the appropriate endpoints.

## 📂 API Endpoints
| Method | Endpoint           | Description                    |
|--------|-------------------|--------------------------------|
| POST   | `/authenticate`   | Login to get JWT token        |
| GET    | `/companies`      | Get all company records       |
| GET    | `/companies/{code}` | Get a company by code           |
| POST   | `/companies`      | Create a new company record   |
| PUT    | `/companies/{code}` | Update an existing company    |
| DELETE | `/companies/{code}` | Delete a company record       |

## 📜 License
This project is open-source and available under the MIT License.

---
Made with ❤️ by Krishnali Patil
