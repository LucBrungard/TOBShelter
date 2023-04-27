using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOBShelter.Types.Dto;

namespace TOBShelter.Services
{
    public class DocumentService
    {
        public static DocumentDetailsDTO Create(DocumentCreateDTO document)
        {
            if (document == null)
                throw new ArgumentNullException(nameof(document));
            if (document.InvestigationId == null)
                throw new ArgumentNullException(nameof(document.InvestigationId));

            StringBuilder stringBuilder = new StringBuilder("INSERT INTO `documents` (path, investigation_id) VALUES (\n\t");

            stringBuilder.Append($"'{document.Path}',\n\t");
            stringBuilder.Append($"'{document.InvestigationId}')");

            MySqlCommand cmd = new MySqlCommand(stringBuilder.ToString(), DBConnection.GetInstance().Connection);
            int insertedRows = cmd.ExecuteNonQuery();

            return insertedRows == 1
                ? FindById(cmd.LastInsertedId)
                : null;
        }

        public static DocumentDetailsDTO Update(DocumentEditDTO document)
        {
            if (document == null)
                throw new ArgumentNullException(nameof(document));
            if (document.Id == 0)
                throw new ArgumentException("Cannot be 0", nameof(document.Id));

            bool empty = true;
            StringBuilder stringBuilder = new StringBuilder("UPDATE `documents` SET \n\t");

            if (document.Path != null)
            {
                empty = false;
                stringBuilder.Append($"path='{document.Path}'");
            }

            if (empty)
                throw new ArgumentException("No value set", nameof(document));

            stringBuilder.Append($"\nWHERE document_id='{document.Id}'");

            MySqlCommand cmd = new MySqlCommand(stringBuilder.ToString(), DBConnection.GetInstance().Connection);
            int updatedRows = cmd.ExecuteNonQuery();

            return updatedRows == 1
                ? FindById(document.Id)
                : null;
        }

        public static DocumentDetailsDTO FindById(long id)
        {
            if (id == 0)
                throw new ArgumentException("Cannot be 0", nameof(id));

            string sql = $"SELECT `document_id`, `path`, `investigation_id` FROM `documents` WHERE document_id='{id}'";

            MySqlCommand command = new MySqlCommand(sql, DBConnection.GetInstance().Connection);
            MySqlDataReader reader = command.ExecuteReader();

            if (!reader.Read())
            {
                reader.Close();
                return null;
            }

            DocumentDetailsDTO document = new DocumentDetailsDTO
            {
                Id = reader.GetInt64("document_id"),
                Path = reader.GetString("path"),
                InvestigationId = reader.GetInt64("investigation_id")
            };

            reader.Close();

            return document;
        }

        public static List<DocumentDetailsDTO> FindAll(DocumentFilters filters) 
        {
            string sql = "SELECT `document_id`, `path`, `investigation_id` FROM `documents`\n\t";

            StringBuilder conditions = new StringBuilder("WHERE \n\t");

            if (filters != null)
            {
                bool empty = true;
                bool first = true;

                if (filters.Id != null)
                {
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"document_id='{filters.Id}'\n\t");
                    empty = false;
                    first = false;
                }
                if (filters.Path != null)
                {
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"path='{filters.Path}'\n\t");
                    empty = false;
                    first = false;
                }
                if (filters.InvestigationId != null)
                {
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"investigation_id='{filters.InvestigationId}'\n\t");
                    empty = false;
                    first = false;
                }

                if (!empty)
                    sql += conditions.ToString();
            }

            MySqlCommand cmd = new MySqlCommand(sql, DBConnection.GetInstance().Connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            List<DocumentDetailsDTO> list = new List<DocumentDetailsDTO>();

            while (reader.Read())
            {
                DocumentDetailsDTO doc = new DocumentDetailsDTO();
                doc.Id = reader.GetInt32("document_id");
                doc.Path = reader.GetString("path");
                doc.InvestigationId = reader.GetInt64("investigation_id");

                list.Add(doc);
            }
            reader.Close();
            return list;
        }
    }
}
