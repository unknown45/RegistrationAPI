## Registration API

### 📌 **Overview**
This application is built using ASP.NET Core for save data from form input.

---

### ⚙️ **Setup Instructions**

1. **Clone the Repository**
    ```bash
    git clone <repository_url>
    cd <repository_folder>
    ```

2. **Configure Database**
    - The SQL script to create the database is provided in the project directory under:
      ```
      SQL Scripts/registrationDB.sql
      ```
    - Please execute this script using your preferred SQL Server management tool (e.g., SQL Server Management Studio or Azure Data Studio).

3. **Update Connection String**
    - Navigate to the `appsettings.json` file in the project.
    - Update the connection string as per your local SQL Server configuration:
      ```json
      "ConnectionStrings": {
        "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=DisasterManagementSystem;Trusted_Connection=True;MultipleActiveResultSets=true"
      }
      ```
    - Replace `YOUR_SERVER_NAME` with your actual SQL Server instance name.

4. **Apply Migrations (If Needed)**
    ```bash
    dotnet ef database update
    ```

5. **Run the Application**
    ```bash
    dotnet run
    ```
    The application will be available at `http://localhost:5000`.

---


---

### ❗ **Troubleshooting**
- Ensure your SQL Server is running and accessible.
- Confirm that the database and tables are created using the provided SQL script.
- If facing issues with migrations, run the following command to remove and recreate migrations:
  ```bash
  dotnet ef migrations remove
  dotnet ef migrations add InitialCreate
  dotnet ef database update
  ```

---


