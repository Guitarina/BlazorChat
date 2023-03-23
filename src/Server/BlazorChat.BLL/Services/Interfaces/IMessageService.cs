using BlazorChat.BLL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorChat.BLL.Services.Interfaces
{
	public interface IMessageService
	{
		Task<bool> AddAsync(MessageDto message);
		Task<IEnumerable<MessageDto>> GetAsync();

		//Task<bool> DeleteAsync()
	}
}
