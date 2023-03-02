using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatFinder.Client.Entities
{
	class Announcment
	{
		private int _id;

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}
		private int _flatid;

		public int FlatId
		{
			get { return _flatid; }
			set { _flatid = value; }
		}
		private decimal _price;

		public decimal Price
		{
			get { return _price; }
			set { _price = value; }
		}
		private int _sessionindomainid;

		public int SessionInDomainId
		{
			get { return _sessionindomainid; }
			set { _sessionindomainid = value; }
		}
		private string _phonenumber;

		public string PhoneNumber
		{
			get { return _phonenumber; }
			set { _phonenumber = value; }
		}
		private string _announcer;

		public string Announcer
		{
			get { return _announcer; }
			set { _announcer = value; }
		}
		private DateTime _announcedate;

		public DateTime AnnounceDate
		{
			get { return _announcedate; }
			set { _announcedate = value; }
		}
	}
}
