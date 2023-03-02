using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatFinder.Client.Entities
{
	class Flat
	{
		private int _id;

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}
		private bool _forsale;

		public bool ForSale
		{
			get { return _forsale; }
			set { _forsale = value; }
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
		private float _area;

		public float Area
		{
			get { return _area; }
			set { _area = value; }
		}
		private int? _rooms;

		public int? Rooms
		{
			get { return _rooms; }
			set { _rooms = value; }
		}
		private int _floor;

		public int Floor
		{
			get { return _floor; }
			set { _floor = value; }
		}
		private int _seedpointid;

		public int SeedPointId
		{
			get { return _seedpointid; }
			set { _seedpointid = value; }
		}
		private float _distance;

		public float Distance
		{
			get { return _distance; }
			set { _distance = value; }
		}
	}
}
