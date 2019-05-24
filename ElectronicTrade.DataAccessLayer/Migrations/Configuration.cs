namespace ElectronicTrade.DataAccessLayer.Migrations
{
    using ElectronicTrade.Entities;
    using System;
    using System.Collections.Generic;
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

    }
}
