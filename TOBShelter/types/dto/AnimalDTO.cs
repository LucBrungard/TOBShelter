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
    public class AnimalEditDTO
    {
        public long Id { get; set; }

        private Nullable<uint> _age;

        public Nullable<uint> Age
        {
            get { return _age; }
            set
            {
                if (value == 0)
                    throw new ArgumentException("L'animal ne peut pas être agé de 0 mois", nameof(value));
                _age = value;
            }
        }

        private string _weight;

        public string Weight
        {
            get { return _weight; }
            set
            {
                if (!RegexUtil.RegexWeight.IsMatch(value))
                    throw new ArgumentException("Le poids indiqué ne respecte pas le bon format. (Exemple : 3.2kg ou 800g)", nameof(value));
                _weight = value;
            }
        }

        public Nullable<long> OwnerId { get; set; }
    }

    public class AnimalFilters
    {
        public Nullable<long> Id { get; set; }

        private Type _animalType;

        public Type AnimalType
        {
            get { return _animalType; }
            set
            {
                if (!value.IsSubclassOf(typeof(Animal)))
                    throw new ArgumentException("Should be a subtype of Animal", nameof(value));
                _animalType = value;
            }
        }

        public string Name { get; set; }
        public Nullable<uint> Age { get; set; }

        private Type _breed;

        public Type Breed
        {
            get { return _breed; }
            set
            {
                if (!value.IsSubclassOf(typeof(Breed.Cat))
                    && !value.IsSubclassOf(typeof(Breed.Dog))
                    && !value.IsSubclassOf(typeof(Breed.Horse)))
                    throw new ArgumentException("Should be a subtype of Cat or Dog or Horse", nameof(value));
                _breed = value;
            }
        }

        public Nullable<long> OwnerId { get; set; }
    }
}