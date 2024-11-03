using EmployeeRest.store;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Employee API", Version = "v1", Description = "Employee REST API Service."});
});

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI(c => {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Employee API V1");
    });
}
app.MapGet("/employees", () => EmployeeDB.GetEmployees());
app.MapGet("/employees/{id}", (int id) => EmployeeDB.GetEmployee(id));
app.MapPost("/employees", (Employee employee) => EmployeeDB.AddEmployee(employee));
app.MapPut("/employees", (Employee updatedEmployee) => EmployeeDB.UpdateEmployee(updatedEmployee));
app.MapDelete("/employees/{id}", (int id) => EmployeeDB.DeleteEmployee(id));

app.Run();