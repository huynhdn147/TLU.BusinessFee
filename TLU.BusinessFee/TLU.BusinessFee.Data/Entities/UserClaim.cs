using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Data.Entities
{
   public class UserClaim
    {
        public string ClaimID { set; get; }
        public string MaNhanVien { set; get; } 
        public string ClaimType { set; get; }
        public string ClaimValue { set; get; }
        public TaiKhoan taiKhoans { set; get; }
    
    }
}
