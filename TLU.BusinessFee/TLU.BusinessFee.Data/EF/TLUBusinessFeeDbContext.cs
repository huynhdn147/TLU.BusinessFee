using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TLU.BusinessFee.Data.Configuration;
using TLU.BusinessFee.Data.Entities;

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
            modelBuilder.ApplyConfiguration(new BoMonConfiguration());
            modelBuilder.ApplyConfiguration(new ChucVuConfiguration());
            modelBuilder.ApplyConfiguration(new PhongBanConfiguration());
            modelBuilder.ApplyConfiguration(new NhanVienPhongBanConfiguration());
            modelBuilder.ApplyConfiguration(new NhanVienBoMonConfiguraiton());


            //  base.OnModelCreating(modelBuilder);
        }
        public DbSet<PhongBan> PhongBans { set; get; }
        public DbSet<NhanVienPhongBan> NhanVienPhongs { set; get; }
        public DbSet<BoMon> BoMons { set; get; }
        public DbSet<NhanVienBoMon> NhanVienBos { set; get; }
        public DbSet<ChucVu> ChucVus { set; get; }
        public DbSet<AppConfig>AppConfigs { set; get; }
    }
}
