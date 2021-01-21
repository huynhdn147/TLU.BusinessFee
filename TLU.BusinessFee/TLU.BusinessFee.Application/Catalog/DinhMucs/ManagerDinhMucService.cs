using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.ChiPhiChucVus.DTOS;
using System.Linq;
using TLU.BusinessFee.Data.EF;
using TLU.BusinessFee.Data.Entities;
using TLU.BusinessFee.Utilities.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace TLU.BusinessFee.Application.Catalog.ChiPhiChucVus
{
    public class ManagerDinhMucService : IManagerDinhMucService
    {
        private readonly TLUBusinessFeeDbContext _context;
        public ManagerDinhMucService(TLUBusinessFeeDbContext context)
        {
            _context = context;
        }
        public async Task<string> Create(CreatedDinhMucRequest request)
        {
            var ChiPhiChucVus = new ChiPhiChucVu()
            {
                MaCapBac = request.MaCapBac,
                MaChiPhi = request.MaChiPhi,
                SoTienDinhMuc = request.SoTienDinhMuc
            };
            _context.ChiPhiChucVus.Add(ChiPhiChucVus);
            await _context.SaveChangesAsync();
            return ChiPhiChucVus.MaCapBac + ChiPhiChucVus.MaChiPhi;
        }

        public async Task<int> Delete(string MaCapBac, string MaChiPhi)
        {
            var chiPhiChucVu = await _context.ChiPhiChucVus.FindAsync(MaCapBac, MaChiPhi);
           // var chucvu = await _context.ChiPhiChucVus.FindAsync(MaChucVu);
            if (chiPhiChucVu == null ) throw new TLUException("Khong co loai nay");
            _context.ChiPhiChucVus.RemoveRange(chiPhiChucVu);
            return await _context.SaveChangesAsync();
        }
        public async Task<List<DinhMucViewModel>> GetAll()
        {
            var query = from p in _context.ChiPhiChucVus select p;
            var data = await query.Select(x => new DinhMucViewModel()
            {
                MaChiPhi=x.MaChiPhi,
                MaCapBac = x.MaCapBac,
                SoTienDinhMuc=x.SoTienDinhMuc
            }).ToListAsync();
            return data;
        }

        public async Task<List<DinhMucViewModel>> GetByChiPhiID(string MaChiPhi)
        {
            var query = from p in _context.ChiPhiChucVus where p.MaChiPhi == MaChiPhi select p;
            var data = await query.Select(x => new DinhMucViewModel()
            {
                MaChiPhi = x.MaChiPhi,
                MaCapBac = x.MaCapBac,
                SoTienDinhMuc = x.SoTienDinhMuc
            }).ToListAsync();
            return data;
        }

        public async Task<List<DinhMucViewModel>> GetByChucVuID(string MaCapBac)
        {
            var query = from p in _context.ChiPhiChucVus where p.MaCapBac == MaCapBac select p;
            var data = await query.Select(x => new DinhMucViewModel()
            {
                MaChiPhi = x.MaChiPhi,
                MaCapBac = x.MaCapBac,
                SoTienDinhMuc = x.SoTienDinhMuc
            }).ToListAsync();
            return data;
        }

        public async Task<int> Update(UpdateDinhMucRequest request)
        {
            var chucvu = await _context.ChiPhiChucVus.FindAsync(request.MaCapBac,request.MaChiPhi);
            var chucvudf = await _context.ChiPhiChucVus.FirstOrDefaultAsync(x =>  x.MaChiPhi == request.MaCapBac && x.MaCapBac == request.MaChiPhi );
            if (chucvu == null) throw new TLUException("Khong co chuc vu");
            chucvudf.MaChiPhi = request.MaCapBac;
            chucvudf.MaCapBac = request.MaChiPhi;
            chucvudf.SoTienDinhMuc = request.SoTienDinhMuc;

            return await _context.SaveChangesAsync();
        }
    }
}
