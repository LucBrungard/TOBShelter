using TOBShelter.Types.Base;
using System;

namespace TOBShelter.Types.Composed.Animals
{
    public class Horse : Animal
    {
        public Horse(string name, uint age, string weight, Gender gender, Breed breed, long ownerId)
            : base(name, age, weight, gender, breed, ownerId)
        {
            if (!(breed is Breed.Horse))
                throw new ArgumentException($"Should be of type {nameof(Breed.Horse)}", nameof(breed));
        }
    }
}