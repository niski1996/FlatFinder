using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FlatFuck.Buisness.Entities
{
	[DataContract]
	class SessionInDomain
	{
		[DataMember]
		public int Id { get; set; }
		[DataMember]
		public int SessionId { get; set; }
		[DataMember]
		public int DomainId { get; set; }
		[DataMember]
		public int Positive { get; set; }
		[DataMember]
		public int Negative { get; set; }
		[DataMember]
		public int Unknown { get; set; }
		[DataMember]
		public int Repated { get; set; }
	}
}
