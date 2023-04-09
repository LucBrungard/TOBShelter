using TOBShelter.Types.Base;
using System;

namespace TOBShelter.Types.Composed.Animals
{
    internal class Dog : Animal
    {
        public Dog(string firstName, int age, string weight, Gender gender, Breed breed)
            : base(firstName, age, weight, gender, breed)
        {
            if (!(breed is Breed.Dog))
                throw new ArgumentException($"Should be of type {nameof(Breed.Dog)}", nameof(breed));
        }
    }
}