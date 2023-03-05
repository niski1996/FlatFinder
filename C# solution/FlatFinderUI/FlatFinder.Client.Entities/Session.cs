using Core.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FlatFinder.Client.Entities
{
    class Session : ObjectBase
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

        private DateTime _sessiondate;

        public DateTime SessionDate
        {
            get { return _sessiondate; }
            set
            {
                if (_sessiondate != value)
                {
                    _sessiondate = value;
                    OnPropertyChanged(() => SessionDate);
                }
            }
        }

        private int _userid;

        public int UserId
        {
            get { return _userid; }
            set
            {
                if (_userid != value)
                {
                    _userid = value;
                    OnPropertyChanged(() => UserId);
                }
            }
        }
    }
}
