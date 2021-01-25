using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Data.EF;
using TLU.BusinessFee.Data.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TLU.BusinessFee.Application.System.User
{
    public class UserService : IUserService
    {
        private readonly TLUBusinessFeeDbContext _context;
        public UserService(TLUBusinessFeeDbContext context)
        {
            _context = context;
        }
        public async Task<string> Authencatee(LoginRequest request)
        {
            var query = from accout in _context.taiKhoans
                        join userrole in _context.QuyenTaiKhoans
                        on accout.MaNhanVien equals userrole.MaNhanVien
                        select new { accout, userrole };
            var data = await query.Select(x => new UserViewModel
            {
                MaNhanVien = x.accout.MaNhanVien,
                PassWord = x.accout.PassWord,
                UserRole=x.userrole.RoleID
            }).ToListAsync();
            var result = new UserViewModel();
            foreach(var item in data)
            {
                if (item.MaNhanVien == request.MaNhanVien && item.PassWord==request.PassWord)
                     result.UserRole = item.UserRole;
                result.MaNhanVien = item.MaNhanVien;
                result.PassWord = item.PassWord;
            }
            return result.UserRole;
        }

        public Task<int> Register(RegisterRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
