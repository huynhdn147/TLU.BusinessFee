using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TLU.BusinessFee.Data.Entities;

namespace TLU.BusinessFee.Data.Configuration
{
    public class NhomQuyenConfiguration : IEntityTypeConfiguration<NhomQuyen>
    {
        public void Configure(EntityTypeBuilder<NhomQuyen> builder)
        {
            builder.ToTable("Roles");
            builder.HasKey(x => x.RoleID);
            builder.Property(x => x.RoleID).HasMaxLength(5).IsRequired().IsUnicode(true);
            builder.Property(x => x.RoleName).HasMaxLength(250).IsUnicode().IsRequired(true);
            builder.Property(x => x.MoTa).HasMaxLength(250);

            
        }
    
    }
}
