using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Data.Entities
{
    public class ChiPhiChucVu
    {
        public string MaChucVu { set; get; }
        public string MaChiPhi { set; get; }
        public int SoTienDinhMuc { set; get; }
        public ChucVu ChucVu { set; get; }
        public ChiPhi chiPhi { set; get; }
    }
}
