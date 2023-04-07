using Projet_Ortega_Thil_Brungard.Types.Base;
using System;

namespace Projet_Ortega_Thil_Brungard.Types.Composed.Animals
{
    internal class Dog : Animal
    {
        public Dog(string firstName, int age, string weight, Gender gender, Breed breed, Identity owner)
            : base(firstName, age, weight, gender, breed, owner)
        {
            if (!(breed is Breed.Dog))
                throw new ArgumentException($"Should be of type {nameof(Breed.Dog)}", nameof(breed));
        }
    }
}