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
                MaCapBac = request.MaChiPhi,
                MaChiPhi = request.MaChucVu,
                SoTienDinhMuc = request.SoTienDinhMuc
            };
            _context.ChiPhiChucVus.Add(ChiPhiChucVus);
            await _context.SaveChangesAsync();
            return ChiPhiChucVus.MaCapBac + ChiPhiChucVus.MaChiPhi;
        }

        public async Task<int> Delete(string MaChiPhi, string MaChucVu)
        {
            var chiPhiChucVu = await _context.ChiPhiChucVus.FindAsync(MaChiPhi, MaChucVu);
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
                MaChiPhi=x.MaCapBac,
                MaChucVu = x.MaChiPhi,
                SoTienDinhMuc=x.SoTienDinhMuc
            }).ToListAsync();
            return data;
        }

        public async Task<DinhMucViewModel> GetByChiPhiID(string MaChiPhi)
        {
            var ChiPhichucvu = await _context.ChiPhiChucVus.FindAsync(MaChiPhi);
            var ChiPhichucvuChucVuViewModel = new DinhMucViewModel()
            {
                MaChiPhi= ChiPhichucvu.MaCapBac,
                MaChucVu = ChiPhichucvu.MaChiPhi,
                SoTienDinhMuc=ChiPhichucvu.SoTienDinhMuc
            };
            return ChiPhichucvuChucVuViewModel;
        }

        public async Task<DinhMucViewModel> GetByChucVuID(string MaChucVu)
        {
            var chucvu = await _context.ChiPhiChucVus.FindAsync(MaChucVu);
            var ChucVuViewModel = new DinhMucViewModel()
            {

                MaChucVu = chucvu.MaChiPhi,
                MaChiPhi=chucvu.MaCapBac,
                SoTienDinhMuc=chucvu.SoTienDinhMuc
            };
            return ChucVuViewModel;
        }

        public async Task<int> Update(UpdateDinhMucRequest request)
        {
            var chucvu = await _context.ChiPhiChucVus.FindAsync(request.MaChucVu,request.MaChiPhi);
            var chucvudf = await _context.ChiPhiChucVus.FirstOrDefaultAsync(x =>  x.MaChiPhi == request.MaChucVu && x.MaCapBac == request.MaChiPhi );
            if (chucvu == null) throw new TLUException("Khong co chuc vu");
            chucvudf.MaChiPhi = request.MaChucVu;
            chucvudf.MaCapBac = request.MaChiPhi;
            chucvudf.SoTienDinhMuc = request.SoTienDinhMuc;

            return await _context.SaveChangesAsync();
        }
    }
}
