using Microsoft.EntityFrameworkCore;
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
            modelBuilder.ApplyConfiguration(new TaiKhoanConfiguration());
            modelBuilder.ApplyConfiguration(new NhomQuyenConfiguration());
            modelBuilder.ApplyConfiguration(new QuyenTaiKhoanConfiguration());
            modelBuilder.ApplyConfiguration(new UserClaimConfiguration());
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
        public DbSet<TaiKhoan> taiKhoans { set; get; }
        public DbSet<UserClaim> UserClaims { set; get; }
        public DbSet<QuyenTaiKhoan> QuyenTaiKhoans { set; get; }
        public DbSet<NhomQuyen> NhomQuyens { set; get; }

    }
}