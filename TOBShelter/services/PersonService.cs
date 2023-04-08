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
    internal static class PersonService
    {
        internal static bool Create(Person person)
        {
            if (person == null)
                throw new ArgumentNullException(nameof(person));

            StringBuilder stringBuilder = new StringBuilder("INSERT INTO `persons` VALUES (\n\t");
            /* Identity */
            stringBuilder.Append("null,\n\t");
            stringBuilder.Append($"'{person.Identity.Title}',\n\t");
            stringBuilder.Append($"'{person.Identity.Name}',\n\t");
            stringBuilder.Append("'");
            if (person.Identity is Physical p)
                stringBuilder.Append(p.FirstName);
            stringBuilder.Append("',\n\t");

            /* Coordinates */
            stringBuilder.Append($"'{person.Coordinates.Mobile}',\n\t");
            stringBuilder.Append($"'{person.Coordinates.Home}',\n\t");
            stringBuilder.Append($"'{person.Coordinates.Email}',\n\t");

            stringBuilder.Append($"'{person.Coordinates.Route.Num}',\n\t");
            stringBuilder.Append($"'{person.Coordinates.Route.Type}',\n\t");
            stringBuilder.Append($"'{person.Coordinates.Route.Name}',\n\t");

            stringBuilder.Append($"'{person.Coordinates.PostalCode}',\n\t");
            stringBuilder.Append($"'{person.Coordinates.City}');");

            MySqlCommand cmd = new MySqlCommand(stringBuilder.ToString(), DBConnection.GetInstance().Connection);
            return cmd.ExecuteNonQuery() == 1;
        }

        internal static bool Update(Identity identity, PersonEditDTO editDTO)
        {
            if (identity == null)
                throw new ArgumentNullException(nameof(identity));
            if (editDTO == null)
                throw new ArgumentNullException(nameof(editDTO));

            if (DbUtil.CheckSqlInjection(identity.Name))
                throw new ArgumentException("Possible try of sql injection", nameof(identity.Name));

            StringBuilder stringBuilder = new StringBuilder("UPDATE `persons` SET \n\t");

            bool empty = true;

            if (editDTO.Mobile != null)
            {
                empty = false;
                stringBuilder.Append($"mobile='{editDTO.Mobile}',\n\t");
            }

            if (editDTO.Home != null)
            {
                empty = false;
                stringBuilder.Append($"home='{editDTO.Home}',\n\t");
            }
            if (editDTO.Email != null)
            {
                empty = false;
                stringBuilder.Append($"email='{editDTO.Email}',\n\t");
            }

            if (editDTO.NumRoute != null)
            {
                empty = false;
                stringBuilder.Append($"no_route='{editDTO.NumRoute}',\n\t");
            }
            if (editDTO.RouteType != RouteType.NONE)
            {
                empty = false;
                stringBuilder.Append($"route_type='{editDTO.RouteType}',\n\t");
            }
            if (editDTO.RouteName != null)
            {
                empty = false;
                stringBuilder.Append($"route_name='{editDTO.RouteName}',\n\t");
            }

            if (editDTO.PostalCode != null)
            {
                empty = false;
                stringBuilder.Append($"postal_code='{editDTO.PostalCode}',\n\t");
            }
            if (editDTO.City != null)
            {
                empty = false;
                stringBuilder.Append($"city='{editDTO.City}'\n");
            }

            if (empty)
                throw new ArgumentException("No value set", nameof(editDTO));

            stringBuilder.Append($"WHERE title='{identity.Title}' AND name='{identity.Name}' ");

            if (identity is Physical p)
            {
                if (DbUtil.CheckSqlInjection(p.FirstName))
                    throw new ArgumentException("Possible try of sql injection", nameof(p.FirstName));
                stringBuilder.Append($"AND first_name = '{p.FirstName}'");
            }

            MySqlCommand cmd = new MySqlCommand(stringBuilder.ToString(), DBConnection.GetInstance().Connection);
            return cmd.ExecuteNonQuery() == 1;
        }

        internal static Person Find(Identity id)
        {
            if (DbUtil.CheckSqlInjection(id.Name))
                throw new ArgumentException("Possible try of sql injection", nameof(id.Name));

            string sql = $"SELECT * FROM `persons` WHERE title='{id.Title}' AND name='{id.Name}'";

            if (id is Physical p)
            {
                if (DbUtil.CheckSqlInjection(p.FirstName))
                    throw new ArgumentException("Possible try of sql injection", nameof(p.FirstName));

                sql += $" AND first_name='{p.FirstName}'";
            }

            MySqlCommand command = new MySqlCommand(sql, DBConnection.GetInstance().Connection);
            MySqlDataReader reader = command.ExecuteReader();

            if (!reader.Read())
                return null;

            IdentityTitle title = (IdentityTitle)Enum.Parse(typeof(IdentityTitle), reader.GetString(1).ToUpper());
            string name = reader.GetString(2);
            Identity identity = (id is Physical)
                ? new Physical(title, name, reader.GetString(3))
                : new Society(title, name);

            Coordinates coordinates = new Coordinates(
                reader.GetString(4),
                reader.GetString(5),
                reader.GetString(6),
                new Route(
                    reader.GetString(7),
                    (RouteType)Enum.Parse(typeof(RouteType), reader.GetString(8).ToUpper()),
                    reader.GetString(9)),
                reader.GetString(10),
                reader.GetString(11));

            return new Person(identity, coordinates);
        }

        internal static List<Identity> FindAll(PersonDetailsDTO filters)
        {
            string sql = "SELECT `title`, `name`, `first_name` FROM `persons` ";

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
                    empty = false;
                    conditions.Append($"name='{filters.Name}'\n\t");
                    first = false;
                }
                if (filters.FirstName != null)
                {
                    if (!first)
                        conditions.Append("AND ");
                    empty = false;
                    conditions.Append($"first_name='{filters.FirstName}'\n\t");
                        first = false;
                }

                if (filters.Mobile != null)
                {
                    if (!first)
                        conditions.Append("AND ");
                    empty = false;
                    conditions.Append($"mobile='{filters.Mobile}'\n\t");
                    first = false;
                }

                if (filters.Home != null)
                {
                    if (!first)
                        conditions.Append("AND ");
                    empty = false;
                    conditions.Append($"home='{filters.Home}'\n\t");
                    first = false;
                }
                if (filters.Email != null)
                {
                    if (!first)
                        conditions.Append("AND ");
                    empty = false;
                    conditions.Append($"email='{filters.Email}'\n\t");
                    first = false;
                }

                if (filters.NumRoute != null)
                {
                    if (!first)
                        conditions.Append("AND ");
                    empty = false;
                    conditions.Append($"no_route='{filters.NumRoute}'\n\t");
                        first = false;
                }
                if (filters.RouteType != RouteType.NONE)
                {
                    if (!first)
                        conditions.Append("AND ");
                    empty = false;
                    conditions.Append($"route_type='{filters.RouteType}'\n\t");
                        first = false;
                }
                if (filters.RouteName != null)
                {
                    if (!first)
                        conditions.Append("AND ");
                    empty = false;
                    conditions.Append($"route_name='{filters.RouteName}'\n\t");
                        first = false;
                }

                if (filters.PostalCode != null)
                {
                    if (!first)
                        conditions.Append("AND ");
                    empty = false;
                    conditions.Append($"postal_code='{filters.PostalCode}'\n\t");
                        first = false;
                }
                if (filters.City != null)
                {
                    if (!first)
                        conditions.Append("AND ");
                    empty = false;
                    conditions.Append($"city='{filters.City}'\n");
                }
                first = false;

                if (!empty)
                    sql += conditions.ToString();
            }

            MySqlCommand cmd = new MySqlCommand(sql, DBConnection.GetInstance().Connection);
            MySqlDataReader rdr = cmd.ExecuteReader();

            List<Identity> list = new List<Identity>();

            while (rdr.Read())
            {
                IdentityTitle title = (IdentityTitle)Enum.Parse(typeof(IdentityTitle), rdr.GetString(0).ToUpper());
                string name = rdr.GetString(1);
                string firstName = rdr.GetString(2);

                if (String.IsNullOrEmpty(firstName))
                    list.Add(new Society(title, name));
                else
                    list.Add(new Physical(title, name, firstName));
            }
            rdr.Close();
            return list;
        }
    }
}
