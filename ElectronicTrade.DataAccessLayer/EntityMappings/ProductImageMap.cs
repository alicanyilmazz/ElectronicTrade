using ElectronicTrade.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.DataAccessLayer.EntityMappings
{
    class ProductImageMap: EntityTypeConfiguration<ProductImage>
    {
        public ProductImageMap()
        {
            this.ToTable("ProductImages", "ETrade");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.Id).HasColumnOrder(0);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.ProductImage_Product_Id).HasColumnName("ProductImage_Product_Id");
            this.Property(x => x.ProductImage_Product_Id).HasColumnOrder(1);
            this.Property(x => x.ProductImage_Product_Id).IsRequired();

            this.Property(x => x.FirstImageName).HasColumnName("FirstImageName");
            this.Property(x => x.FirstImageName).HasColumnOrder(2);
            this.Property(x => x.FirstImageName).IsRequired();
            this.Property(x => x.FirstImageName).HasMaxLength(30);

            this.Property(x => x.SecondImageName).HasColumnName("SecondImageName");
            this.Property(x => x.SecondImageName).HasColumnOrder(3);
            this.Property(x => x.SecondImageName).IsRequired();
            this.Property(x => x.SecondImageName).HasMaxLength(30);

            this.Property(x => x.ThirdImageName).HasColumnName("ThirdImageName");
            this.Property(x => x.ThirdImageName).HasColumnOrder(4);
            this.Property(x => x.ThirdImageName).IsRequired();
            this.Property(x => x.ThirdImageName).HasMaxLength(30);

            this.Property(x => x.FourthImageName).HasColumnName("FourthImageName");
            this.Property(x => x.FourthImageName).HasColumnOrder(5);
            this.Property(x => x.FourthImageName).IsRequired();
            this.Property(x => x.FourthImageName).HasMaxLength(30);

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

            //Bir Product in birden fazla Image 'i olabilir.Fakat bir Image sadece bir Product 'a ait olabilir.
            this.HasRequired(x => x.product)
             .WithMany(y => y.productImages)
             .HasForeignKey(x => x.ProductImage_Product_Id);

        }
    }
}
