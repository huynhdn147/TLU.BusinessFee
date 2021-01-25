﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TLU.BusinessFee.Application.System.User
{
    public interface IUserService
    {
        Task<string> Authencatee(LoginRequest request);
        Task<int> Register(RegisterRequest request);
    }
}
