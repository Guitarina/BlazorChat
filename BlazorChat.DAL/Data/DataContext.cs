using BlazorChat.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorChat.DAL.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions options):base(options) 
		{

		}

		//protected override void OnModelCreating(ModelBuilder modelBuilder)
		//{
		//	modelBuilder.Entity<ChatUser>()
		//		.HasKey(cu => new {cu.ChatId, cu.UserId});
		//	base.OnModelCreating(modelBuilder);
		//}

		public DbSet<Message> Messages { get; set; }
		public DbSet<Chat> Chats { get; set; }
		public DbSet<User> Users { get; set; }
		//public DbSet<ChatUser> ChatUsers { get; set; }

	}
}
