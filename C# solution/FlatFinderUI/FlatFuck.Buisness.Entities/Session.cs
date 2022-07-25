using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FlatFuck.Buisness.Entities
{
	[DataContract]
	class Session
	{
		 
		public int Id { get; set; }
		[DataMember]
		public DateTime SessionDate { get; set; }
		[DataMember]
		public int UserId { get; set; }
	}
}