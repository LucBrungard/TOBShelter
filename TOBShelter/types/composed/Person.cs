﻿using Google.Protobuf.WellKnownTypes;
using System;
using System.Security.Principal;
using System.Xml.Linq;
using TOBShelter.Types.Base;
using TOBShelter.Utils;

namespace TOBShelter.Types.Composed
{
    internal class Person
    {
        private IdentityTitle _title;
        internal IdentityTitle Title
        {
            get { return _title; }
            set
            {
                if (value is IdentityTitle.NONE)
                    throw new ArgumentException($"Cannot be of type {IdentityTitle.NONE}", nameof(value));
                _title = value;
            }
        }

        private string _name;
        internal string Name
        {
            get { return _name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Cannot be null or empty", nameof(value));
                if (value.Split(' ').Length > 1)
                    throw new ArgumentException("Must be in one word", nameof(value));
                _name = value;
            }
        }

        private string _firstName;
        internal string FirstName
        {
            get { return _firstName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    if (_title is IdentityTitle.M || _title is IdentityTitle.MME)
                        throw new ArgumentException($"Cannot be null or empty", nameof(value));
                }
                else
                {
                    if (_title is IdentityTitle.SOCIETE || _title is IdentityTitle.NONE)
                        throw new ArgumentException($"IdentityTitle must be set to {IdentityTitle.M} or {IdentityTitle.MME} before", nameof(value));
                }
                _firstName = value;
            }
        }

        private string _mobile;
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

        private string _home;
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

        private string _email;
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

        private string _numRoute;
        internal string NumRoute
        {
            get { return _numRoute; }
            set
            {
                // TODO Regex for num
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException($"Cannot be null or empty", nameof(value));
                _numRoute = value;
            }
        }

        private RouteType _routeType;
        internal RouteType RouteType
        {
            get { return _routeType; }
            set
            {
                if (value is RouteType.NONE)
                    throw new ArgumentException($"Cannot be {RouteType.NONE}", nameof(value));
                _routeType = value;
            }
        }

        private string _routeName;
        internal string RouteName
        {
            get { return _routeName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException($"Cannot be null or empty", nameof(value));
                _routeName = value;
            }
        }

        private string _postalCode;
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

        private string _city;
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

        internal Person(IdentityTitle title, string name, string firstName, string numRoute, RouteType routeType, string routeName, string postalCode, string city)
        {
            Title = title;
            Name = name;
            FirstName = firstName;
            NumRoute = numRoute;
            RouteType = routeType;
            RouteName = routeName;
            PostalCode = postalCode;
            City = city;
        }
    }
}