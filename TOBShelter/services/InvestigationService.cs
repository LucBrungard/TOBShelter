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

            // Create a link between animals of the list and investigation
            if (investigation.Animals != null && investigation.Animals.Count > 0)
            {
                foreach (var animal in investigation.Animals)
                {
                    LinksAIService.Create(
                        new LinksAICreateDTO
                        {
                            AnimalId = animal.Id,
                            InvestigationId = investigation.Id
                        });
                }
            }

            // Create all documents from the list
            if (investigation.Documents != null && investigation.Documents.Count > 0)
            {
                foreach (var document in investigation.Documents)
                {
                    document.InvestigationId ??= investigation.Id;
                    DocumentService.Create(document);
                }
            }

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

            bool empty = true;
            StringBuilder stringBuilder = new StringBuilder("UPDATE `investigations` SET \n\t");

            if (investigation.Title != null)
            {
                empty = false;
                stringBuilder.Append($"title='{investigation.Title}',\n\t");
            }

            if (investigation.InvestigatorId != null && investigation.InvestigatorId != 0)
            {
                empty = false;
                stringBuilder.Append($"investigator='{investigation.InvestigatorId}',\n\t");
            }

            if (investigation.Notice != null)
            {
                empty = false;
                stringBuilder.Append($"notice='{investigation.Notice}',\n\t");
            }

            if (investigation.Closed != null)
            {
                empty = false;
                stringBuilder.Append($"closed='{((bool)investigation.Closed ? 1 : 0)}'\n\t");
            }

            if (!empty)
                throw new ArgumentException("No value set", nameof(investigation));

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

            string sql = $"SELECT `investigation_id`, `title`, `complainant`, `offender`, `reason`, `investigator`, `notice`, `closed` FROM `investigations` WHERE investigation_id='{id}'";

            MySqlCommand command = new MySqlCommand(sql, DBConnection.GetInstance().Connection);
            MySqlDataReader reader = command.ExecuteReader();

            if (!reader.Read())
                return null;

            InvestigationDetailsDTO dto = new InvestigationDetailsDTO
            {
                Id = reader.GetInt64("investigation_id"),
                Title = reader.GetString("title"),
                Complainant = PersonService.FindAll(new PersonFilters { Id = reader.GetInt64("complainant") })[0],
                Offender = PersonService.FindAll(new PersonFilters { Id = reader.GetInt64("offender") })[0],
                Reason = reader.GetString("reason"),
                Investigator = InvestigatorService.FindAll(new InvestigatorFilters { Id = reader.GetInt64("investigator") })[0],
                Notice = reader.GetString("notice"),
                Closed = reader.GetBoolean("closed")
            };
            reader.Close();

            // Get all animals related to the investigation
            List<Animal> animals = new List<Animal>();

            List<LinksAIDetailsDTO> linksAI = LinksAIService.FindAll(new LinksAIFilters { InvestigationId = id });
            foreach (LinksAIDetailsDTO link in linksAI)
            {
                animals.Add(AnimalService.FindById(link.AnimalId));
            }
            dto.Animals = animals;

            // Get all the documents
            dto.Documents = DocumentService.FindAll(new DocumentFilters { InvestigationId = id });

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
