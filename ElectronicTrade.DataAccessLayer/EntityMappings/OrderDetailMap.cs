using ElectronicTrade.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.DataAccessLayer.EntityMappings
{
    class OrderDetailMap: EntityTypeConfiguration<OrderDetail>
    {
        public OrderDetailMap()
        {
            this.ToTable("OrderDetails", "ETrade");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.Id).HasColumnOrder(0);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.OrderDetail_Order_Id).HasColumnName("OrderDetail_Order_Id");
            this.Property(x => x.OrderDetail_Order_Id).HasColumnOrder(1);
            this.Property(x => x.OrderDetail_Order_Id).IsRequired();

            this.Property(x => x.OrderDetail_Product_Id).HasColumnName("OrderDetail_Product_Id");
            this.Property(x => x.OrderDetail_Product_Id).HasColumnOrder(2);
            this.Property(x => x.OrderDetail_Product_Id).IsRequired();

            this.Property(x => x.Price).HasColumnName("Price");
            this.Property(x => x.Price).HasColumnOrder(3);
            this.Property(x => x.Price).IsRequired();
            //this.Property(x => x.Price).HasColumnType("decimal(5,2)");

            this.Property(x => x.Quantity).HasColumnName("Quantity");
            this.Property(x => x.Quantity).HasColumnOrder(4);
            this.Property(x => x.Quantity).IsRequired();

            this.Property(x => x.Discount).HasColumnName("Discount");
            this.Property(x => x.Discount).HasColumnOrder(5);
            this.Property(x => x.Discount).IsRequired();

            this.Property(x => x.UserBy).HasColumnName("UserBy");
            this.Property(x => x.UserBy).HasColumnOrder(6);
            this.Property(x => x.UserBy).IsRequired();
            this.Property(x => x.UserBy).HasMaxLength(25);

            this.Property(x => x.AddedDate).HasColumnName("AddedDate");
            this.Property(x => x.AddedDate).HasColumnOrder(7);
            this.Property(x => x.AddedDate).IsRequired();

            this.Property(x => x.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(x => x.ModifiedDate).HasColumnOrder(8);
            this.Property(x => x.ModifiedDate).IsOptional();

            // OrderDetail - Order Many-to-Many Common Table
            this.HasRequired(x => x.order)
               .WithMany(y => y.OrderDetails)
               .HasForeignKey(x => x.OrderDetail_Order_Id);

            // OrderDetail - Product Many-to-Many Common Table
            this.HasRequired(x => x.product)
              .WithMany(y => y.OrderDetails)
              .HasForeignKey(x => x.OrderDetail_Product_Id);




        }
    }
}
