using System;
using System.ComponentModel.DataAnnotations;

namespace eLearning.Domain.Entities
{
	public class BaseEntity<TKey>
	{
		[Key]
		public TKey Id { get; set; }

		public DateTime CreatedDate { get; set; }
	}
}

