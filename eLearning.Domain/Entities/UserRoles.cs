using System;

namespace eLearning.Domain.Entities
{
	public class UserRoles: BaseEntity<int>
	{
		public long UserId { get; set; }

		public long RoleId { get; set; }
	}
}

