﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorChat.BLL.Dtos
{
	public class AddUserToChatRequest
	{
		public int ChatId { get; set; }
		public int UserId { get; set; }
	}
}
