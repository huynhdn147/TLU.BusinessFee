using System;
using System.Collections.Generic;
using System.Text;
using TLU.BusinessFee.Application.DTO;

namespace TLU.BusinessFee.Application.Catalog.ChucVus.DTOS
{
    public class GetChucVuPagingRequest : PagingRequestBase
    {
        public string MaChucVu { set; get; }
    }
}
