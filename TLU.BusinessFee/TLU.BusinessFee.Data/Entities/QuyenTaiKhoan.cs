using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Data.Entities
{
    public class QuyenTaiKhoan
    {
        public string MaNhanVien { set; get; } 
        public string RoleID { set; get; }
        public NhomQuyen nhomQuyen { set; get; }
        public TaiKhoan taiKhoan { set; get; }
    }
}
