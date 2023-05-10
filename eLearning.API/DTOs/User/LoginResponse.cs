using System;
namespace eLearning.API.DTOs.User
{
	public class LoginResponse
	{
		public string Token { get; set; }

		public DateTime ExpiredDate { get; set; }
	}
}

