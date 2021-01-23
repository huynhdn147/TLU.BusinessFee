using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.ChucVus.DTOS;
using TLU.BusinessFee.Application.DTO;

namespace TLU.BusinessFee.Application.Catalog.ChucVus
{
    public interface IManagerChucVuSerVice
    {
        Task<string> Create(CreatedChucVuRequest request);
        Task<int> Update(UpdateChucVuRequest request);
        Task<int> Delete(string MaChucVu);
        Task<ChucVuViewModel> GetByID(string MaChucVu);
        Task<List<ChucVuViewModel>> GetAll();
        Task<PageResult<ChucVuViewModel>> GetAllPaging(GetChucVuPagingRequest request);

    }
}
