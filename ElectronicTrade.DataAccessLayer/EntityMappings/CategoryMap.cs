using ElectronicTrade.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.DataAccessLayer.EntityMappings
{
    class CategoryMap: EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            this.ToTable("Categories", "ETrade");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.Id).HasColumnOrder(0);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.Name).HasColumnName("Name");
            this.Property(x => x.Name).HasColumnOrder(1);
            this.Property(x => x.Name).IsRequired();
            this.Property(x => x.Name).HasMaxLength(25);

            this.Property(x => x.Description).HasColumnName("Description");
            this.Property(x => x.Description).HasColumnOrder(2);
            this.Property(x => x.Description).IsRequired();
            this.Property(x => x.Description).HasMaxLength(125);

            this.Property(x => x.ActionName).HasColumnName("ActionName");
            this.Property(x => x.ActionName).HasColumnOrder(3);
            this.Property(x => x.ActionName).IsRequired();
            this.Property(x => x.ActionName).HasMaxLength(25);

            this.Property(x => x.ControllerName).HasColumnName("ControllerName");
            this.Property(x => x.ControllerName).HasColumnOrder(4);
            this.Property(x => x.ControllerName).IsRequired();
            this.Property(x => x.ControllerName).HasMaxLength(25);

            this.Property(x => x.QueryStrings).HasColumnName("QueryStrings");
            this.Property(x => x.QueryStrings).HasColumnOrder(5);
            this.Property(x => x.QueryStrings).IsOptional();
            this.Property(x => x.QueryStrings).HasMaxLength(25);

            this.Property(x => x.OrderNumber).HasColumnName("OrderNumber");
            this.Property(x => x.OrderNumber).HasColumnOrder(6);
            this.Property(x => x.OrderNumber).IsRequired();

            this.Property(x => x.ParentCategory_Id).HasColumnName("ParentCategory_Id");
            this.Property(x => x.ParentCategory_Id).HasColumnOrder(7);
            this.Property(x => x.ParentCategory_Id).IsOptional();

            this.Property(x => x.UserBy).HasColumnName("UserBy");
            this.Property(x => x.UserBy).HasColumnOrder(8);
            this.Property(x => x.UserBy).IsRequired();
            this.Property(x => x.UserBy).HasMaxLength(25);

            this.Property(x => x.AddedDate).HasColumnName("AddedDate");
            this.Property(x => x.AddedDate).HasColumnOrder(9);
            this.Property(x => x.AddedDate).IsOptional();
            this.Property(x => x.AddedDate).HasColumnType("datetime2");

            this.Property(x => x.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(x => x.ModifiedDate).HasColumnOrder(10);
            this.Property(x => x.ModifiedDate).IsOptional();

            //Bir Category nin bir parent Category si olabilir.Fakat birden fazla SubCategory si olabilir.
            this.HasOptional(x => x.ParentCategory)
               .WithMany(y => y.Categories)
               .HasForeignKey(x => x.ParentCategory_Id).WillCascadeOnDelete(false);
        }
    }
}
