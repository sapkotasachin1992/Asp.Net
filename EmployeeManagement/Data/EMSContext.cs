using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Data
{
    public class EmsContext : DbContext
    {
        public EmsContext(DbContextOptions<EmsContext> options) : base(options)
        {
        }

        public DbSet<Person> Employees { set; get; } //person is a model name and Employees is a table name that is going to be created
    }

}