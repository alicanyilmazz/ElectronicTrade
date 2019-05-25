using ElectronicTrade.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.DataAccessLayer.EntityMappings
{
    class RoleMap: EntityTypeConfiguration<Role>
    {
        public RoleMap()
        {
            this.ToTable("Roles", "ETrade");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.Id).HasColumnOrder(0);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.Name).HasColumnName("Name");
            this.Property(x => x.Name).HasColumnOrder(1);
            this.Property(x => x.Name).IsRequired();
            this.Property(x => x.Name).HasMaxLength(25);

            this.Property(x => x.RoleType).HasColumnName("RoleType");
            this.Property(x => x.Name).HasColumnOrder(2);
            this.Property(x => x.RoleType).HasColumnType("byte");
            //this.Property(x => x.Name).IsRequired();
           
        }
    }
}
