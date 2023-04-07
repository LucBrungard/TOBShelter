using Projet_Ortega_Thil_Brungard.Types.Base;
using System;

namespace Projet_Ortega_Thil_Brungard.Types.Composed.Animals
{
    internal class Cat : Animal
    {
        public Cat(string firstName, int age, string weight, Gender gender, Breed breed, Identity owner)
            : base(firstName, age, weight, gender, breed, owner)
        {
            if (!(breed is Breed.Cat))
                throw new ArgumentException($"Should be of type {nameof(Breed.Cat)}", nameof(breed));
        }
    }
}