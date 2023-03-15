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
		public int Id { get; set; }
		[MaxLength(500)]
		public string Body { get; set; }

		public DateTime DateSend { get; set; }
		
		//Navigation properties
		public int SenderId { get; set; }
		public User Sender { get; set; }
		public int ChatId { get; set; }
		public Chat Chat { get; set; }

	}
}
