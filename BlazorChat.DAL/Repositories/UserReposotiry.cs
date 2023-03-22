using BlazorChat.DAL.Contracts.Repositories;
using BlazorChat.DAL.Data;
using BlazorChat.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorChat.DAL.Repositories
{
	public class UserReposotiry : IUserRepository
	{
		private readonly DataContext _dataContext;

		public UserReposotiry(DataContext dataContext)
		{
			_dataContext = dataContext;
		}
		public async Task<User> GetUserByUsername(string userName)
		{
			return await _dataContext.Users.FirstOrDefaultAsync(x => x.UserName == userName);
		}

		public async Task<string> AddAsync(User user)
		{
			await _dataContext.Users.AddAsync(user);
			await _dataContext.SaveChangesAsync();
			return "Good";
		}
	}
}
