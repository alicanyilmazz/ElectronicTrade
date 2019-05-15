using ElectronicTrade.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.DataAccessLayer.EntityMappings
{
    class UserMap: EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            this.ToTable("Users", "ETrade");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.Id).HasColumnOrder(0);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.Username).HasColumnName("Username");
            this.Property(x => x.Username).HasColumnOrder(1);
            this.Property(x => x.Username).IsRequired();
            this.Property(x => x.Username).HasMaxLength(25);

            this.Property(x => x.Surname).HasColumnName("Surname");
            this.Property(x => x.Surname).HasColumnOrder(2);
            this.Property(x => x.Surname).IsRequired();
            this.Property(x => x.Surname).HasMaxLength(25);

            this.Property(x => x.Password).HasColumnName("Password");
            this.Property(x => x.Password).HasColumnOrder(3);
            this.Property(x => x.Password).IsRequired();
            this.Property(x => x.Password).HasMaxLength(25);
        }
    }
}
