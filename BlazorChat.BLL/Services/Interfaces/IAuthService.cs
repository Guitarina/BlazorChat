using BlazorChat.BLL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorChat.BLL.Services.Interfaces
{
	public interface IAuthService
    {
        Task<string> Login(LoginRequest request);
        Task<string> Register(RegisterRequest request);

    }
}
