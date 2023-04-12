using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOBShelter.Types.Base;
using TOBShelter.Types.Composed;
using TOBShelter.Utils;

namespace TOBShelter.Types.Dto
{
    internal class AnimalEditDTO
    {
        internal long Id { get; set; }

        private Nullable<uint> _age;
        internal Nullable<uint> Age
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
        internal string Weight
        {
            get { return _weight; }
            set
            {
                if (!RegexUtil.RegexWeight.IsMatch(value))
                    throw new ArgumentException("Has not the right format", nameof(value));
                _weight = value;
            }
        }
        internal Nullable<long> OwnerId { get; set; }
    }

    internal class AnimalFilters
    {
        internal Nullable<long> Id { get; set; }

        private Type _animalType;
        internal Type AnimalType
        {
            get { return _animalType; }
            set
            {
                if (!value.IsSubclassOf(typeof(Animal)))
                    throw new ArgumentException("Should be a subtype of Animal", nameof(value));
                _animalType = value;
            }
        }
        internal string Name { get; set;  }
        internal Nullable<uint> Age { get; set; }

        private Type _breed;
        internal Type Breed
        {
            get { return _breed; }
            set
            {
                if (!value.IsSubclassOf(typeof(Breed.Cat))
                    && !value.IsSubclassOf(typeof(Breed.Dog))
                    && !value.IsSubclassOf(typeof(Breed.Horse)))
                    throw new ArgumentException("Should be a subtype of Cat or Dog or Horse", nameof(value));
                _animalType = value;
            }
        }
        internal Nullable<long> OwnerId { get; set; }
    }
}
