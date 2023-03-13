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
		public DbSet<Message> Messaged { get; set; }
		public DbSet<Conversation> Conversations { get; set; }
		public DbSet<ApplicationUser> Users { get; set; }

	}
}
