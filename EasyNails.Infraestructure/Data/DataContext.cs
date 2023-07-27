using EasyNails.Core.Entities;
using EasyNails.Infraestructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace EasyNails.Infraestructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) { }
 
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        }
    }
}
