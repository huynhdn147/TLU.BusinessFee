using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.NhanViens.DTOS;
using TLU.BusinessFee.Application.DTO;

namespace TLU.BusinessFee.Application.Catalog.NhanViens
{
    public class ManagarNhanVienService : IManagerNhanVienService
    {
        public async Task<string> Create(CreateNhanVienRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Delete(string MaNhanVien)
        {
            throw new NotImplementedException();
        }

        public async Task<List<NhanVienViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<PageResult<NhanVienViewModel>> GetAllPaging(GetNhanVienPagingRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<NhanVienViewModel> GetByChucVuID(string MaPhongBan)
        {
            throw new NotImplementedException();
        }

        public async Task<NhanVienViewModel> GetByPhongBanID(string MaPhongBan)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(UpdateNhanVienRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
