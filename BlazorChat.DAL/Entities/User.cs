using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorChat.DAL.Entities
{
	public class User
	{
		public int Id { get; set; }
		[StringLength(30,MinimumLength =3)]
		public string UserName { get; set; }
		[StringLength (30)]
		public string? FirstName { get; set; }
		[StringLength(30)]
		public string? LastName { get; set; }

		//Navigation property
		public List<Chat> Chats { get; set; }

	}
}
