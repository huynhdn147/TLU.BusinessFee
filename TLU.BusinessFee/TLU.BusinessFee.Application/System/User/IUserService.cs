using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TLU.BusinessFee.Application.System.User
{
    public interface IUserService
    {
        Task<bool> Authencate(LoginRequest request);
        Task<bool> Register(RegisterRequest request);
    }
}
