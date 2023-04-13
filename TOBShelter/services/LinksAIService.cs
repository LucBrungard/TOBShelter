using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using TOBShelter.Types.Dto;

namespace TOBShelter.Services
{
    internal class LinksAIService
    {
        internal static bool Create(LinksAICreateDTO link) 
        {
            if (link == null)
                throw new ArgumentNullException(nameof(link));

            StringBuilder stringBuilder = new StringBuilder("INSERT INTO `links_animals_investigations` ('animal_id', 'investigation_id') VALUES (\n\t");

            stringBuilder.Append($"'{link.AnimalId}',\n\t");
            stringBuilder.Append($"'{link.InvestigationId}')");

            MySqlCommand cmd = new MySqlCommand(stringBuilder.ToString(), DBConnection.GetInstance().Connection);
            int insertedRows = cmd.ExecuteNonQuery();

            return insertedRows == 1;
        }

        internal static bool Remove(LinksAIRemoveDTO link) 
        {
            if (link == null)
                throw new ArgumentNullException(nameof(link));

            StringBuilder stringBuilder = new StringBuilder("DELETE FROM `links_animals_investigations` WHERE\n\t");

            stringBuilder.Append($"animal_id='{link.AnimalId}'\n\t");
            stringBuilder.Append($"AND investigation_id='{link.InvestigationId}'");

            MySqlCommand cmd = new MySqlCommand(stringBuilder.ToString(), DBConnection.GetInstance().Connection);
            int insertedRows = cmd.ExecuteNonQuery();

            return insertedRows == 1;
        }

        internal static List<LinksAIDetailsDTO> FindAll(LinksAIFilters filters) 
        {
            string sql = "SELECT `animal_id`, `investigation_id` FROM `links_animals_investigations`\n\t";

            StringBuilder conditions = new StringBuilder("WHERE \n\t");

            if (filters != null)
            {
                bool empty = true;
                bool first = true;

                if (filters.AnimalId != null)
                {
                    conditions.Append($"animal_id='{filters.AnimalId}'\n\t");
                    empty = false;
                    first = false;
                }
                if (filters.InvestigationId != null)
                {
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"investigation_id='{filters.InvestigationId}'\n\t");
                    empty = false;
                }

                if (!empty)
                    sql += conditions.ToString();
            }

            MySqlCommand cmd = new MySqlCommand(sql, DBConnection.GetInstance().Connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            List<LinksAIDetailsDTO> list = new List<LinksAIDetailsDTO>();

            while (reader.Read())
            {
                LinksAIDetailsDTO link = new LinksAIDetailsDTO
                {
                    AnimalId = reader.GetInt64("animal_id"),
                    InvestigationId = reader.GetInt64("investigation_id")
                };

                list.Add(link);
            }
            reader.Close();
            return list;
        }
    }
}
