using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.NhanViens.DTOS;
using TLU.BusinessFee.Application.DTO;
using TLU.BusinessFee.Data.EF;
using System.Linq;
using TLU.BusinessFee.Data.Entities;
using TLU.BusinessFee.Utilities.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace TLU.BusinessFee.Application.Catalog.NhanViens
{
    public class ManagarNhanVienService : IManagerNhanVienService
    {
        private readonly TLUBusinessFeeDbContext _context;
        public ManagarNhanVienService(TLUBusinessFeeDbContext context)
        {
            _context = context;
        }
        public async Task<string> Create(CreateNhanVienRequest request)
        {
            var nhanvien = new NhanVienPhongBan()
            {
                MaNhanVien = request.MaNhanVien,
                TenNhanVien = request.TenNhanVien,
                MaChucVu = request.MaChucVu,
                MaPhongBan = request.MaPhongBan


            };
            _context.NhanVienPhongs.Add(nhanvien);
            await _context.SaveChangesAsync();
            return nhanvien.MaNhanVien;
        }

        public async Task<int> Delete(string MaNhanVien)
        {
            var nhanvien = await _context.NhanVienPhongs.FindAsync(MaNhanVien);
            if (nhanvien == null) throw new TLUException("Khong co nhan vien");
            _context.NhanVienPhongs.Remove(nhanvien);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<NhanVienViewModel>> GetAll()
        {
            var query = from p in _context.NhanVienPhongs select p;
            var data = await query.Select(x => new NhanVienViewModel()
            {
               MaNhanVien=x.MaNhanVien,
               TenNhanVien=x.TenNhanVien,
               MaChucVu=x.MaChucVu,
               MaPhongBan= x.MaPhongBan
            }).ToListAsync();
            return data;
        }

        public async Task<PageResult<NhanVienViewModel>> GetAllPaging(GetNhanVienPagingRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<List<NhanVienViewModel>> GetAllByChucVuID(string MaChucVu)
        {
            
            var query = from p in _context.NhanVienPhongs join pb in _context.ChucVus 
                        on p.MaChucVu equals pb.MaChucVu
                        where p.MaChucVu == MaChucVu
                        select p
                        ;
            var data = await query.Select(x => new NhanVienViewModel()
            {
                MaNhanVien = x.MaNhanVien,
                TenNhanVien = x.TenNhanVien,
                MaChucVu = x.MaChucVu,
                MaPhongBan = x.MaPhongBan
            }).ToListAsync();
            return data;
        }

        public async Task<List<NhanVienViewModel>> GetAllByPhongBanID(string MaPhongBan)
        {
            var query = from p in _context.NhanVienPhongs
                        join pb in _context.PhongBans
                        on p.MaPhongBan equals pb.MaPhongBan
                        where p.MaPhongBan == MaPhongBan
                        select p
                         ;
            var data = await query.Select(x => new NhanVienViewModel()
            {
                MaNhanVien = x.MaNhanVien,
                TenNhanVien = x.TenNhanVien,
                MaChucVu = x.MaChucVu,
                MaPhongBan = x.MaPhongBan
            }).ToListAsync();
            return data;
        }

        public async Task<int> Update(UpdateNhanVienRequest request)
        {
            var nhanvien = await _context.NhanVienPhongs.FindAsync(request.MaNhanVien);
            var nhanviendf = await _context.NhanVienPhongs.FirstOrDefaultAsync(x => x.MaNhanVien == request.MaNhanVien);
            if (nhanvien == null) throw new TLUException("khong tim thay nhan vien");

            nhanviendf.MaNhanVien = request.MaNhanVien;
            nhanviendf.TenNhanVien = request.TenNhanVien;
            nhanviendf.MaPhongBan = request.MaPhongBan;
            nhanviendf.MaChucVu = request.MaChucVu;
            return await _context.SaveChangesAsync();
        }

        public async Task<NhanVienViewModel> GetByID(string MaNhanVien)
        {
            var query = await _context.NhanVienPhongs.FindAsync(MaNhanVien);
            var nhanvien =  new NhanVienViewModel()
            {
                MaNhanVien = query.MaNhanVien,
                TenNhanVien = query.TenNhanVien,
                MaChucVu = query.MaChucVu,
                MaPhongBan = query.MaPhongBan
            };
            return nhanvien;
        }
    }
}
