using BlazorChat.BLL.Dtos;
using BlazorChat.DAL.Data;
using BlazorChat.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorChat.Api.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ChatsController : ControllerBase
	{
		private readonly DataContext _dbContext;

		public ChatsController(DataContext dataContext)
		{
			_dbContext = dataContext;
		}
		[HttpGet]
		public async Task<IActionResult> Get()
		{
			var chats = await _dbContext.Chats
				//.Include(x => x.Messages)
				.ToListAsync();

			return Ok(chats);
		}

		[HttpGet("{userId}")]
		public async Task<IActionResult> GetUserChats(int userId)
		{

			
			var chats = await _dbContext.Chats.Where(c => c.Users.Any(u => u.Id == userId))
				.Include(c => c.Messages).Select(chat => new ChatDto
				{
					Id = chat.Id,
					ChatType = chat.ChatType,
					Name = chat.Name,
					ChatMessages = chat.Messages.Select(message => new MessageDto
					{
						Id= message.Id,
						Body = message.Body,
						ChatId = message.ChatId,
						SenderId = message.SenderId,
						SendDate = message.DateSend
					}),
					ChatUsers = chat.Users.Select(user => new UserDto 
					{ 
						Id = user.Id,
						UserName = user.UserName
					})
				}).ToListAsync();


			if (chats == null)
			{
				return NotFound();
			}


			return Ok(chats);
		}
		[HttpPost("AddUser")]
		public async Task<IActionResult> AddUserToChat (AddUserToChatRequest request)
		{
			var user = _dbContext.Users.FirstOrDefault(u => u.Id == request.UserId);

			var chat = _dbContext.Chats.Include(u => u.Users).FirstOrDefault(c => c.Id==request.ChatId);

			if(user != null && chat != null)
			{
				chat.Users.Add(user);
				_dbContext.SaveChanges();
				return Ok();
			}
			return BadRequest();
		}

		[HttpPost]
		public async Task<IActionResult> CreateChat (ChatDto chatDto)
		{
			return Ok();
		}
	}
}
