using ElectronicTrade.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.DataAccessLayer.EntityMappings
{
    class AddressMap: EntityTypeConfiguration<Address>
    {
        public AddressMap()
        {
            this.ToTable("Addresses", "ETrade");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.Id).HasColumnOrder(0);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.Address_Member_Id).HasColumnName("Address_Member_Id");
            this.Property(x => x.Address_Member_Id).HasColumnOrder(1);

            this.Property(x => x.Name).HasColumnName("Name");
            this.Property(x => x.Name).HasColumnOrder(2);
            this.Property(x => x.Name).IsRequired();
            this.Property(x => x.Name).HasMaxLength(30);

            this.Property(x => x.Description).HasColumnName("Description");
            this.Property(x => x.Description).HasColumnOrder(3);
            this.Property(x => x.Description).IsRequired();
            this.Property(x => x.Description).HasMaxLength(250);

            this.Property(x => x.UserBy).HasColumnName("UserBy");
            this.Property(x => x.UserBy).HasColumnOrder(4);
            this.Property(x => x.UserBy).IsRequired();
            this.Property(x => x.UserBy).HasMaxLength(25);

            this.Property(x => x.AddedDate).HasColumnName("AddedDate");
            this.Property(x => x.AddedDate).HasColumnOrder(5);
            this.Property(x => x.AddedDate).IsOptional();
            this.Property(x => x.AddedDate).HasColumnType("datetime2");

            this.Property(x => x.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(x => x.ModifiedDate).HasColumnOrder(6);
            this.Property(x => x.ModifiedDate).IsOptional();
            this.Property(x => x.ModifiedDate).HasColumnType("datetime2");

            //Bir Adresin bir Member i vardir.Bir Member in birden fazla Adresi olabilir.
            this.HasRequired(x => x.member)     
                .WithMany(y => y.addresses)
                .HasForeignKey(x => x.Address_Member_Id);





        }
    }
}
