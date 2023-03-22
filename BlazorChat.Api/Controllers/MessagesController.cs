using BlazorChat.BLL.Dtos;
using BlazorChat.DAL.Data;
using BlazorChat.DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
			var result =  await _dbcontext.Messages
				.Select(message => new MessageDto
				{
					Body= message.Body,
					ChatId= message.ChatId,
					Id= message.Id,
					SendDate=message.DateSend,
					SenderId= message.SenderId,
				}).ToListAsync();
			return Ok(result);
		}
		[HttpPost]
		public async Task<IActionResult>CreateMessage(MessageDto message)
		{

			var chatFromDb = await _dbcontext.Chats.FirstOrDefaultAsync(c => c.Id==message.ChatId);
			var user = await _dbcontext.Users.FirstOrDefaultAsync(u => u.Id==message.SenderId);


			if(chatFromDb == null)
			{
				var chat = new Chat
				{
					//Id = message.ChatId,
					Messages = new List<Message>(),
					Users = new List<User>()
				};


				chat.Users.Add(user);
				chat.Messages.Add(new Message
				{
					Body = message.Body,
					ChatId = chat.Id,
					SenderId = message.SenderId,
					DateSend= DateTime.Now,
				});
				_dbcontext.Chats.Add(chat);
				_dbcontext.SaveChanges();

			}
			else
			{
				_dbcontext.Messages.Add(
					new Message
					{
						Body = message.Body,
						ChatId = message.ChatId,
						SenderId = message.SenderId,
						DateSend = DateTime.Now,
					});
				_dbcontext.SaveChanges();
			}
			
			return Ok();
		}
	}
}
