﻿using TOBShelter.Types.Base;
using System;

namespace TOBShelter.Types.Composed.Animals
{
    internal class Horse : Animal
    {
        public Horse(string firstName, int age, string weight, Gender gender, Breed breed, Identity owner)
            : base(firstName, age, weight, gender, breed, owner)
        {
            if (!(breed is Breed.Horse))
                throw new ArgumentException($"Should be of type {nameof(Breed.Horse)}", nameof(breed));
        }
    }
}