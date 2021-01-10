using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Data.Entities
{
   public class ChucVu
    { 
        public string MaChucVu { set; get; }
        public string TenChucVu { set; get; }
        public List<NhanVienPhongBan> NhanVienPhongBans { set; get; }
 
    }
}
