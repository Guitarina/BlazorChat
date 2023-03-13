using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorChat.DAL.Entities
{
	public class ApplicationUser
	{
		[Key]
		public int Id { get; set; }
		[Required, NotNull]
		public string UserName { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; }

		public List<Conversation> Conversations { get; set; }

	}
}
