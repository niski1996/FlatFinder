using Core.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatFinder.Client.Entities
{
    class Flat: ObjectBase
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged(() => Id);
                }
            }
        }

        private bool _forSale;

        public bool ForSale
        {
            get { return _forSale; }
            set
            {
                if (_forSale != value)
                {
                    _forSale = value;
                    OnPropertyChanged(() => ForSale);
                }
            }
        }

        private string _city;

        public string City
        {
            get { return _city; }
            set
            {
                if (_city != value)
                {
                    _city = value;
                    OnPropertyChanged(() => City);
                }
            }
        }

        private string _district;

        public string District
        {
            get { return _district; }
            set
            {
                if (_district != value)
                {
                    _district = value;
                    OnPropertyChanged(() => District);
                }
            }
        }

        private string _street;

        public string Street
        {
            get { return _street; }
            set
            {
                if (_street != value)
                {
                    _street = value;
                    OnPropertyChanged(() => Street);
                }
            }
        }

        private int? _number;

        public int? Number
        {
            get { return _number; }
            set
            {
                if (_number != value)
                {
                    _number = value;
                    OnPropertyChanged(() => Number);
                }
            }
        }

        private float _area;

        public float Area
        {
            get { return _area; }
            set
            {
                if (_area != value)
                {
                    _area = value;
                    OnPropertyChanged(() => Area);
                }
            }
        }

        private int? _rooms;

        public int? Rooms
        {
            get { return _rooms; }
            set
            {
                if (_rooms != value)
                {
                    _rooms = value;
                    OnPropertyChanged(() => Rooms);
                }
            }
        }

        private int _floor;

        public int Floor
        {
            get { return _floor; }
            set
            {
                if (_floor != value)
                {
                    _floor = value;
                    OnPropertyChanged(() => Floor);
                }
            }
        }

        private int _seedPointId;

        public int SeedPointId
        {
            get { return _seedPointId; }
            set
            {
                if (_seedPointId != value)
                {
                    _seedPointId = value;
                    OnPropertyChanged(() => SeedPointId);
                }
            }
        }

        private float _distance;

        public float Distance
        {
            get { return _distance; }
            set
            {
                if (_distance != value)
                {
                    _distance = value;
                    OnPropertyChanged(() => Distance);
                }
            }
        }
    }
}
