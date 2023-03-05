﻿using Core.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatFinder.Client.Entities
{
    public class Account : ObjectBase
    {
        int _AccountId;
        string _LoginEmail;
        string _FirstName;
        string _LastName;
        Address _address;
        string _CreditCard;
        string _ExpDate;

        public int AccountId
        {
            get { return _AccountId; }
            set
            {
                if (_AccountId != value)
                {
                    _AccountId = value;
                    OnPropertyChanged(() => AccountId);
                }
            }
        }

        public string LoginEmail
        {
            get { return _LoginEmail; }
            set
            {
                if (_LoginEmail != value)
                {
                    _LoginEmail = value;
                    OnPropertyChanged(() => LoginEmail);
                }
            }
        }

        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                if (_FirstName != value)
                {
                    _FirstName = value;
                    OnPropertyChanged(() => FirstName);
                }
            }
        }

        public string LastName
        {
            get { return _LastName; }
            set
            {
                if (_LastName != value)
                {
                    _LastName = value;
                    OnPropertyChanged(() => LastName);
                }
            }
        }

        public Address Address
        {
            get { return _address; }
            set
            {
                if (_address.Id != value.Id)
                {
                    _address = value;
                    OnPropertyChanged(() => Address);
                }
            }
        }


        public string CreditCard
        {
            get { return _CreditCard; }
            set
            {
                if (_CreditCard != value)
                {
                    _CreditCard = value;
                    OnPropertyChanged(() => CreditCard);
                }
            }
        }

        public string ExpDate
        {
            get { return _ExpDate; }
            set
            {
                if (_ExpDate != value)
                {
                    _ExpDate = value;
                    OnPropertyChanged(() => ExpDate);
                }
            }
        }
    }
}
