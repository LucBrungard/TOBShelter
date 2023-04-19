using System;
using TOBShelter.Types.Base;
using TOBShelter.Types.Composed;
using TOBShelter.Utils;

namespace TOBShelter.Types.Dto
{
    public class PersonCreateDTO
    {
        public IdentityTitle Title { get; set; }

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Le nom doit être renseigné");
                _name = value;
            }
        }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    if (Title is IdentityTitle.M || Title is IdentityTitle.MME)
                        throw new ArgumentException($"Le prénom doit être renseigné");
                }
                else
                {
                    if (Title is IdentityTitle.SOCIETE)
                        throw new ArgumentException($"IdentityTitle must be set to {IdentityTitle.M} or {IdentityTitle.MME} before");
                }
                _firstName = value;
            }
        }

        private string _mobile;

        public string Mobile
        {
            get { return _mobile; }
            set
            {
                if (!String.IsNullOrEmpty(value) && !RegexUtil.RegexPhoneNumber.IsMatch(value))
                    throw new ArgumentException($"Le numéro de téléphone portable doit être composé de 10 chiffres.");
                _mobile = value;
            }
        }

        private string _home;

        public string Home
        {
            get { return _home; }
            set
            {
                if (!String.IsNullOrEmpty(value) && !RegexUtil.RegexPhoneNumber.IsMatch(value))
                    throw new ArgumentException($"Le numéro de téléphone portable doit être composé de 10 chiffres.");
                _home = value;
            }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set
            {
                if (!String.IsNullOrEmpty(value) && !RegexUtil.RegexEmail.IsMatch(value))
                    throw new ArgumentException($"L'adresse mail renseignée ne respecte pas le bon format.");
                _email = value;
            }
        }

        private string _numRoute;

        public string NumRoute
        {
            get { return _numRoute; }
            set
            {
                // TODO Regex for num
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException($"Le numéro de l'adresse postale doit être renseigné");
                _numRoute = value;
            }
        }

        public RouteType RouteType { get; set; }

        private string _routeName;

        public string RouteName
        {
            get { return _routeName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException($"Le type de route doit être renseigné");
                _routeName = value;
            }
        }

        private string _postalCode;

        public string PostalCode
        {
            get { return _postalCode; }
            set
            {
                if (!RegexUtil.RegexPostalCode.IsMatch(value))
                    throw new ArgumentException($"Le code postal renseigné ne respecte pas le bon format");
                _postalCode = value;
            }
        }

        private string _city;

        public string City
        {
            get { return _city; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException($"La ville doit être renseignée.");
                _city = value;
            }
        }

        public PersonCreateDTO(IdentityTitle title, string name, string firstName, string numRoute, RouteType routeType, string routeName, string postalCode, string city)
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

    public class PersonEditDTO
    {
        public long Id { get; set; }
        public Nullable<IdentityTitle> Title { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Mobile { get; set; }
        public string Home { get; set; }
        public string Email { get; set; }
        public string NumRoute { get; set; }
        public Nullable<RouteType> RouteType { get; set; }
        public string RouteName { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
    }

    public class PersonDTO
    {
        public long Id { get; set; }
        public IdentityTitle Title { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
    }

    public class PersonDetailsDTO : PersonEditDTO
    { }

    public class PersonFilters : PersonEditDTO
    { }
}