using EasyNails.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

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
        public DbSet<User> Users { get; set; }
        public virtual DbSet<Security> Securities { get; set; }
        #endregion

        #region PrivateMethods

        #endregion

        #region PublicMethods

        #endregion

        #region ProtectedMethods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        #endregion

    }
}
