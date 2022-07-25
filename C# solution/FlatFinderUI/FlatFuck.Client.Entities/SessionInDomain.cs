using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatFuck.Client.Entities
{
	class SessionInDomain
	{
		private int _id;

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}
		private int _sessionid;

		public int SessionId
		{
			get { return _sessionid; }
			set { _sessionid = value; }
		}
		private int _domainid;

		public int DomainId
		{
			get { return _domainid; }
			set { _domainid = value; }
		}
		private int _positive;

		public int Positive
		{
			get { return _positive; }
			set { _positive = value; }
		}
		private int _negative;

		public int Negative
		{
			get { return _negative; }
			set { _negative = value; }
		}
		private int _unknown;

		public int Unknown
		{
			get { return _unknown; }
			set { _unknown = value; }
		}
		private int _repated;

		public int Repated
		{
			get { return _repated; }
			set { _repated = value; }
		}
> 
	}
}
