using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Data.EF;
using TLU.BusinessFee.Data.Entities;
using System.Linq;

namespace TLU.BusinessFee.Application.System.User
{
    public class UserService : IUserService
    {
        private readonly TLUBusinessFeeDbContext _context;
        public UserService(TLUBusinessFeeDbContext context)
        {
            _context = context;
        }
        public Task<bool> Authencate(LoginRequest request)
        {
            var query = from accout in _context.taiKhoans
                        join userrole in _context.QuyenTaiKhoans
                        on accout.MaNhanVien equals userrole.MaNhanVien
                        select new { accout, userrole };
            var data = _context.taiKhoans.FindAsync(request.MaNhanVien);
            //if 
            return data;
        }

        public Task<bool> Register(RegisterRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
