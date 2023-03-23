﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorChat.BLL.Dtos
{
	public class UserDto
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
	}
}
