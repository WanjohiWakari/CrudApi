using Microsoft.EntityFrameworkCore;

namespace CrudApi.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)

        { 
        
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
        

