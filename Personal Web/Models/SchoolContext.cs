using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace  Personal_Web.Models

{
    public class SchoolContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();


            modelBuilder.Entity<Department>().MapToStoredProcedures();
        }
    }
}