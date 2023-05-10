﻿using System;
using System.ComponentModel.DataAnnotations;

namespace eLearning.API.DTOs.User
{
	public class LoginRequest
	{
		[Required]
		public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;
    }
}

