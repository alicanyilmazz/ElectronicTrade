using ElectronicTrade.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.DataAccessLayer.EntityMappings
{
    class LocalizationMap: EntityTypeConfiguration<Localization>
    {
        public LocalizationMap()
        {

            this.ToTable("Localizations", "ETrade");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.Id).HasColumnOrder(0);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.Culture).HasColumnName("Culture");
            this.Property(x => x.Culture).HasColumnOrder(1);
            this.Property(x => x.Culture).IsRequired();
            this.Property(x => x.Culture).HasMaxLength(3);

            this.Property(x => x.Text).HasColumnName("Text");
            this.Property(x => x.Text).HasColumnOrder(2);
            this.Property(x => x.Text).IsRequired();
            this.Property(x => x.Text).HasMaxLength(2000);

            this.Property(x => x.Name).HasColumnName("Name");
            this.Property(x => x.Name).HasColumnOrder(3);
            this.Property(x => x.Name).IsRequired();
            this.Property(x => x.Name).HasMaxLength(50);
        }
    }
}
