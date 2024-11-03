using EmployeeRest.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeRest.Config;

public class EmployeeDb : DbContext {
    
    public EmployeeDb(DbContextOptions options) : base(options) { }
    public DbSet<Employee> Employee { get; set; }
    
}