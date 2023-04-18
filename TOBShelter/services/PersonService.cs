using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using TOBShelter.Types.Base;
using TOBShelter.Types.Composed;
using TOBShelter.Types.Dto;
using TOBShelter.utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TOBShelter.Services
{
    public static class PersonService
    {
        public static PersonDetailsDTO Create(PersonCreateDTO person)
        {
            if (person == null)
                throw new ArgumentNullException(nameof(person));

            StringBuilder stringBuilder = new StringBuilder("INSERT INTO `persons` VALUES (\n\t");
            /* Identity */
            stringBuilder.Append("null,\n\t");
            stringBuilder.Append($"'{person.Title}',\n\t");
            stringBuilder.Append($"'{person.Name}',\n\t");
            stringBuilder.Append($"'{person.FirstName}',\n\t");

            /* Coordinates */
            stringBuilder.Append($"'{person.Mobile}',\n\t");
            stringBuilder.Append($"'{person.Home}',\n\t");
            stringBuilder.Append($"'{person.Email}',\n\t");

            stringBuilder.Append($"'{person.NumRoute}',\n\t");
            stringBuilder.Append($"'{person.RouteType}',\n\t");
            stringBuilder.Append($"\"{person.RouteName}\",\n\t");

            stringBuilder.Append($"'{person.PostalCode}',\n\t");
            stringBuilder.Append($"'{person.City}');");

            MySqlCommand cmd = new MySqlCommand(stringBuilder.ToString(), DBConnection.GetInstance().Connection);
            int insertedRows = cmd.ExecuteNonQuery();

            return insertedRows == 1
                ? FindById(cmd.LastInsertedId)
                : null;
        }

        public static PersonDetailsDTO Update(PersonEditDTO person)
        {
            if (person == null)
                throw new ArgumentNullException(nameof(person));
            if (person.Id == 0)
                throw new ArgumentException("Cannot be 0", nameof(person.Id));

            StringBuilder stringBuilder = new StringBuilder("UPDATE `persons` SET \n\t");

            bool empty = true;
            bool first = true;

            if (person.Title != null)
            {
                first = false;
                empty = false;
                stringBuilder.Append($"title='{person.Title}'");
            }
            if (person.Name != null)
            {
                if (!first)
                    stringBuilder.Append(",\n\t");
                first = false;
                empty = false;
                stringBuilder.Append($"name='{person.Name}'");
            }
            if (person.FirstName != null)
            {
                if (!first)
                    stringBuilder.Append(",\n\t");
                first = false;
                empty = false;
                stringBuilder.Append($"first_name='{person.FirstName}'");
            }
            if (person.Mobile != null)
            {
                if (!first)
                    stringBuilder.Append(",\n\t");
                first = false;
                empty = false;
                stringBuilder.Append($"mobile='{person.Mobile}'");
            }
            if (person.Home != null)
            {
                if (!first)
                    stringBuilder.Append(",\n\t");
                first = false;
                empty = false;
                stringBuilder.Append($"home='{person.Home}'");
            }
            if (person.Email != null)
            {
                if (!first)
                    stringBuilder.Append(",\n\t");
                first = false;
                empty = false;
                stringBuilder.Append($"email='{person.Email}'");
            }
            if (person.NumRoute != null)
            {
                if (!first)
                    stringBuilder.Append(",\n\t");
                first = false;
                empty = false;
                stringBuilder.Append($"no_route='{person.NumRoute}'");
            }
            if (person.RouteType != null)
            {
                if (!first)
                    stringBuilder.Append(",\n\t");
                first = false;
                empty = false;
                stringBuilder.Append($"route_type='{person.RouteType}'");
            }
            if (person.RouteName != null)
            {
                if (!first)
                    stringBuilder.Append(",\n\t");
                first = false;
                empty = false;
                stringBuilder.Append($"route_name=\"{person.RouteName}\"");
            }
            if (person.PostalCode != null)
            {
                if (!first)
                    stringBuilder.Append(",\n\t");
                first = false;
                empty = false;
                stringBuilder.Append($"postal_code='{person.PostalCode}'");
            }
            if (person.City != null)
            {
                if (!first)
                    stringBuilder.Append(",\n\t");
                empty = false;
                stringBuilder.Append($"city='{person.City}'");
            }

            if (empty)
                throw new ArgumentException("No value set", nameof(person));

            stringBuilder.Append($"\nWHERE person_id='{person.Id}'");

            MySqlCommand cmd = new MySqlCommand(stringBuilder.ToString(), DBConnection.GetInstance().Connection);
            int updatedRows = cmd.ExecuteNonQuery();

            return updatedRows == 1
                ? FindById(person.Id)
                : null;
        }

        public static PersonDetailsDTO FindById(long id)
        {
            if (id == 0)
                throw new ArgumentException("Cannot be 0", nameof(id));

            string sql = $"SELECT * FROM `persons` WHERE person_id='{id}'";

            MySqlCommand command = new MySqlCommand(sql, DBConnection.GetInstance().Connection);
            MySqlDataReader reader = command.ExecuteReader();

            if (!reader.Read())
            {
                reader.Close();
                return null;
            }

            PersonDetailsDTO res = new PersonDetailsDTO();
            res.Id = reader.GetInt64(0);
            res.Title = (IdentityTitle)Enum.Parse(typeof(IdentityTitle), reader.GetString(1).ToUpper());
            res.Name = reader.GetString(2);
            res.FirstName = reader.GetString(3);
            res.Mobile = reader.GetString(4);
            res.Home = reader.GetString(5);
            res.Email = reader.GetString(6);
            res.NumRoute = reader.GetString(7);
            res.RouteType = (RouteType)Enum.Parse(typeof(RouteType), reader.GetString(8).ToUpper());
            res.RouteName = reader.GetString(9);
            res.PostalCode = reader.GetString(10);
            res.City = reader.GetString(11);

            reader.Close();

            return res;
        }

        public static List<PersonDTO> FindAll(PersonFilters filters)
        {
            string sql = "SELECT `person_id`, `title`, `name`, `first_name` FROM `persons` ";

            StringBuilder conditions = new StringBuilder("WHERE \n\t");

            if (filters != null)
            {
                bool empty = true;
                bool first = true;

                if (filters.Id != 0)
                {
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"person_id='{filters.Id}'\n\t");
                    empty = false;
                    first = false;
                }
                if (filters.Title != null)
                {
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"title='{filters.Title}'\n\t");
                    empty = false;
                    first = false;
                }
                if (filters.Name != null)
                {
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"name='{filters.Name}'\n\t");
                    empty = false;
                    first = false;
                }
                if (filters.FirstName != null)
                {
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"first_name='{filters.FirstName}'\n\t");
                    empty = false;
                    first = false;
                }

                if (filters.Mobile != null)
                {
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"mobile='{filters.Mobile}'\n\t");
                    empty = false;
                    first = false;
                }

                if (filters.Home != null)
                {
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"home='{filters.Home}'\n\t");
                    empty = false;
                    first = false;
                }
                if (filters.Email != null)
                {
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"email='{filters.Email}'\n\t");
                    empty = false;
                    first = false;
                }
                if (filters.NumRoute != null)
                {
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"no_route='{filters.NumRoute}'\n\t");
                    empty = false;
                    first = false;
                }
                if (filters.RouteType != null)
                {
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"route_type='{filters.RouteType}'\n\t");
                    empty = false;
                    first = false;
                }
                if (filters.RouteName != null)
                {
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"route_name='{filters.RouteName}'\n\t");
                    empty = false;
                    first = false;
                }
                if (filters.PostalCode != null)
                {
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"postal_code='{filters.PostalCode}'\n\t");
                    empty = false;
                    first = false;
                }
                if (filters.City != null)
                {
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"city='{filters.City}'\n");
                    empty = false;
                    first = false;
                }

                if (!empty)
                    sql += conditions.ToString();
            }

            MySqlCommand cmd = new MySqlCommand(sql, DBConnection.GetInstance().Connection);
            MySqlDataReader rdr = cmd.ExecuteReader();

            List<PersonDTO> list = new List<PersonDTO>();

            while (rdr.Read())
            {
                PersonDTO person = new PersonDTO();
                person.Id = rdr.GetUInt32(0);
                person.Title = (IdentityTitle)Enum.Parse(typeof(IdentityTitle), rdr.GetString(1).ToUpper());
                person.Name = rdr.GetString(2);
                person.FirstName = rdr.GetString(3);

                list.Add(person);
            }
            rdr.Close();
            return list;
        }
    }
}