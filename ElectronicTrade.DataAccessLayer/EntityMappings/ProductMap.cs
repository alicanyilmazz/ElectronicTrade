using ElectronicTrade.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.DataAccessLayer.EntityMappings
{
    class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            this.ToTable("Products", "ETrade");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.Id).HasColumnOrder(0);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.Product_Category_Id).HasColumnName("Product_Category_Id");
            this.Property(x => x.Product_Category_Id).HasColumnOrder(1);
            this.Property(x => x.Product_Category_Id).IsOptional();

            this.Property(x => x.Name).HasColumnName("Name");
            this.Property(x => x.Name).HasColumnOrder(2);
            this.Property(x => x.Name).IsRequired();
            this.Property(x => x.Name).HasMaxLength(25);

            this.Property(x => x.Description).HasColumnName("Description");
            this.Property(x => x.Description).HasColumnOrder(3);
            this.Property(x => x.Description).IsRequired();
            this.Property(x => x.Description).HasMaxLength(25);

            this.Property(x => x.Price).HasColumnName("Price");
            this.Property(x => x.Price).HasColumnOrder(4);
            this.Property(x => x.Price).IsRequired();
            //this.Property(x => x.Price).HasColumnType("decimal(5,2)");

            this.Property(x => x.StarPoint).HasColumnName("StarPoint");
            this.Property(x => x.StarPoint).HasColumnOrder(5);
            this.Property(x => x.StarPoint).IsRequired();

            this.Property(x => x.StockStatus).HasColumnName("StockStatus");
            this.Property(x => x.StockStatus).HasColumnOrder(6);
            this.Property(x => x.StockStatus).IsRequired();
            this.Property(x => x.StockStatus).HasMaxLength(20);

            this.Property(x => x.UnitInStock).HasColumnName("UnitInStock");
            this.Property(x => x.UnitInStock).HasColumnOrder(7);
            this.Property(x => x.UnitInStock).IsRequired();

            this.Property(x => x.StarGivenMemberCount).HasColumnName("StarGivenMemberCount");
            this.Property(x => x.StarGivenMemberCount).HasColumnOrder(8);
            this.Property(x => x.StarGivenMemberCount).IsRequired();

            this.Property(x => x.Discount).HasColumnName("Discount");
            this.Property(x => x.Discount).HasColumnOrder(9);
            this.Property(x => x.Discount).IsOptional();

            this.Property(x => x.UserBy).HasColumnName("UserBy");
            this.Property(x => x.UserBy).HasColumnOrder(10);
            this.Property(x => x.UserBy).IsRequired();
            this.Property(x => x.UserBy).HasMaxLength(25);

            this.Property(x => x.AddedDate).HasColumnName("AddedDate");
            this.Property(x => x.AddedDate).HasColumnOrder(11);
            this.Property(x => x.AddedDate).IsOptional();
            this.Property(x => x.AddedDate).HasColumnType("datetime2");

            this.Property(x => x.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(x => x.ModifiedDate).HasColumnOrder(12);
            this.Property(x => x.ModifiedDate).IsOptional();
            this.Property(x => x.ModifiedDate).HasColumnType("datetime2");

            //Bir Product in bir Category si vardir.Ama bir Category nin birden fazla Product i olabilir.
            this.HasOptional(x => x.category)
               .WithMany(y => y.products)
               .HasForeignKey(x => x.Product_Category_Id).WillCascadeOnDelete(false);


        }
    }
}
