using System;

namespace eLearning.Domain.Entities
{
	public class Address : BaseEntity<long>
	{
		public string? Address1 { get; set; }

		public string? Address2 { get; set; }

		public int DistrictId { get; set; }

		public int CityId { get; set; }

		public int CountryId { get; set; }
	}
}

