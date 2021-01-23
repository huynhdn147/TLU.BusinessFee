using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TLU.BusinessFee.Data.Entities;

namespace TLU.BusinessFee.Data.Configuration
{
    public class UserClaimConfiguration: IEntityTypeConfiguration<UserClaim>
    {
        public void Configure(EntityTypeBuilder<UserClaim> builder)
        {
            builder.ToTable("UserClaims");
            builder.HasKey(x => x.ClaimID);
            builder.Property(x => x.ClaimID).HasMaxLength(5).IsUnicode(false);
            builder.Property(x => x.ClaimType).HasMaxLength(250).IsRequired();
            builder.Property(x => x.MaNhanVien).IsUnicode(false).HasMaxLength(5);
            builder.Property(x => x.ClaimValue).HasMaxLength(250);
            //
            builder.HasOne(x => x.taiKhoans).WithMany(pc => pc.userClaims).HasForeignKey(pc => pc.MaNhanVien);
        }
    }
}
