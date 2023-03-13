using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorChat.DAL.Entities
{
	public class Message
	{
		[Key]
		public int Id { get; set; }
		public string Body { get; set; }
		public int SenderId { get; set; }
		[ForeignKey(nameof(ConversationId))]
		//Every message belongs to conversation
		public int ConversationId { get; set; }
		public Conversation Conversation { get; set; }

	}
}
