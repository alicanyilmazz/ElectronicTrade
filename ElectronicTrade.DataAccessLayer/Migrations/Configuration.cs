namespace ElectronicTrade.DataAccessLayer.Migrations
{
    using ElectronicTrade.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ElectronicTrade.DataAccessLayer.EntityFramework.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;

        }

        protected override void Seed(ElectronicTrade.DataAccessLayer.EntityFramework.DatabaseContext context)
        {
            Localization localization = new Localization()
            {
                
                Culture="aa",
                Text="asdas",
                Name="sefresd"
            };

            context.db_localization.Add(localization);
            context.SaveChanges();
        }

       
        
    }
}
