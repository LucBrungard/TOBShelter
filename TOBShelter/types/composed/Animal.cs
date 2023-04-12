using TOBShelter.Types.Base;
using System;
using TOBShelter.Utils;

namespace TOBShelter.Types.Composed
{
    internal abstract class Animal
    {
        internal long Id;

        private string _name;
        internal string Name
        {
            get { return _name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException(nameof(value));
                _name = value;
            }
        }

        private uint _age;
        internal uint Age
        {
            get { return _age; }
            set
            {
                if (value == 0)
                    throw new ArgumentException("Cannot be 0", nameof(value));
                _age = value;
            }
        }

        private string _weight;
        internal string Weight { 
            get { return _weight; }
            set
            {
                if (!RegexUtil.RegexWeight.IsMatch(value))
                    throw new ArgumentException("Has not the right format", nameof(value));
                _weight = value;
            }
        }

        internal Gender Gender { get; set; }
        internal Breed Breed { get; set; }
        internal long OwnerId { get; set; }

        public Animal(string name, uint age, string weight, Gender gender, Breed breed, long ownerId)
        {
            Breed = breed ?? throw new ArgumentNullException(nameof(breed));
            Name = name;
            Age = age;
            Weight = weight;
            Gender = gender;
            OwnerId = ownerId;
        }
    }
}