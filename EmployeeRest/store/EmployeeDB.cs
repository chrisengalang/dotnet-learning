namespace EmployeeRest.store;

public record Employee {
    public int Id { get; set; }
    public string? Name { get; set; }
}

public class EmployeeDB {
    private static List<Employee> employees = new () {
        new Employee () { Id = 1, Name = "John Doe" },
        new Employee () { Id = 2, Name = "Mary Doe" },
        new Employee () { Id = 3, Name = "James Doe" },
        new Employee () { Id = 4, Name = "Jack Doe" },
        new Employee () { Id = 5, Name = "Jill Doe" }
    };

    public static List<Employee> GetEmployees() {
        return employees;
    }

    public static Employee? GetEmployee(int id) {
        return employees.SingleOrDefault(employee => employee.Id == id);
    }

    public static Employee AddEmployee(Employee employee) {
        employees.Add(employee);
        return employee;
    }

    public static Employee UpdateEmployee(Employee updatedEmployee) {
        employees = employees.Select(employee => {
            if (employee.Id == updatedEmployee.Id) {
                employee.Name = updatedEmployee.Name;
            }

            return employee;
        }).ToList();
        
        return updatedEmployee;
    }

    public static void DeleteEmployee(int id) {
        employees = employees.FindAll(employee => employee.Id != id).ToList();
    }
}