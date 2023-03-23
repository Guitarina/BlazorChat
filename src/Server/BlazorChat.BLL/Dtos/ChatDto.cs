using BlazorChat.DAL.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorChat.BLL.Dtos
{
	public class ChatDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public ChatType ChatType { get; set; }

		public IEnumerable<MessageDto> ChatMessages { get; set; }
		public IEnumerable<UserDto> ChatUsers { get; set; }
	}
}
