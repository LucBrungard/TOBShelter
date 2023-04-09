using System.Collections.Generic;
using TOBShelter.Types.Base;

namespace TOBShelter.Types.Composed
{
    internal class Investigator : Person
    {
        private bool _available;
        private bool _inOperation;
        private HashSet<string> _investigations;
        private HashSet<string> _businessSector;

        internal Investigator(IdentityTitle title, string name, string firstName, string numRoute, RouteType routeType, string routeName, string postalCode, string city) : base(title, name, firstName, numRoute, routeType, routeName, postalCode, city)
        {
        }

        //internal Investigator(
        //    Identity identity,
        //    Coordinates coordinates,
        //    bool available,
        //    bool inOperation,
        //    HashSet<string> investigations,
        //    HashSet<string> businessSection) : base(identity, coordinates)
        //{
        //    _available = available;
        //    _inOperation = inOperation;
        //    _investigations = investigations ?? new HashSet<string>();
        //    _businessSector = businessSection ?? new HashSet<string>();
        //}
    }
}