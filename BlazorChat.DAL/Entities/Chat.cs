using BlazorChat.DAL.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorChat.DAL.Entities
{
	public class Chat
	{
		public int Id { get; set; }
		public ConversationType ConversationType { get; set; } = ConversationType.Private;
		public string Name { get; set; } = string.Empty;

		//All the messages that belong to this conversation
		public List<Message> Messages { get; set; }

		//private chat has 2 users and group chat might have much more
		public List<User> Users { get; set; }



	}
}
