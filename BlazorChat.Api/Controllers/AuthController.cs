using BlazorChat.BLL.Dtos;
using BlazorChat.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorChat.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private readonly IAuthService _authService;

		public AuthController(IAuthService authService)
		{
			_authService = authService;
		}
		[HttpPost("login")]
		public async Task<IActionResult> Login(LoginRequest request)
		{
			var result =await _authService.Login(request);
			if(result != null)
			{
				return Ok(result);
			}
			return BadRequest("Wrong Credentials");
		}
		[HttpPost("register")]
		public async Task<IActionResult> Register(RegisterRequest request)
		{
			await _authService.Register(request);
			return Ok("ok");
		}
	}
}
