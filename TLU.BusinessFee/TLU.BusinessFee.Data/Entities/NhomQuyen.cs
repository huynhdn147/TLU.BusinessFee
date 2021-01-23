using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Data.Entities
{
    public class NhomQuyen
    {
        public string RoleID { set; get; }
        public string RoleName { set; get; }
        public string MoTa { set; get; }
        public List<QuyenTaiKhoan> quyenTaiKhoans { set; get; }
    }
}
