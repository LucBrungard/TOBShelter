using System;

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

        internal Coordinates(string mobile, string home, string email, Route route, string postalCode, string city)
        {
            _route = route ?? throw new ArgumentNullException(nameof(route));
            _mobile = mobile;
            _home = home;
            _email = email;
            _postalCode = postalCode;
            _city = city;
        }
    }
}