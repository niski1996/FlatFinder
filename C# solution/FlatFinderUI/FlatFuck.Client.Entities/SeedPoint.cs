using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatFinder.Client.Entities
{
	
	class SeedPoint
	{
		private int _id;

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}
		private string _country;

		public string Country
		{
			get { return _country; }
			set { _country = value; }
		}
		private string _city;

		public string City
		{
			get { return _city; }
			set { _city = value; }
		}
		private string _district;

		public string District
		{
			get { return _district; }
			set { _district = value; }
		}
		private string _street;

		public string Street
		{
			get { return _street; }
			set { _street = value; }
		}
		private int? _number;

		public int? Number
		{
			get { return _number; }
			set { _number = value; }
		}
		private string _longitude;

		public string Longitude
		{
			get { return _longitude; }
			set { _longitude = value; }
		}
		private string _latitiude;

		public string Latitiude
		{
			get { return _latitiude; }
			set { _latitiude = value; }
		}

	}
}
