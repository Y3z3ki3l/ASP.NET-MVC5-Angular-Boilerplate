using System.Data.Entity;
using System.Web.Configuration;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.Migrations;
using Application.Model;


namespace Application.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base(WebConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString, false)
        {
            Configuration.LazyLoadingEnabled = false;
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ApplicationDbContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationRole>().ToTable("AspNetRoles");

            modelBuilder.Entity<ApplicationPermission>()
                .HasMany(p => p.Roles)
                .WithMany(p => p.Permissions);

            //modelBuilder.Entity<Employee>()
            //    .HasOptional(e => e.Address)
            //    .WithOptionalDependent(u => u.Employee);

           
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ApplicationRole> ApplicationRoles { get; set; }
        public DbSet<ApplicationPermission> ApplicationPermissions { get; set; }
        
    }

    public class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

       
    }
}