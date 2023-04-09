using TOBShelter.Types.Base;
using System;

namespace TOBShelter.Types.Composed
{
    internal abstract class Animal
    {
        private string _firstName;
        private int _age;
        private string _weight;
        private Gender _gender;
        private Breed _breed;

        internal Animal(string firstName, int age, string weight, Gender gender, Breed breed)
        {
            _breed = breed ?? throw new ArgumentNullException(nameof(breed));
            //_owner = owner ?? throw new ArgumentNullException(nameof(owner));
            _firstName = firstName;
            _age = age;
            _weight = weight;
            _gender = gender;
        }
    }
}