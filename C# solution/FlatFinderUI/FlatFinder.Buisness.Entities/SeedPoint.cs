using Core.Common.Contracts;
using Core.Common.Core;
using System;
using System.Runtime.Serialization;

namespace FlatFinder.Business.Entities
{
	[DataContract]
	public class SeedPoint : EntityBase, IIdentifiableEntity
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
		public int EntityId
		{
			get { return Id; }
			set { Id = value; }
		}

	}
}
