namespace ClairGeng.BellSupportSystem.WebApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ClairGeng.BellSupportSystem.WebApp.DomainModels.EFDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ClairGeng.BellSupportSystem.WebApp.DomainModels.EFDbContext";
        }

        protected override void Seed(ClairGeng.BellSupportSystem.WebApp.DomainModels.EFDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
