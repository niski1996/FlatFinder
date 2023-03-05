using Core.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatFinder.Client.Entities
{
    class SessionInDomain : ObjectBase
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

        private int _sessionid;

        public int SessionId
        {
            get { return _sessionid; }
            set
            {
                if (_sessionid != value)
                {
                    _sessionid = value;
                    OnPropertyChanged(() => SessionId);
                }
            }
        }

        private int _domainid;

        public int DomainId
        {
            get { return _domainid; }
            set
            {
                if (_domainid != value)
                {
                    _domainid = value;
                    OnPropertyChanged(() => DomainId);
                }
            }
        }

        private int _positive;

        public int Positive
        {
            get { return _positive; }
            set
            {
                if (_positive != value)
                {
                    _positive = value;
                    OnPropertyChanged(() => Positive);
                }
            }
        }

        private int _negative;

        public int Negative
        {
            get { return _negative; }
            set
            {
                if (_negative != value)
                {
                    _negative = value;
                    OnPropertyChanged(() => Negative);
                }
            }
        }

        private int _unknown;

        public int Unknown
        {
            get { return _unknown; }
            set
            {
                if (_unknown != value)
                {
                    _unknown = value;
                    OnPropertyChanged(() => Unknown);
                }
            }
        }

        private int _repated;

        public int Repated
        {
            get { return _repated; }
            set
            {
                if (_repated != value)
                {
                    _repated = value;
                    OnPropertyChanged(() => Repated);
                }
            }
        }
    }
}
