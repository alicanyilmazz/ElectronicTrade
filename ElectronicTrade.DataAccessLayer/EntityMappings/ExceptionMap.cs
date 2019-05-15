using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.DataAccessLayer.EntityMappings
{
    class ExceptionMap: EntityTypeConfiguration<ElectronicTrade.Entities.Exception>
    {
        public ExceptionMap()
        {
            this.ToTable("Exceptions", "ETrade");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.Id).HasColumnOrder(0);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.Message).HasColumnName("Message");
            this.Property(x => x.Message).HasColumnOrder(1);
            this.Property(x => x.Message).IsRequired();
            this.Property(x => x.Message).HasMaxLength(200);

            this.Property(x => x.Detail).HasColumnName("Detail");
            this.Property(x => x.Detail).HasColumnOrder(2);
            this.Property(x => x.Detail).IsRequired();
            this.Property(x => x.Detail).HasMaxLength(500);

            this.Property(x => x.UserBy).HasColumnName("UserBy");
            this.Property(x => x.UserBy).HasColumnOrder(3);
            this.Property(x => x.UserBy).IsRequired();
            this.Property(x => x.UserBy).HasMaxLength(25);

            this.Property(x => x.AddedDate).HasColumnName("AddedDate");
            this.Property(x => x.AddedDate).HasColumnOrder(4);
            this.Property(x => x.AddedDate).IsRequired();

            this.Property(x => x.ActionName).HasColumnName("ActionName");
            this.Property(x => x.ActionName).HasColumnOrder(5);
            this.Property(x => x.ActionName).IsRequired();
            this.Property(x => x.ActionName).HasMaxLength(25);

            this.Property(x => x.ControllerName).HasColumnName("ControllerName");
            this.Property(x => x.ControllerName).HasColumnOrder(6);
            this.Property(x => x.ControllerName).IsRequired();
            this.Property(x => x.ControllerName).HasMaxLength(25);
        }
    }
}
