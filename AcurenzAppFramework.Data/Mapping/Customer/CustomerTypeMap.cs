﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcurenzAppFramework.Data.Mapping
{
    public class CustomerTypeMap : EntityTypeConfiguration<CustomerType>
    {
        public CustomerTypeMap()
        {
            this.ToTable("CustomerType");

            this.HasKey(t => t.CustomerTypeID);
            this.Property(t => t.CustomerTypeID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.DisplayCode).IsRequired().HasMaxLength(50);
            this.Property(t => t.LookupCode).IsRequired().HasMaxLength(50);
            this.Property(t => t.Description).HasMaxLength(150);
            this.Property(t => t.UpdatedBy).IsRequired().HasMaxLength(50);
            this.Property(t => t.CustomerTypeID).HasColumnName("CustomerTypeID");
            this.Property(t => t.DisplayCode).HasColumnName("DisplayCode");
            this.Property(t => t.LookupCode).HasColumnName("LookupCode");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
        }
    }
}
