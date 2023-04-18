using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Remoting;
using System.Text;
using MySqlConnector;
using TOBShelter.Types.Base;
using TOBShelter.Types.Composed;
using TOBShelter.Types.Dto;
using static TOBShelter.Types.Base.Breed.Cat;

namespace TOBShelter.Services
{
    public static class AnimalService
    {
        public static Animal Create(Animal animal)
        {
            if (animal == null)
                throw new ArgumentNullException(nameof(animal));

            StringBuilder stringBuilder = new StringBuilder("INSERT INTO `animals` (type, name, age, weight, gender, race, owner) VALUES (\n\t");

            stringBuilder.Append($"'{animal.GetType().FullName}',\n\t");
            stringBuilder.Append($"'{animal.Name}',\n\t");
            stringBuilder.Append($"'{animal.Age}',\n\t");
            stringBuilder.Append($"'{animal.Weight}',\n\t");
            stringBuilder.Append($"'{animal.Gender}',\n\t");
            stringBuilder.Append($"'{animal.Breed.GetType().FullName}',\n\t");
            stringBuilder.Append($"'{animal.OwnerId}')");

            MySqlCommand cmd = new MySqlCommand(stringBuilder.ToString(), DBConnection.GetInstance().Connection);
            int insertedRows = cmd.ExecuteNonQuery();

            if (insertedRows == 0)
                return null;

            animal.Id = cmd.LastInsertedId;
            return animal;
        }

        public static Animal Update(AnimalEditDTO animal)
        {
            if (animal == null)
                throw new ArgumentNullException(nameof(animal));
            if (animal.Id == 0)
                throw new ArgumentException("Cannot be 0", nameof(animal.Id));

            StringBuilder stringBuilder = new StringBuilder("UPDATE `animals` SET\n\t");
            bool empty = true;
            bool first = true;

            if (animal.Age != null)
            {
                stringBuilder.Append($"age='{animal.Age}'");
                empty = false;
                first = false;
            }
            if (animal.Weight != null)
            {
                if (!first)
                    stringBuilder.Append(",\n\t");
                stringBuilder.Append($"weight='{animal.Weight}'");
                empty = false;
                first = false;
            }
            if (animal.OwnerId != null)
            {
                if (!first)
                    stringBuilder.Append(",\n\t");
                stringBuilder.Append($"owner='{animal.OwnerId}'");
                empty = false;
            }

            if (empty)
                throw new ArgumentException("No value set", nameof(animal));

            stringBuilder.Append($"\nWHERE animal_id='{animal.Id}'");

            MySqlCommand cmd = new MySqlCommand(stringBuilder.ToString(), DBConnection.GetInstance().Connection);
            int updatedRows = cmd.ExecuteNonQuery();

            return updatedRows == 1
                ? FindById(animal.Id)
                : null;
        }

        public static Animal FindById(long id)
        {
            if (id == 0)
                throw new ArgumentException("Cannot be 0", nameof(id));

            string sql = $"SELECT * FROM `animals` WHERE animal_id='{id}'";

            MySqlCommand command = new MySqlCommand(sql, DBConnection.GetInstance().Connection);
            MySqlDataReader reader = command.ExecuteReader();

            if (!reader.Read())
            {
                reader.Close();
                return null;
            }

            string name = reader.GetString("name");
            uint age = reader.GetUInt32("age");
            string weight = reader.GetString("weight");
            Gender gender = (Gender)Enum.Parse(typeof(Gender), reader.GetString("gender"));
            long ownerId = reader.GetInt64("owner");

            string breedTypeName = reader.GetString("race");
            Type breedType = Type.GetType(breedTypeName);
            Breed breed = (Breed)Activator.CreateInstance(breedType);

            string animalTypeName = reader.GetString("type");
            Type animalType = Type.GetType(animalTypeName);
            Animal animal = (Animal)Activator.CreateInstance(animalType, new object[6] {
                name,
                age,
                weight,
                gender,
                breed,
                ownerId
            });
            animal.Id = reader.GetInt64("animal_id");

            reader.Close();

            return animal;
        }

        public static List<Animal> FindAll(AnimalFilters filters)
        {
            string sql = "SELECT * FROM `animals` ";

            if (filters != null)
            {
                StringBuilder conditions = new StringBuilder("WHERE \n\t");

                bool empty = true;
                bool first = true;

                if (filters.Id != null)
                {
                    conditions.Append($"animal_id='{filters.Id}'\n\t");
                    first = false;
                    empty = false;
                }
                if (filters.AnimalType == null)
                {
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"type='{filters.AnimalType.FullName}'\n\t");
                    first = false;
                    empty = false;
                }
                if (filters.Name == null)
                {
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"name='{filters.Name}'\n\t");
                    first = false;
                    empty = false;
                }
                if (filters.Age == null)
                {
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"age='{filters.Age}'\n\t");
                    first = false;
                    empty = false;
                }
                if (filters.Breed == null)
                {
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"race='{filters.Breed.FullName}'\n\t");
                    first = false;
                    empty = false;
                }
                if (filters.OwnerId == null)
                {
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"race='{filters.OwnerId}'\n\t");
                    first = false;
                    empty = false;
                }

                if (!empty)
                    sql += conditions.ToString();
            }

            MySqlCommand cmd = new MySqlCommand(sql, DBConnection.GetInstance().Connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            List<Animal> list = new List<Animal>();

            while (reader.Read())
            {
                string name = reader.GetString("name");
                uint age = reader.GetUInt32("age");
                string weight = reader.GetString("weight");
                Gender gender = (Gender)Enum.Parse(typeof(Gender), reader.GetString("gender"));
                long ownerId = reader.GetInt64("owner");

                string breedTypeName = reader.GetString("race");
                Type breedType = Type.GetType(breedTypeName);
                Breed breed = (Breed)Activator.CreateInstance(breedType);

                string animalTypeName = reader.GetString("type");
                Type animalType = Type.GetType(animalTypeName);
                Animal animal = (Animal)Activator.CreateInstance(animalType, new object[6] {
                    name,
                    age,
                    weight,
                    gender,
                    breed,
                    ownerId
                });
                animal.Id = reader.GetInt64("animal_id");

                list.Add(animal);
            }
            reader.Close();
            return list;
        }
    }
}
