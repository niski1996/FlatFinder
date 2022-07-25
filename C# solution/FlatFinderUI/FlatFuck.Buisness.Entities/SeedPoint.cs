using System;
using System.Runtime.Serialization;

namespace FlatFuck.Buisness.Entities
{
	[DataContract]
	class SeedPoint
	{
		[DataMember]
		public int Id { get; set; }
		[DataMember]
		public string Country { get; set; }
		[DataMember]
		public string City { get; set; }
		[DataMember]
		public string District { get; set; }
		[DataMember]
		public string Street { get; set; }
		[DataMember]
		public int? Number { get; set; }
		[DataMember]
		public string Longitude { get; set; }
		[DataMember]
		public string Latitiude { get; set; }

	}
}
