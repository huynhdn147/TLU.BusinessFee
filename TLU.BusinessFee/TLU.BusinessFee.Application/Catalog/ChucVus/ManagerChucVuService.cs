using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.ChucVus;
using TLU.BusinessFee.Application.Catalog.ChucVus.DTOS;
using TLU.BusinessFee.Application.DTO;
using TLU.BusinessFee.Data.EF;
using TLU.BusinessFee.Data.Entities;
using TLU.BusinessFee.Utilities.Exceptions;
using System.Linq;

namespace TLU.BusinessFee.Application.Catalog.ChucVus
{
    public class ManagerChucVuService : IManagerChucVuSerVice
    {
        private readonly TLUBusinessFeeDbContext _context;
         public ManagerChucVuService(TLUBusinessFeeDbContext context)
        {
            _context = context;
        }
        public async Task<string> Create(CreatedChucVuRequest request)
        {
            var chucvu = new ChucVu()
            {
                MaChucVu = request.MaChucVu,
                TenChucVu = request.TenChucVu,

            };
            _context.ChucVus.Add(chucvu);
            await _context.SaveChangesAsync();
            return chucvu.MaChucVu;
        }
        public async Task<int> Update(UpdateChucVuRequest request)
        {
            var chucvu = await _context.ChucVus.FindAsync(request.MaChucVu);
            var chucvudf = await _context.ChucVus.FirstOrDefaultAsync(x => x.MaChucVu == request.MaChucVu);
            if (chucvu == null) throw new TLUException("Khong co chuc vu");
            chucvudf.MaChucVu = request.MaChucVu;
            chucvudf.TenChucVu = request.TenChucVu;

            return await _context.SaveChangesAsync();
        }
        public async Task<int> Delete(string MaChucVu)
        {
            var chucvu = await _context.ChucVus.FindAsync(MaChucVu);
            if (chucvu == null) throw new TLUException("Khong co chuc vu");
            _context.ChucVus.Remove(chucvu);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<ChucVuViewModel>> GetAll()
        {
            var query = from p in _context.ChucVus select p;
            var data = await query.Select(x => new ChucVuViewModel()
            {
                MaChucVu=x.MaChucVu,
                TenChucVu=x.TenChucVu
            }).ToListAsync();
            return data;

        }

        public async Task<PageResult<ChucVuViewModel>> GetAllPaging(GetChucVuPagingRequest request)
        {
            var query = from p in _context.ChucVus select p;
            if (!string.IsNullOrEmpty(request.MaChucVu))
                query = query.Where(x => x.MaChucVu.Contains(request.MaChucVu));
            if (request.MaChucVu.Count() > 0)
            {
                query = query.Where(x => request.MaChucVu.Contains(x.MaChucVu));
            }
            int toTalRow = await query.CountAsync();

            var data = await query.Skip((request.pageIndex - 1) * request.pageSize).Take(request.pageSize).Select(x => new ChucVuViewModel()
            {
                MaChucVu=x.MaChucVu,
                TenChucVu=x.TenChucVu
            }).ToListAsync();
            var pageResult = new PageResult<ChucVuViewModel>()
            {
                TotalRecord = toTalRow,
                Items = data

            };
            return pageResult;
        }

        public async Task<ChucVuViewModel> GetByID(string MaChucVu)
        {
            var chucvu = await _context.ChucVus.FindAsync(MaChucVu);
            var ChucVuViewModel = new ChucVuViewModel()
            {

                MaChucVu=chucvu.MaChucVu,
                TenChucVu=chucvu.TenChucVu
            };
            return ChucVuViewModel;
        }

        
    }
}
