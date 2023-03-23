using System.ComponentModel.DataAnnotations;

namespace BlazorChat.BLL.Dtos
{
	public class RegisterRequest
	{
		public string UserName { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public string Password { get; set; }
	}
}