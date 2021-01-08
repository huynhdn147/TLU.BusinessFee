using System;
using System.Collections.Generic;
using System.Text;

namespace TLU.BusinessFee.Data.Entities
{
    public class BoMon
    {
        public string MaBoMon
        { set; get; }
        public string TenBoMon { set; get; }
        public string MaPhongBan { set; get; }
        public PhongBan PhongBan { set; get; }
        public List<NhanVienBoMon> nhanVienBoMons { set; get; }
    }
}
