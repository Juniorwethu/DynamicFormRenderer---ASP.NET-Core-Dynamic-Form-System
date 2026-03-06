This project demonstrates a full-stack dynamic form rendering system using ASP.NET Core and vanilla JavaScript. 
It separates form definition from presentation, allowing forms to be configured via API without changing frontend code.

# What is Built
# Backend (ASP.NET Core Minimal API)
GET /api/forms/employee-search: Returns a JSON form definition with field metadata (name, label, type)
POST /api/forms/employee-search: Accepts form submissions as JSON and returns the submitted data
Uses model classes (FormDefinition, FormField) to structure form data

# Frontend (HTML/JavaScript)
Fetches form definitions dynamically from the API
Renders form fields on-the-fly based on JSON metadata
Submits form data via AJAX POST request
Displays submission results without page reload

# Key Concepts Learned
1. ASP.NET Core Minimal APIs - Building lightweight REST endpoints
2. Dynamic UI Generation - Creating HTML elements programmatically with JavaScript
3. API-Driven Architecture - Separating data/logic (backend) from presentation (frontend)
4. JSON Serialization - Converting C# objects to JSON and vice versa
5. Static File Serving - Hosting frontend files with UseStaticFiles()
6. CORS and Content Types - Handling application/json requests/responses

   # Project Structure

 <img width="298" height="212" alt="image" src="https://github.com/user-attachments/assets/57f11408-81b8-4add-8880-4a211c7afa4e" />

# Technologies Used
1. .NET 10 (ASP.NET Core Minimal API)
2. C# (backend models and endpoints)
3. JavaScript ES6 (async/await, fetch API)
4. HTML5/CSS3 (responsive form UI)

# Use Cases
1. Admin panels with configurable forms
2. Survey/questionnaire systems
3. Data entry applications
4. CMS form builders
