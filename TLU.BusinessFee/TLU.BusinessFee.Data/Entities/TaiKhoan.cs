using System.Collections.Generic;

namespace TLU.BusinessFee.Data.Entities
{
    public class TaiKhoan
    {
        public string MaNhanVien { set; get; } 
        public string PassWord { set; get; }
        //public string RoleID { set; get; }
        public NhanVienPhongBan NhanVienPhongBan { set; get; }
        public List<QuyenTaiKhoan> QuyenTaiKhoan { set; get; }
        public List<UserClaim> userClaims { set; get; }
    }
}
