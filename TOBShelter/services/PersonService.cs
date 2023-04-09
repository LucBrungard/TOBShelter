﻿using MySqlConnector;
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
    internal static class PersonService
    {
        internal static bool Create(Person person)
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
            stringBuilder.Append($"'{person.RouteName}',\n\t");

            stringBuilder.Append($"'{person.PostalCode}',\n\t");
            stringBuilder.Append($"'{person.City}');");

            MySqlCommand cmd = new MySqlCommand(stringBuilder.ToString(), DBConnection.GetInstance().Connection);
            return cmd.ExecuteNonQuery() == 1;
        }

        internal static bool Update(PersonDetailsDTO person)
        {
            if (person == null)
                throw new ArgumentNullException(nameof(person));
            if (person.Id == 0)
                throw new ArgumentException("Cannot be 0", nameof(person.Id));

            StringBuilder stringBuilder = new StringBuilder("UPDATE `persons` SET \n\t");

            bool empty = true;

            if (!(person.Title is IdentityTitle.NONE))
            {
                empty = false;
                stringBuilder.Append($"title='{person.Title}',\n\t");
            }
            if (person.Name != null)
            {
                empty = false;
                stringBuilder.Append($"name='{person.Name}',\n\t");
            }
            if (person.FirstName != null)
            {
                empty = false;
                stringBuilder.Append($"first_name='{person.FirstName}',\n\t");
            }
            if (person.Mobile != null)
            {
                empty = false;
                stringBuilder.Append($"mobile='{person.Mobile}',\n\t");
            }
            if (person.Home != null)
            {
                empty = false;
                stringBuilder.Append($"home='{person.Home}',\n\t");
            }
            if (person.Email != null)
            {
                empty = false;
                stringBuilder.Append($"email='{person.Email}',\n\t");
            }
            if (person.NumRoute != null)
            {
                empty = false;
                stringBuilder.Append($"no_route='{person.NumRoute}',\n\t");
            }
            if (!(person.RouteType is RouteType.NONE))
            {
                empty = false;
                stringBuilder.Append($"route_type='{person.RouteType}',\n\t");
            }
            if (person.RouteName != null)
            {
                empty = false;
                stringBuilder.Append($"route_name='{person.RouteName}',\n\t");
            }
            if (person.PostalCode != null)
            {
                empty = false;
                stringBuilder.Append($"postal_code='{person.PostalCode}',\n\t");
            }
            if (person.City != null)
            {
                empty = false;
                stringBuilder.Append($"city='{person.City}'\n");
            }

            if (empty)
                throw new ArgumentException("No value set", nameof(person));

            stringBuilder.Append($" WHERE person_id='{person.Id}'");

            MySqlCommand cmd = new MySqlCommand(stringBuilder.ToString(), DBConnection.GetInstance().Connection);
            return cmd.ExecuteNonQuery() == 1;
        }

        internal static PersonDetailsDTO FindById(uint id)
        {
            if (id == 0)
                throw new ArgumentException("Cannot be 0", nameof(id));

            string sql = $"SELECT * FROM `persons` WHERE person_id='{id}'";

            MySqlCommand command = new MySqlCommand(sql, DBConnection.GetInstance().Connection);
            MySqlDataReader reader = command.ExecuteReader();

            if (!reader.Read())
                return null;

            PersonDetailsDTO res = new PersonDetailsDTO();
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

        internal static List<PersonDTO> FindAll(PersonDetailsDTO filters)
        {
            string sql = "SELECT `person_id`, `title`, `name`, `first_name` FROM `persons` ";

            bool empty = true;
            StringBuilder conditions = new StringBuilder("WHERE \n\t");

            if (filters != null)
            {
                bool first = true;
                if (filters.Title != IdentityTitle.NONE)
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
                if (filters.RouteType != RouteType.NONE)
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
