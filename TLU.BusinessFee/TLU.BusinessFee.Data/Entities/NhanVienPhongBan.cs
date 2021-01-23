﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Data.Entities
{
   public class NhanVienPhongBan
    {
        public string MaNhanVien { set; get; }
        public string TenNhanVien
        { set; get; }
        public string MaCapBac { set; get; }

        public string MaPhongBan { set; get; }
        public PhongBan PhongBan { set; get; }
        public CapBac CapBac { set; get; }
        public  TaiKhoan TaiKhoan { set; get; }
    }
}
