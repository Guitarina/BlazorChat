using BlazorChat.BLL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorChat.BLL.Services.Interfaces
{
	public interface IChatService
	{
		Task<IEnumerable<ChatDto>> GetAsync();
		Task<bool> AddUserAsync(AddUserToChatRequest request);
	}
}
