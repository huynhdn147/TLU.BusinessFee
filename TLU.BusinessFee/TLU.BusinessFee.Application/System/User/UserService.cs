using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Data.Entities;

namespace TLU.BusinessFee.Application.System.User
{
    public class UserService : IUserService
    {
        public UserService(UserManager<TaiKhoan> _userManager, SignInManager<TaiKhoan> _signInManager)
        {

        }
        public Task<bool> Authencate(LoginRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Register(RegisterRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
