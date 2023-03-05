using Core.Common.Contracts;
using Core.Common.Core;
using System.Runtime.Serialization;

namespace FlatFinder.Business.Entities
{
	[DataContract]
	public class Announcer : EntityBase, IIdentifiableEntity
	{
		[DataMember]
		public int Id { get; set; }
		public string Name { get; set; }
        public bool Broker { get; set; }
		public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int EntityId
		{
			get { return Id; }
			set { Id = value; }
		}
	}
}