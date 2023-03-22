using BlazorChat.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorChat.DAL.Contracts.Repositories
{
	public interface IUserRepository
	{
		Task<User> GetUserByUsername(string userName);
		Task<string> AddAsync(User user);

	}
}
