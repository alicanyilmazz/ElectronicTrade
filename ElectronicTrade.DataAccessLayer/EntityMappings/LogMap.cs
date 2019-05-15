using ElectronicTrade.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.DataAccessLayer.EntityMappings
{
    class LogMap: EntityTypeConfiguration<Log>
    {
        public LogMap()
        {
            this.ToTable("Logs", "ETrade");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.Id).HasColumnOrder(0);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.Description).HasColumnName("Description");
            this.Property(x => x.Description).HasColumnOrder(1);
            this.Property(x => x.Description).IsRequired();
            this.Property(x => x.Description).HasMaxLength(250);

            this.Property(x => x.Name).HasColumnName("Name");
            this.Property(x => x.Name).HasColumnOrder(2);
            this.Property(x => x.Name).IsRequired();
            this.Property(x => x.Name).HasMaxLength(50);

            this.Property(x => x.AddedDate).HasColumnName("AddedDate");
            this.Property(x => x.AddedDate).HasColumnOrder(3);
            this.Property(x => x.AddedDate).IsRequired();

            this.Property(x => x.IpAddress).HasColumnName("IpAddress");
            this.Property(x => x.IpAddress).HasColumnOrder(4);
            this.Property(x => x.IpAddress).IsOptional();
            this.Property(x => x.IpAddress).HasMaxLength(20);

            this.Property(x => x.UserBy).HasColumnName("UserBy");
            this.Property(x => x.UserBy).HasColumnOrder(5);
            this.Property(x => x.UserBy).IsRequired();
            this.Property(x => x.UserBy).HasMaxLength(25);


        }
    }
}
