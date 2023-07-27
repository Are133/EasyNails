using EasyNails.Core.Entities;
using EasyNails.Infraestructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace EasyNails.Infraestructure.Data
{
    public class DataContext : DbContext
    {
        #region Attributes

        #endregion

        #region Builder
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        #endregion


        #region Properties
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Branch> Branches { get; set; }
        #endregion

        #region PrivateMethods

        #endregion

        #region PublicMethods

        #endregion

        #region ProtectedMethods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new BranchConfiguration());
        }
        #endregion

    }
}
