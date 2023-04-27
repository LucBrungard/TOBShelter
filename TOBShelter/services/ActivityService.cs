using MySqlConnector;
using Org.BouncyCastle.Asn1.X500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOBShelter.Types.Base;
using TOBShelter.Types.Composed;
using TOBShelter.Types.Dto;
using static TOBShelter.Types.Base.Breed.Cat;

namespace TOBShelter.Services
{
    internal static class ActivityService
    {
        internal static ActivityDTODetails Create(ActivityDTOCreate activity)
        {
            if (activity == null)
                throw new ArgumentNullException(nameof(activity));

            StringBuilder stringBuilder = new StringBuilder("INSERT INTO `activities` (date, description, type, investigation_id) VALUES (\n\t");

            stringBuilder.Append($"'{activity.Date}',\n\t");
            stringBuilder.Append($"'{activity.Description}',\n\t");
            stringBuilder.Append($"'{activity.ActivityType}',\n\t");
            stringBuilder.Append($"'{activity.InvestigationId}')");

            MySqlCommand cmd = new MySqlCommand(stringBuilder.ToString(), DBConnection.GetInstance().Connection);
            int insertedRows = cmd.ExecuteNonQuery();

            return insertedRows == 1
                ? FindById(cmd.LastInsertedId)
                : null;
        }

        internal static ActivityDTODetails Update(ActivityDTOEdit activity)
        {
            if (activity == null)
                throw new ArgumentNullException(nameof(activity));
            if (activity.Id == 0)
                throw new ArgumentException("Cannot be 0", nameof(activity.Id));

            StringBuilder stringBuilder = new StringBuilder("UPDATE `activities` SET \n\t");

            bool empty = true;
            bool first = true;

            if (activity.Date != null)
            {
                first = false;
                empty = false;
                stringBuilder.Append($"date='{activity.Date}'");
            }
            if (activity.Description != null)
            {
                if (!first)
                    stringBuilder.Append(",\n\t");
                first = false;
                empty = false;
                stringBuilder.Append($"description=\"{activity.Description}\"");
            }
            if (activity.ActivityType != null)
            {
                if (!first)
                    stringBuilder.Append(",\n\t");
                first = false;
                empty = false;
                stringBuilder.Append($"type='{activity.ActivityType}'");
            }
            if (activity.InvestigationId != null)
            {
                if (!first)
                    stringBuilder.Append(",\n\t");
                empty = false;
                stringBuilder.Append($"investigation_id='{activity.InvestigationId}'");
            }

            if (empty)
                throw new ArgumentException("No value set", nameof(activity));

            stringBuilder.Append($"\nWHERE activity_id='{activity.Id}'");

            MySqlCommand cmd = new MySqlCommand(stringBuilder.ToString(), DBConnection.GetInstance().Connection);
            int updatedRows = cmd.ExecuteNonQuery();

            return updatedRows == 1
                ? FindById(activity.Id)
                : null;
        }

        internal static ActivityDTODetails FindById(long id)
        {
            if (id == 0)
                throw new ArgumentException("Cannot be 0", nameof(id));

            string sql = $"SELECT `activity_id`, `date`, `description`, `type`  FROM `activities` WHERE activity_id='{id}'";

            MySqlCommand command = new MySqlCommand(sql, DBConnection.GetInstance().Connection);
            MySqlDataReader reader = command.ExecuteReader();

            if (!reader.Read())
            {
                reader.Close();
                return null;
            }

            ActivityDTODetails details = new ActivityDTODetails
            {
                ActivityId = reader.GetInt64("activity_id"),
                Date = reader.GetDateTime("date"),
                Description = reader.GetString("description"),
                ActivityType = (ActivityType)Enum.Parse(typeof(ActivityType), reader.GetString("type").ToUpper())
            };
            reader.Close();

            if (details.ActivityType != ActivityType.PHOTO)
                return details;

            sql = $"SELECT `path` FROM `photo_links` WHERE photo_link_id='{details.ActivityId}'";
            command = new MySqlCommand(sql, DBConnection.GetInstance().Connection);
            reader = command.ExecuteReader();

            details.Links = new List<string>();

            while (reader.Read())
                details.Links.Add(reader.GetString("path"));
            reader.Close();

            return details;
        }

        internal static List<ActivityDTO> FindAll(ActivityFilters filters)
        {
            string sql = "SELECT `activity_id`, `date`, `description`, `type`  FROM `activities` ";

            StringBuilder conditions = new StringBuilder("WHERE \n\t");

            if (filters != null)
            {
                bool empty = true;
                bool first = true;

                if (filters.ActivityId != null)
                {
                    conditions.Append($"activity_id='{filters.ActivityId}'\n");
                    empty = false;
                    first = false;
                }
                if (filters.Date != null)
                {
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"date='{filters.Date}'\n");
                    empty = false;
                    first = false;
                }
                if (filters.ActivityType != null)
                {
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"type='{filters.ActivityType}'\n");
                    first = false;
                    empty = false;
                }
                if (filters.InvestigationId != null)
                {
                    if (!first)
                        conditions.Append("AND ");
                    conditions.Append($"investigation_id='{filters.InvestigationId}'\n");
                    empty = false;
                }

                if (!empty)
                    sql += conditions.ToString();
            }

            MySqlCommand cmd = new MySqlCommand(sql, DBConnection.GetInstance().Connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            List<ActivityDTO> list = new List<ActivityDTO>();

            while (reader.Read())
            {
                ActivityDTO activity = new ActivityDTO
                {
                    ActivityId = reader.GetInt64("activity_id"),
                    Date = reader.GetDateTime("date"),
                    Description = reader.GetString("description"),
                    ActivityType = (ActivityType)Enum.Parse(typeof(ActivityType), reader.GetString("type").ToUpper())
                };

                list.Add(activity);
            }
            reader.Close();
            return list;
        }
    }
}