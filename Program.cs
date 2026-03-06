using DynamicForms.Models;

var builder = WebApplication.CreateBuilder(args);

// Add OpenAPI if needed
builder.Services.AddOpenApi();

var app = builder.Build();

// Serve static frontend files
app.UseDefaultFiles();
app.UseStaticFiles();

// API for dynamic form
app.MapGet("/api/forms/employee-search", () =>
{
    return new FormDefinition
    {
        Title = "Employee Search",
        Fields = new List<FormField>
        {
            new FormField { Name = "empId", Label = "Employee ID", Type = "text" },
            new FormField { Name = "surname", Label = "Surname", Type = "text" }
        }
    };
});

app.MapPost("/api/forms/employee-search", (FormDefinition formData) =>
{
    return Results.Ok(formData);
});

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.Run();
