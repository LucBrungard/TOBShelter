using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;
using TOBShelter.Types.Base;
using TOBShelter.Types.Composed;
using TOBShelter.Types.Dto;

namespace TOBShelter.Services
{
    internal static class InvestigationService
    {
        internal static InvestigationDetailsDTO Create(InvestigationCreateDTO investigation)
        {
            if (investigation == null)
                throw new ArgumentNullException(nameof(investigation));

            StringBuilder stringBuilder;
            MySqlCommand cmd;
            int insertedRows;

            if (investigation.Animals != null && investigation.Animals.Count > 0)
            {
                stringBuilder = new StringBuilder("INSERT INTO `links_animals_investigations` VALUES\n\t");

                for (int i = 0; i < investigation.Animals.Count; i++)
                {
                    stringBuilder.Append($"({investigation.Animals[i].Id},");
                    stringBuilder.Append($"{investigation.Id})\n\t");
                    if (i != investigation.Animals.Count - 1)
                        stringBuilder.Append(",");
                }

                cmd = new MySqlCommand(stringBuilder.ToString(), DBConnection.GetInstance().Connection);
                insertedRows = cmd.ExecuteNonQuery();

                if (insertedRows != investigation.Animals.Count)
                    throw new Exception("An error occured, not all animals have been inserted");
            }

            stringBuilder = new StringBuilder("INSERT INTO `investigations` VALUES (\n\t");

            stringBuilder.Append($"'{investigation.Id}',\n\t");
            stringBuilder.Append($"'{investigation.Title}',\n\t");
            stringBuilder.Append($"'{investigation.ComplainantId}',\n\t");
            stringBuilder.Append($"'{investigation.OffenderId}',\n\t");
            stringBuilder.Append($"'{investigation.Reason}',\n\t");
            stringBuilder.Append($"'{investigation.InvestigatorId}',\n\t");
            stringBuilder.Append($"'{investigation.Notice}',\n\t");
            stringBuilder.Append($"'{(investigation.Closed ? 1 : 0)}');");

            cmd = new MySqlCommand(stringBuilder.ToString(), DBConnection.GetInstance().Connection);
            insertedRows = cmd.ExecuteNonQuery();

            return insertedRows == 1
                ? FindById(cmd.LastInsertedId)
                : null;
        }

        internal static InvestigationDetailsDTO Update(InvestigationEditDTO investigation)
        {
            if (investigation == null)
                throw new ArgumentNullException(nameof(investigation));

            if (investigation.Id == 0)
                throw new ArgumentException("Cannot be 0", nameof(investigation.Id));

            StringBuilder stringBuilder = new StringBuilder("UPDATE `investigations` SET \n\t");

            if (investigation.Title != null)
                stringBuilder.Append($"title='{investigation.Title}',\n\t");

            if (investigation.InvestigatorId != null && investigation.InvestigatorId != 0)
                stringBuilder.Append($"investigator='{investigation.InvestigatorId}',\n\t");

            if (investigation.Notice != null)
                stringBuilder.Append($"notice='{investigation.Notice}',\n\t");

            if (investigation.Closed != null)
                stringBuilder.Append($"closed='{((bool)investigation.Closed ? 1 : 0)}'\n\t");

            stringBuilder.Append($"WHERE investigation_id='{investigation.Id}'");

            MySqlCommand cmd = new MySqlCommand(stringBuilder.ToString(), DBConnection.GetInstance().Connection);
            int updatedRows = cmd.ExecuteNonQuery();

            return updatedRows == 1
                ? FindById(investigation.Id)
                : null;
        }

        internal static InvestigationDetailsDTO FindById(long id)
        {
            if (id == 0)
                throw new ArgumentException("Cannot be 0", nameof(id));

            string sql = $"SELECT * FROM `investigations` WHERE investigation_id='{id}'";

            MySqlCommand command = new MySqlCommand(sql, DBConnection.GetInstance().Connection);
            MySqlDataReader reader = command.ExecuteReader();

            if (!reader.Read())
                return null;

            InvestigationDetailsDTO dto = new InvestigationDetailsDTO();
            dto.Id = reader.GetInt64(0);

            dto.Title = reader.GetString(1);
            PersonFilters personFilter = new PersonFilters();
            personFilter.Id = reader.GetInt64(2);
            dto.Complainant = PersonService.FindAll(personFilter)[0];
            personFilter.Id = reader.GetInt64(3);
            dto.Offender = PersonService.FindAll(personFilter)[0];
            dto.Reason = reader.GetString(4);
            InvestigatorFilters investigatorFilter = new InvestigatorFilters
            {
                Id = reader.GetInt64(5)
            };
            dto.Investigator = InvestigatorService.FindAll(investigatorFilter)[0];
            dto.Notice = reader.GetString(6);
            dto.Closed = reader.GetBoolean(7);
            reader.Close();

            // Get all animals
            sql = $"SELECT * FROM `links_animals_investigations` WHERE investigation_id='{id}'";
            command = new MySqlCommand(sql, DBConnection.GetInstance().Connection);
            reader = command.ExecuteReader();

            List<Animal> animals = new List<Animal>();
            while (reader.Read())
                animals.Add(AnimalService.FindById(reader.GetInt64("animal_id")));
            reader.Close();

            dto.Animals = animals;

            return dto;
        }

        internal static List<InvestigationDTO> FindAll(InvestigationFilters filters)
        {
            string sql = "SELECT `investigation_id`, `title`, `investigator`, `closed` FROM `investigations`\n\t";

            StringBuilder conditions = new StringBuilder("WHERE \n\t");

            if (filters != null)
            {
                bool empty = true;
                bool first = true;

                if (filters.Id != null)
                {
                    empty = false;
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"investigation_id='{filters.Id}'\n\t");
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
                if (filters.ComplainantId != null)
                {
                    empty = false;
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"complainant='{filters.ComplainantId}'\n\t");
                    first = false;
                }
                if (filters.OffenderId != null)
                {
                    empty = false;
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"offender='{filters.OffenderId}'\n\t");
                    first = false;
                }
                if (filters.Closed != null)
                {
                    empty = false;
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"closed='{((bool)filters.Closed ? 1 : 0)}'\n\t");
                    first = false;
                }

                if (!empty)
                    sql += conditions.ToString();
            }

            MySqlCommand cmd = new MySqlCommand(sql, DBConnection.GetInstance().Connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            List<InvestigationDTO> list = new List<InvestigationDTO>();

            while (reader.Read())
            {
                InvestigationDTO investigation = new InvestigationDTO();
                investigation.Id = reader.GetInt64(0);

                investigation.Title = reader.GetString(1);

                InvestigatorFilters investigatorFilters = new InvestigatorFilters
                {
                    Id = reader.GetInt64(2)
                };
                InvestigatorDTO investigator = InvestigatorService.FindAll(investigatorFilters)[0];

                investigation.InvestigatorTitle = investigator.Title;
                investigation.InvestigatorName = investigator.Name;
                investigation.InvestigatorFirstName = investigator.FirstName;

                investigation.Closed = reader.GetBoolean(3);
            }
            reader.Close();
            return list;
        }
    }
}
