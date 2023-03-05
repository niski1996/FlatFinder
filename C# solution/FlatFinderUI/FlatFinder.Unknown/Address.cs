using Core.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatFinder.Client.Entities
{

    public class Address : ObjectBase//TODO encje w buisness mogą być nie dostosowane, bo refaktoryzowałem później
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

        private string _country;

        public string Country
        {
            get { return _country; }
            set
            {
                if (_country != value)
                {
                    _country = value;
                    OnPropertyChanged(() => Country);
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

        private string _longitude;

        public string Longitude
        {
            get { return _longitude; }
            set
            {
                if (_longitude != value)
                {
                    _longitude = value;
                    OnPropertyChanged(() => Longitude);
                }
            }
        }

        private string _latitude;

        public string Latitude
        {
            get { return _latitude; }
            set
            {
                if (_latitude != value)
                {
                    _latitude = value;
                    OnPropertyChanged(() => Latitude);
                }
            }
        }
    }
}
