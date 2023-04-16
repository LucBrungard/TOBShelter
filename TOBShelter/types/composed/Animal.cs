using TOBShelter.Types.Base;
using System;
using TOBShelter.Utils;

namespace TOBShelter.Types.Composed
{
    public abstract class Animal
    {
        public long Id;

        private string _name;
        public string Name
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
        public uint Age
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
        public string Weight { 
            get { return _weight; }
            set
            {
                if (!RegexUtil.RegexWeight.IsMatch(value))
                    throw new ArgumentException("Has not the right format", nameof(value));
                _weight = value;
            }
        }

        public Gender Gender { get; set; }
        public Breed Breed { get; set; }
        public long OwnerId { get; set; }

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