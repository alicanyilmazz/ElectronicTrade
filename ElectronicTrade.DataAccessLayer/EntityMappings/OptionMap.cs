﻿using ElectronicTrade.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.DataAccessLayer.EntityMappings
{
    class OptionMap: EntityTypeConfiguration<Options>
    {
        public OptionMap()
        {
            this.ToTable("Options", "ETrade");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.Id).HasColumnOrder(0);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.Name).HasColumnName("Name");
            this.Property(x => x.Name).HasColumnOrder(1);
            this.Property(x => x.Name).IsRequired();
            this.Property(x => x.Name).HasMaxLength(50);

            this.Property(x => x.Value).HasColumnName("Value");
            this.Property(x => x.Value).HasColumnOrder(2);
            this.Property(x => x.Value).IsRequired();
            this.Property(x => x.Value).HasMaxLength(50);
        }
    }
}
