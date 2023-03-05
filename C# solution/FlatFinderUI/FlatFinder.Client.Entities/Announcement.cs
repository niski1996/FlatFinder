using Core.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatFinder.Client.Entities
{
    class Announcement : ObjectBase
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

        private int _flatid;
        public int FlatId
        {
            get { return _flatid; }
            set
            {
                if (_flatid != value)
                {
                    _flatid = value;
                    OnPropertyChanged(() => FlatId);
                }
            }
        }

        private decimal _price;
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    OnPropertyChanged(() => Price);
                }
            }
        }

        private int _sessionindomainid;
        public int SessionInDomainId
        {
            get { return _sessionindomainid; }
            set
            {
                if (_sessionindomainid != value)
                {
                    _sessionindomainid = value;
                    OnPropertyChanged(() => SessionInDomainId);
                }
            }
        }

        private string _phonenumber;
        public string PhoneNumber
        {
            get { return _phonenumber; }
            set
            {
                if (_phonenumber != value)
                {
                    _phonenumber = value;
                    OnPropertyChanged(() => PhoneNumber);
                }
            }
        }

        private Announcer _announcer;
        public Announcer Announcer
        {
            get { return _announcer; }
            set
            {
                if (_announcer != value)
                {
                    _announcer = value;
                    OnPropertyChanged(() => Announcer);
                }
            }
        }

        private DateTime _announcedate;
        public DateTime AnnounceDate
        {
            get { return _announcedate; }
            set
            {
                if (_announcedate != value)
                {
                    _announcedate = value;
                    OnPropertyChanged(() => AnnounceDate);
                }
            }
        }
    }
}
