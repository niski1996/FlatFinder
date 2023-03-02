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
	class Announcement: EntityBase, IIdentifiableEntity
	{

		[DataMember]
		public int Id { get; set; }
		[DataMember]
		public int FlatId { get; set; }
		[DataMember]
		public decimal Price { get; set; }
		[DataMember]
		public int SessionInDomainId { get; set; }
		[DataMember]
		public string PhoneNumber { get; set; }
		[DataMember]
		public string Announcer { get; set; }
		[DataMember]
		public DateTime AnnounceDate { get; set; }
        public int EntityId
		{
			get { return Id; }
			set { Id = value; }
		}
    }
}
