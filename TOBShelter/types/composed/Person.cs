using System;
using System.Security.Principal;
using TOBShelter.Types.Base;

namespace TOBShelter.Types.Composed
{
    internal class Person
    {
        private Identity _identity;
        private Coordinates _coordinates;

        internal Identity Identity
        {
            get { return _identity; }
            set { _identity = value ?? throw new ArgumentNullException(nameof(_identity)); }
        }

        internal Coordinates Coordinates
        {
            get { return _coordinates; }
            set { _coordinates = value ?? throw new ArgumentNullException(nameof(_coordinates)); }
        }

        internal Person(Identity identity, Coordinates coordinates)
        {
            Identity = identity;
            Coordinates = coordinates;
        }
    }
}