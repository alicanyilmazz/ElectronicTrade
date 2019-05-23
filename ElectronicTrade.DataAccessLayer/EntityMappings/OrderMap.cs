using ElectronicTrade.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.DataAccessLayer.EntityMappings
{
    class OrderMap: EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            this.ToTable("Orders", "ETrade");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.Id).HasColumnOrder(0);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.Order_Member_Id).HasColumnName("Order_Member_Id");
            this.Property(x => x.Order_Member_Id).HasColumnOrder(1);
            this.Property(x => x.Order_Member_Id).IsRequired();
           
            this.Property(x => x.Order_Address_Id).HasColumnName("Order_Address_Id");
            this.Property(x => x.Order_Address_Id).HasColumnOrder(2);
            this.Property(x => x.Order_Address_Id).IsRequired();

            this.Property(x => x.Number).HasColumnName("Number");
            this.Property(x => x.Number).HasColumnOrder(3);
            this.Property(x => x.Number).IsRequired();
            this.Property(x => x.Number).HasMaxLength(12);

            this.Property(x => x.Status).HasColumnName("Status");
            this.Property(x => x.Status).HasColumnOrder(4);
            this.Property(x => x.Status).IsRequired();
            this.Property(x => x.Status).HasMaxLength(25);

            this.Property(x => x.Description).HasColumnName("Description");
            this.Property(x => x.Description).HasColumnOrder(5);
            this.Property(x => x.Description).IsRequired();
            this.Property(x => x.Description).HasMaxLength(200);

            this.Property(x => x.UserBy).HasColumnName("UserBy");
            this.Property(x => x.UserBy).HasColumnOrder(6);
            this.Property(x => x.UserBy).IsRequired();
            this.Property(x => x.UserBy).HasMaxLength(25);

            this.Property(x => x.AddedDate).HasColumnName("AddedDate");
            this.Property(x => x.AddedDate).HasColumnOrder(7);
            this.Property(x => x.AddedDate).IsOptional();
            this.Property(x => x.AddedDate).HasColumnType("datetime2");

            this.Property(x => x.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(x => x.ModifiedDate).HasColumnOrder(8);
            this.Property(x => x.ModifiedDate).IsOptional();
            this.Property(x => x.ModifiedDate).HasColumnType("datetime2");

            //Bir Order in bir Adresi i olabilir.Bir Adresin birden fazla Order i olabilir.
            this.HasRequired(x => x.address)
                .WithMany(y => y.orders)
                .HasForeignKey(x => x.Order_Address_Id);

            //Bir Order in bir Member i olabilir.Bir Member birden fazla Order i olabilir.
            this.HasRequired(x => x.member)
                .WithMany(y => y.orders)
                .HasForeignKey(x => x.Order_Member_Id).WillCascadeOnDelete(false);
        }
    }
}
