using Core.Common.Contracts;
using Core.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FlatFuck.Buisness.Entities
{
	[DataContract]
	class Session : EntityBase, IIdentifiableEntity, IAccountOwnedEntity
	{
		 
		public int Id { get; set; }
		[DataMember]
		public DateTime SessionDate { get; set; }
		[DataMember]
		public int UserId { get; set; }
		[DataMember]
		public int AccountId { get; set; }
		public int EntityId
		{
			get { return Id; }
			set { Id = value; }
		}
		public int OwnerAccountId
		{
			get { return AccountId; }
		}
	}
}