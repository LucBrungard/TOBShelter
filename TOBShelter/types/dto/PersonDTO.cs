using System;
using TOBShelter.Types.Base;
using TOBShelter.Types.Composed;
using TOBShelter.Utils;

namespace TOBShelter.Types.Dto
{
    internal class PersonCreateDTO
    {
        internal IdentityTitle Title { get; set; }
        
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
                    if (Title is IdentityTitle.M || Title is IdentityTitle.MME)
                        throw new ArgumentException($"Cannot be null or empty", nameof(value));
                }
                else
                {
                    if (Title is IdentityTitle.SOCIETE)
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

        internal RouteType RouteType { get; set; }

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

        internal PersonCreateDTO(IdentityTitle title, string name, string firstName, string numRoute, RouteType routeType, string routeName, string postalCode, string city)
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

    internal class PersonEditDTO
    {
        internal long Id { get; set; }
        internal Nullable<IdentityTitle> Title { get; set; }
        internal string Name { get; set; }
        internal string FirstName { get; set; }
        internal string Mobile { get; set; }
        internal string Home { get; set; }
        internal string Email { get; set; }
        internal string NumRoute { get; set; }
        internal Nullable<RouteType> RouteType { get; set; }
        internal string RouteName { get; set; }
        internal string PostalCode { get; set; }
        internal string City { get; set; }
    }

    internal class PersonDTO
    {
        internal long Id { get; set; }
        internal IdentityTitle Title { get; set; }
        internal string Name { get; set; }
        internal string FirstName { get; set; }
    }

    internal class PersonDetailsDTO: PersonEditDTO { }

    internal class PersonFilters: PersonEditDTO { }
}
