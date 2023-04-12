using TOBShelter.Types.Base;
using System;

namespace TOBShelter.Types.Composed.Animals
{
    internal class Dog : Animal
    {
        public Dog(string name, uint age, string weight, Gender gender, Breed breed, long ownerId)
            : base(name, age, weight, gender, breed, ownerId)
        {
            if (!(breed is Breed.Dog))
                throw new ArgumentException($"Should be of type {nameof(Breed.Dog)}", nameof(breed));
        }
    }
}