using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorChat.BLL.Dtos
{
	public class MessageDto
	{

		public string Body { get; set; }
		//Every message belongs to conversation
		public  int ChatUserId { get; set; }
		public int ConversationId { get; set; }
	}
}
