using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.NhanViens.DTOS;
using TLU.BusinessFee.Application.DTO;

namespace TLU.BusinessFee.Application.Catalog.NhanViens
{
    public interface IManagerNhanVienService
    {
        Task<string> Create(CreateNhanVienRequest request);
        Task<int> Update(UpdateNhanVienRequest request);
        Task<int> Delete(string MaNhanVien);
        Task<NhanVienViewModel> GetByPhongBanID(string MaPhongBan);
        Task<NhanVienViewModel> GetByChucVuID(string MaPhongBan);
        Task<List<NhanVienViewModel>> GetAll();
        Task<PageResult<NhanVienViewModel>> GetAllPaging(GetNhanVienPagingRequest request);
    }
}
