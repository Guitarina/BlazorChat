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
		public int Id { get; set; }
		public string Body { get; set; }
		//Every message belongs to conversation
		public DateTime SendDate { get; set; }
		public int SenderId { get; set; }
		public int ChatId { get; set; }

	}
}
