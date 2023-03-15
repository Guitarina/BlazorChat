using BlazorChat.BLL.Dtos;
using BlazorChat.DAL.Data;
using BlazorChat.DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorChat.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MessagesController : ControllerBase
	{
		private readonly DataContext _dbcontext;
		public MessagesController(DataContext dbcontext)
		{
			_dbcontext = dbcontext;
		}
		[HttpGet]
		public async Task< IActionResult> Get()
		{
			var result =  _dbcontext.Messages.ToList();
			return Ok(result);
		}
		[HttpPost]
		public async Task<IActionResult>CreateMessage(MessageDto message)
		{

			var chat = _dbcontext.Chats.FirstOrDefault(c => c.Id == message.ConversationId);

			if(chat == null)
			{

			}
			return Ok();
		}
	}
}
