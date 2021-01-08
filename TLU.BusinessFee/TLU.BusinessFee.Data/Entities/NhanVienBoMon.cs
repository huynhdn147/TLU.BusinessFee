using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Data.Entities
{
   public class NhanVienBoMon
    {
        public string MaNhanVien { set; get; }
        public string TenNhanVien
        { set; get; }
        public string MaBoMon
        { set; get; }
        public string MaChucVu { set; get; }
        public ChucVu ChucVu { set; get; }
        public BoMon BoMon { set; get; }
    }
}
