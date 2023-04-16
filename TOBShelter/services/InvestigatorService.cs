using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOBShelter.Services;
using TOBShelter.Types.Base;
using TOBShelter.Types.Composed;
using TOBShelter.Types.Dto;

namespace TOBShelter.Services
{
    public static class InvestigatorService
    {
        public static InvestigatorDetailsDTO Create(InvestigatorCreateDTO investigator, bool isNewPerson)
        {
            if (investigator == null)
                throw new ArgumentNullException(nameof(investigator));

            long personId;
            if (isNewPerson)
                personId = PersonService.Create(investigator).Id;
            else
            {
                PersonFilters filters = new PersonFilters
                {
                    Title = investigator.Title,
                    Name = investigator.Name,
                    FirstName = investigator.FirstName
                };

                personId = PersonService.FindAll(filters)[0].Id;
            }

            StringBuilder stringBuilder = new StringBuilder("INSERT INTO `investigators` VALUES (\n\t");

            stringBuilder.Append($"'{(investigator.Available ? 1 : 0)}',\n\t");
            stringBuilder.Append($"'{(investigator.InOperation ? 1 : 0)}',\n\t");
            stringBuilder.Append($"'{investigator.BusinessSector}',\n\t");
            stringBuilder.Append($"'{personId}');\n\t");

            MySqlCommand cmd = new MySqlCommand(stringBuilder.ToString(), DBConnection.GetInstance().Connection);
            int insertedRows = cmd.ExecuteNonQuery();

            return insertedRows == 1
                ? FindById(personId)
                : null;
        }

        public static InvestigatorDetailsDTO Update(InvestigatorEditDTO investigator)
        {
            if (investigator == null)
                throw new ArgumentNullException(nameof(investigator));
            if (investigator.Id == 0)
                throw new ArgumentException("Cannot be 0", nameof(investigator.Id));

            try
            {
                PersonService.Update(investigator);
            }
            catch (ArgumentException e)
            {
                if (e.Source != "person")
                    throw e;
            }

            StringBuilder stringBuilder = new StringBuilder("UPDATE `investigators` SET \n\t");

            if (investigator.Available != null)
                stringBuilder.Append($"available='{((bool)investigator.Available ? 1 : 0)}',\n\t");

            if (investigator.InOperation != null)
                stringBuilder.Append($"in_operation='{((bool)investigator.InOperation ? 1 : 0)}',\n\t");

            if (investigator.BusinessSector != null)
                stringBuilder.Append($"business_sector='{investigator.BusinessSector}',\n\t");

            stringBuilder.Append($" WHERE person_id='{investigator.Id}'");

            MySqlCommand cmd = new MySqlCommand(stringBuilder.ToString(), DBConnection.GetInstance().Connection);
            int updatedRows = cmd.ExecuteNonQuery();

            return updatedRows == 1
                ? FindById(investigator.Id)
                : null;
        }

        public static InvestigatorDetailsDTO FindById(long id)
        {
            if (id == 0)
                throw new ArgumentException("Cannot be 0", nameof(id));

            InvestigatorDetailsDTO res = new InvestigatorDetailsDTO(PersonService.FindById(id));

            if (res == null)
                return null;

            string sql = $"SELECT `available`, `in_operation`, `business_sector`, `person_id` FROM `investigators` WHERE person_id='{id}'";

            MySqlCommand command = new MySqlCommand(sql, DBConnection.GetInstance().Connection);
            MySqlDataReader reader = command.ExecuteReader();

            if (!reader.Read())
            {
                reader.Close();
                return null;
            }

            res.Available = reader.GetInt32("available") == 1;
            res.InOperation = reader.GetInt32("in_operation") == 1;
            res.BusinessSector = reader.GetString("business_sector");

            reader.Close();

            // Get the investigations
            InvestigationFilters investigationFilters = new InvestigationFilters { InvestigatorId = res.Id };
            res.Investigations = new HashSet<InvestigationDTO>(InvestigationService.FindAll(investigationFilters));
            
            return res;
        }

        public static List<InvestigatorDTO> FindAll(InvestigatorFilters filters)
        {
            string sql = "SELECT persons.person_id, title, name, first_name, available, in_operation FROM persons INNER JOIN investigators ON persons.person_id = investigators.person_id ";

            StringBuilder conditions = new StringBuilder("WHERE \n\t ");

            if (filters != null)
            {
                bool empty = true;
                bool first = true;

                if (filters.Id != 0)
                {
                    empty = false;
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"person_id='{filters.Id}'\n\t");
                    first = false;
                }
                if (filters.Title != null)
                {
                    empty = false;
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"title='{filters.Title}'\n\t");
                    first = false;
                }
                if (filters.Name != null)
                {
                    empty = false;
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"name='{filters.Name}'\n\t");
                    first = false;
                }
                if (filters.FirstName != null)
                {
                    empty = false;
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"first_name='{filters.FirstName}'\n\t");
                    first = false;
                }
                if (filters.Mobile != null)
                {
                    empty = false;
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"mobile='{filters.Mobile}'\n\t");
                    first = false;
                }
                if (filters.Home != null)
                {
                    empty = false;
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"home='{filters.Home}'\n\t");
                    first = false;
                }
                if (filters.Email != null)
                {
                    empty = false;
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"email='{filters.Email}'\n\t");
                    first = false;
                }
                if (filters.NumRoute != null)
                {
                    empty = false;
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"no_route='{filters.NumRoute}'\n\t");
                    first = false;
                }
                if (filters.RouteType != null)
                {
                    empty = false;
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"route_type='{filters.RouteType}'\n\t");
                    first = false;
                }
                if (filters.RouteName != null)
                {
                    empty = false;
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"route_name='{filters.RouteName}'\n\t");
                    first = false;
                }
                if (filters.PostalCode != null)
                {
                    empty = false;
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"postal_code='{filters.PostalCode}'\n\t");
                    first = false;
                }
                if (filters.City != null)
                {
                    empty = false;
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"city='{filters.City}'\n\t");
                    first = false;
                }
                if (filters.Available != null)
                {
                    empty = false;
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"available={filters.Available}\n\t");
                    first = false;
                }
                if (filters.InOperation != null)
                {
                    empty = false;
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"in_operation='{filters.InOperation}'\n\t");
                    first = false;
                }

                if (!empty)
                    sql += conditions.ToString();
            }

            MySqlCommand cmd = new MySqlCommand(sql, DBConnection.GetInstance().Connection);
            MySqlDataReader rdr = cmd.ExecuteReader();

            List<InvestigatorDTO> list = new List<InvestigatorDTO>();

            while (rdr.Read())
            {
                InvestigatorDTO investigator = new InvestigatorDTO();
                investigator.Id = rdr.GetUInt32("persons.person_id");
                investigator.Title = (IdentityTitle)Enum.Parse(typeof(IdentityTitle), rdr.GetString("title").ToUpper());
                investigator.Name = rdr.GetString("name");
                investigator.FirstName = rdr.GetString("first_name");
                investigator.Available = rdr.GetBoolean("available");
                investigator.InOperation = rdr.GetBoolean("in_operation");

                list.Add(investigator);
            }
            rdr.Close();

            foreach (var investigator in list)
            {
                InvestigationFilters filter = new InvestigationFilters
                {
                    InvestigatorId = investigator.Id
                };
                investigator.NbInvestigations = InvestigationService.FindAll(filter).Count;
            }
            return list;
        }
    }
}