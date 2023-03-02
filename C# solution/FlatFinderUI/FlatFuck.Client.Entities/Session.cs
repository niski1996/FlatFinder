using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FlatFinder.Client.Entities
{
	class Session
	{
		private int _id;

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}
		private DateTime _sessiondate;

		public DateTime SessionDate
		{
			get { return _sessiondate; }
			set { _sessiondate = value; }
		}
		private int _userid;

		public int UserId
		{
			get { return _userid; }
			set { _userid = value; }
		}
	}
}
