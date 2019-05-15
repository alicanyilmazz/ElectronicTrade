using ElectronicTrade.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.DataAccessLayer.EntityMappings
{
    class CommentMap: EntityTypeConfiguration<Comment>
    {
        public CommentMap()
        {
            this.ToTable("Comments", "ETrade");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.Id).HasColumnOrder(0);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.Text).HasColumnName("Text");
            this.Property(x => x.Text).HasColumnOrder(1);
            this.Property(x => x.Text).IsRequired();
            this.Property(x => x.Text).HasMaxLength(300);

            this.Property(x => x.UserBy).HasColumnName("UserBy");
            this.Property(x => x.UserBy).HasColumnOrder(2);
            this.Property(x => x.UserBy).IsRequired();
            this.Property(x => x.UserBy).HasMaxLength(25);

            this.Property(x => x.Comment_Member_Id).HasColumnName("Comment_Member_Id");
            this.Property(x => x.Comment_Member_Id).HasColumnOrder(3);
            this.Property(x => x.Comment_Member_Id).IsRequired();

            this.Property(x => x.Comment_Product_Id).HasColumnName("Comment_Product_Id");
            this.Property(x => x.Comment_Product_Id).HasColumnOrder(4);
            this.Property(x => x.Comment_Product_Id).IsRequired();

            this.Property(x => x.AddedDate).HasColumnName("AddedDate");
            this.Property(x => x.AddedDate).HasColumnOrder(5);
            this.Property(x => x.AddedDate).IsRequired();

            this.Property(x => x.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(x => x.ModifiedDate).HasColumnOrder(6);
            this.Property(x => x.ModifiedDate).IsOptional();

            //Bir Comment bir Member 'a aittir.Ama bir Member in birden fazla Comment 'e sahip olabilir.
            this.HasRequired(x => x.member)
               .WithMany(y => y.comments)
               .HasForeignKey(x => x.Comment_Member_Id);

            //Bir Comment bir Product 'a aittir.Ama bir Product in birden fazla Comment 'e sahip olabilir.
            this.HasRequired(x => x.product)
              .WithMany(y => y.comments)
              .HasForeignKey(x => x.Comment_Product_Id);
        }
    }
}
