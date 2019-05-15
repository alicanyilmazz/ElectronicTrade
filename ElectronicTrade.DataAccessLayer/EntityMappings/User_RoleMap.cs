using ElectronicTrade.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.DataAccessLayer.EntityMappings
{
    class User_RoleMap: EntityTypeConfiguration<User_Role>
    {
        public User_RoleMap()
        {
            this.ToTable("User_Roles", "ETrade");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.Id).HasColumnOrder(0);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.User_Id).HasColumnName("User_Id");
            this.Property(x => x.User_Id).HasColumnOrder(1);
            this.Property(x => x.User_Id).IsRequired();

            this.Property(x => x.Role_Id).HasColumnName("Role_Id");
            this.Property(x => x.Role_Id).HasColumnOrder(2);
            this.Property(x => x.Role_Id).IsRequired();

            // User - User_Role Common Table Mant to Many
            this.HasRequired(x => x.user)
              .WithMany(y => y.user_roles)
              .HasForeignKey(x => x.User_Id);

            // Role - User_Role Common Table Mant to Many
            this.HasRequired(x => x.role)
              .WithMany(y => y.user_roles)
              .HasForeignKey(x => x.Role_Id);

        }
    }
}
