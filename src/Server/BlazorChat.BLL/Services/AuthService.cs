using BlazorChat.BLL.Dtos;
using BlazorChat.BLL.Services.Interfaces;
using BlazorChat.DAL.Contracts.Repositories;
using BlazorChat.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlazorChat.BLL.Services
{
    public class AuthService : IAuthService
	{
		private readonly IUserRepository _userRepository;

		public AuthService(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}
		public async Task<string> Login(LoginRequest request)
		{
			var user = await _userRepository.GetUserByUsername(request.Username);
			if (user == null|| !VerifyPasswordHash(request.Password,user.PasswordHash,user.PasswordSalt))
			{
				return null;
			}
			return "token";
		}


		public async Task<string> Register(RegisterRequest request)
		{
			CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);
			var user = new User
			{
				UserName = request.UserName,
				FirstName = request.FirstName ?? string.Empty,
				LastName = request.LastName ?? string.Empty,
				PasswordHash = passwordHash,
				PasswordSalt = passwordSalt
			};
			return await _userRepository.AddAsync(user);

		}

		private void CreatePasswordHash (string password, out byte[] passwordHash, out byte[] passwordSalt)
		{
			using (var hmac = new HMACSHA512())
			{
				passwordSalt = hmac.Key;
				passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
			}
		}

		private bool VerifyPasswordHash (string password, byte[] passwordHash, byte[] passwordSalt)
		{
			
			using (var hmac = new HMACSHA512(passwordSalt))
			{
				var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

				return computedHash.SequenceEqual(passwordHash);
		
			}
		}
	}
}
