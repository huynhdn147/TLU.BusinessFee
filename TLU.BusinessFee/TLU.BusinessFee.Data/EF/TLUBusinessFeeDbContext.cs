using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TLU.BusinessFee.Data.Configuration;
using TLU.BusinessFee.Data.Entities;
using TLU.BusinessFee.Data.Extensions;

namespace TLU.BusinessFee.Data.EF
{
    public class TLUBusinessFeeDbContext : DbContext
    {
        public TLUBusinessFeeDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
      
            modelBuilder.ApplyConfiguration(new CapBacConfiguration());
            modelBuilder.ApplyConfiguration(new PhongBanConfiguration());
            modelBuilder.ApplyConfiguration(new NhanVienPhongBanConfiguration());
            modelBuilder.ApplyConfiguration(new ChiPhiConfiguration());
            modelBuilder.ApplyConfiguration(new ChiPhiChucVuConfiguration());
            // data seeding
            modelBuilder.seed();

            //  base.OnModelCreating(modelBuilder);
        }
        public DbSet<PhongBan> PhongBans { set; get; }
        public DbSet<NhanVienPhongBan> NhanVienPhongs { set; get; }
        public DbSet<CapBac> CapBacs { set; get; }
        public DbSet<AppConfig> AppConfigs { set; get; }
        public DbSet<ChiPhi> ChiPhis { set; get; }
        public DbSet<ChiPhiChucVu> ChiPhiChucVus { set; get; }
        
    }
}