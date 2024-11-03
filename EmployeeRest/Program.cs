using EmployeeRest.Config;
using EmployeeRest.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Employee API", Version = "v1", Description = "Employee REST API Service."});
});
builder.Services.AddDbContext<EmployeeDb>(options => {
    options.UseInMemoryDatabase("Employees");
});

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI(c => {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Employee API V1");
    });
}

app.MapGet("/employees", async (EmployeeDb db) => await db.Employee.ToListAsync());
app.MapPost("/employees", async (EmployeeDb db, Employee employee) => {
    await db.Employee.AddAsync(employee);
    await db.SaveChangesAsync();
    return Results.Created($"/employees/{employee.Id}", employee);
});
app.MapGet("/employees/{id}", async (EmployeeDb db, int id) => await db.Employee.FindAsync(id));
// app.MapGet("/employees/{id}", (int id) => EmployeeDb.GetEmployee(id));
// app.MapPost("/employees", (Employee employee) => EmployeeDb.AddEmployee(employee));
// app.MapPut("/employees", (Employee updatedEmployee) => EmployeeDb.UpdateEmployee(updatedEmployee));
// app.MapDelete("/employees/{id}", (int id) => EmployeeDB.DeleteEmployee(id));

app.Run();