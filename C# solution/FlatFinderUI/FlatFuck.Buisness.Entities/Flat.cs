using Core.Common.Contracts;
using Core.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FlatFinder.Buisness.Entities
{
	[DataContract]
	class Flat: EntityBase, IIdentifiableEntity
	{
		[DataMember]
		public int Id { get; set; }
		[DataMember]
		public bool ForSale { get; set; }
		[DataMember]
		public string City { get; set; }
		[DataMember]
		public string District { get; set; }
		[DataMember]
		public string Street { get; set; }
		[DataMember]
		public int? Number { get; set; }
		[DataMember]
		public float Area { get; set; }
		[DataMember]
		public int? Rooms { get; set; }
		[DataMember]
		public int Floor { get; set; }
		[DataMember]
		public int SeedPointId { get; set; }
		[DataMember]
		public float Distance { get; set; }
		public int EntityId
		{
			get { return Id; }
			set { Id = value; }
		}

	}
}
