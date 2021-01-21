using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Application.Catalog.ChiPhiChucVus.DTOS
{
    public class UpdateDinhMucRequest
    {
        public string MaChucVu { set; get; }
        public string MaChiPhi { set; get; }
        public int SoTienDinhMuc { set; get; }
    }
}
