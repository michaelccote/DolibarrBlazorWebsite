using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VincentsShop.WASM.Shared.Models;

namespace VincentsShop.WASM.Client.Services
{
    public interface IAuthService
    {
        Task<LoginResponse> Login(LoginModel loginModel);
        Task Logout();
        //Task<RegisterResult> Register(RegisterModel registerModel);
    }
}
