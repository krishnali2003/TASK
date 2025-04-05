# CompanyApiJwt 🚀

This is a RESTful API built using ASP.NET Core that allows you to **Create, Read, Update, and Delete (CRUD)** company data. The API is secured using **JWT authentication**.

---

## 🔐 Authentication

To access the API, you must first log in with:

```json
{
  "username": "admin",
  "password": "password"
}
A JWT token will be returned, which you will use for all other API requests.

📦 Features
✅ JWT-based login
✅ In-memory storage for company records
✅ CRUD operations on company data
✅ Token-protected endpoints
✅ Tested with Postman

🏗️ Setup Instructions
🔧 Prerequisites
.NET SDK 8.0

Visual Studio 2022+ or VS Code

Postman (API testing)

🚀 How to Run
Open the project in Visual Studio

Build the solution: Ctrl + Shift + B

Run the project: F5 or click the Run button

The API will be available at:
https://localhost:7054

🧪 How to Test with Postman
1️⃣ Login and Get Token
Method: POST

URL: https://localhost:7054/api/auth/login

Body (raw JSON):

json
Copy
Edit
{
  "username": "admin",
  "password": "password"
}
Copy the token from the response.

2️⃣ Set Authorization in Postman
Click Authorization tab

Type: Bearer Token

Paste the token you copied

3️⃣ Use These API Endpoints
🔹 Add a Company
Method: POST

URL: https://localhost:7054/api/companies
🔹 Get All Companies
Method: GET

URL: https://localhost:7054/api/companies

🔹 Get Company by Code
Method: GET

URL: https://localhost:7054/api/companies/code

🔹 Update Company
Method: PUT

URL: https://localhost:7054/api/companies/code

🔹 Delete Company
Method: DELETE

URL: https://localhost:7054/api/companies/C101

📂 Folder Structure
pgsql
Copy
Edit
CompanyApiJwt/
│
├── Controllers/
│   ├── AuthController.cs
│   └── CompanyController.cs
│
├── Models/
│   └── Company.cs
│
├── Services/
│   └── JwtService.cs
│
├── Program.cs
├── appsettings.json
└── README.md

✍️ Author
Krishnali Patil
📧 patilkrishnali2003@gmail.com



