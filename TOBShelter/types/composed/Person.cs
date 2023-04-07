using System;

namespace Projet_Ortega_Thil_Brungard.Types.Composed
{
    internal class Person
    {
        private Identity _identity;
        private Coordinates _coordinates;

        internal Person(Identity identity, Coordinates coordinates)
        {
            _identity = identity ?? throw new ArgumentNullException(nameof(identity));
            _coordinates = coordinates ?? throw new ArgumentNullException(nameof(coordinates));
        }
    }
}