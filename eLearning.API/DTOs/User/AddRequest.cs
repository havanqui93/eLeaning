using System;
using System.ComponentModel.DataAnnotations;

namespace eLearning.API.DTOs.User
{
	public class AddRequest
	{
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        [Required]
        public string Email { get; set; }
    }
}

