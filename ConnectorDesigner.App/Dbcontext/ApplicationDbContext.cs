using ConnectorDesigner.App.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace ConnectorDesigner.App.Dbcontext
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext()
            : base(WebConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString)
        {
            Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ApplicationDbContext>());
        }

        public DbSet<Cable> Cables { get; set; }
        public DbSet<LeftEnd> LeftEnds { get; set; }
        public DbSet<RightEnd> RightEnds { get; set; }
        public DbSet<LeftConnectorType> LeftConnectorTypes { get; set; }
        public DbSet<RightConnectorType> RightConnectorTypes { get; set; }
        public DbSet<ConnectedLeftEnd> ConnectedLeftEnds { get; set; }
        public DbSet<ConnectedRightEnd> ConnectedRightEnds { get; set; }
        public DbSet<File> Files { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LeftConnectorType>()
               .HasOptional(p => p.Image)
               .WithOptionalDependent(p => p.LeftConnectorType);

            modelBuilder.Entity<RightConnectorType>()
              .HasOptional(p => p.Image)
              .WithOptionalDependent(p => p.RightConnectorType);

            base.OnModelCreating(modelBuilder);
        }

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