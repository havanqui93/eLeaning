using System;

namespace eLearning.Domain.Entities
{
	public class User : BaseEntity<long>
	{
        public string Email { get; set; }

        public string Password { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string PhoneNumber { get; set; }

		public bool IsActive { get; set; }

		public string? Avatar { get; set; }

		public int AddressId { get; set; }

		public int RoleId { get; set; }
	}
}

