using System;
using System.Text.RegularExpressions;
using TOBShelter.Types.Base;
using TOBShelter.Utils;

namespace TOBShelter.Types.Composed
{
    class Coordinates
    {
        private string _mobile;
        private string _home;
        private string _email;
        private Route _route;
        private string _postalCode;
        private string _city;

        internal string Mobile
        {
            get { return _mobile; }
            set
            {
                if (!String.IsNullOrEmpty(value) && !RegexUtil.RegexPhoneNumber.IsMatch(value))
                    throw new ArgumentException($"Doesn't have the right format", nameof(_mobile));
                _mobile = value;
            }
        }

        internal string Home
        {
            get { return _home; }
            set
            {
                if (!String.IsNullOrEmpty(value) && !RegexUtil.RegexPhoneNumber.IsMatch(value))
                    throw new ArgumentException($"Doesn't have the right format", nameof(_home));
                _home = value;
            }
        }

        internal string Email
        {
            get { return _email; }
            set
            {
                if (!String.IsNullOrEmpty(value) && !RegexUtil.RegexEmail.IsMatch(value))
                    throw new ArgumentException($"Doesn't have the right format", nameof(_email));
                _email = value;
            }
        }

        internal Route Route
        {
            get { return _route; }
            set
            {
                _route = value ?? throw new ArgumentNullException(nameof(_route));
            }
        }

        internal string PostalCode
        {
            get { return _postalCode; }
            set
            {
                if (!RegexUtil.RegexPostalCode.IsMatch(value))
                    throw new ArgumentException($"Doesn't have the right format", nameof(_postalCode));
                _postalCode = value;
            }
        }

        internal string City
        {
            get { return _city; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException($"Can't be null or empty", nameof(_city));
                _city = value;
            }
        }

        internal Coordinates(string mobile, string home, string email, Route route, string postalCode, string city)
        {
            Mobile = mobile;
            Home = home;
            Email = email;
            Route = route;
            PostalCode = postalCode;
            City = city;
        }
    }
}