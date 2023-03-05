using Core.Common.Core;
using FluentValidation;

namespace FlatFinder.Client.Entities
{
    public class Announcer : ObjectBase
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

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged(() => Name);
                }
            }
        }

        private bool _broker;
        public bool Broker
        {
            get { return _broker; }
            set
            {
                if (_broker != value)
                {
                    _broker = value;
                    OnPropertyChanged(() => Broker);
                }
            }
        }

        private string _phoneNumber;
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value;
                    OnPropertyChanged(() => PhoneNumber);
                }
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged(() => Email);
                }
            }
        }

        class AnnouncerValidator : AbstractValidator<Announcer>
        {
            public AnnouncerValidator()
            {
                RuleFor(obj => obj.Email).EmailAddress();

            } 
        }
        protected override IValidator GetValidator()
        {
            return new AnnouncerValidator();
        }
    }
}
