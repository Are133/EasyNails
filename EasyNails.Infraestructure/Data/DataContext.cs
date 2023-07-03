using EasyNails.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyNails.Infraestructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) { }
 
        public DbSet<Employee> Employees { get; set; }
    }
}
