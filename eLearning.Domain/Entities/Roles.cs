using System;

namespace eLearning.Domain.Entities
{
	public class Roles : BaseEntity<int>
	{
		public string? RoleName { get; set; }
	}
}

