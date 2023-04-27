using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOBShelter.Types.Base;

namespace TOBShelter.Types.Dto
{
    internal class ActivityDTOCreate
    {
        internal string Date { get; set; }
        internal string Description { get; set; }
        internal ActivityType ActivityType { get; set; }
        internal long InvestigationId { get; set; }
        internal string[] Links { get; set; }

        internal ActivityDTOCreate(string date, string description, ActivityType activityType, long investigationId, string[] links)
        {
            if ((activityType != ActivityType.PHOTO) && (links != null))
                throw new ArgumentException("Only photos can have links");

            Date = date;
            Description = description;
            ActivityType = activityType;
            InvestigationId = investigationId;
            Links = Links;
        }
    }

    internal class ActivityDTOEdit
    {
        internal long Id { get; set; }
        internal Nullable<DateTime> Date { get; set; }
        internal string Description { get; set; }
        internal Nullable<ActivityType> ActivityType { get; set; }
        internal Nullable<long> InvestigationId { get; set; }
        internal string[] Links { get; set; }
    }

    internal class ActivityDTO
    {
        internal long ActivityId { get; set; }
        internal DateTime Date { get; set; }
        internal string Description { get; set; }
        internal ActivityType ActivityType { get; set; }
    }

    internal class ActivityDTODetails
    {
        internal long ActivityId { get; set; }
        internal DateTime Date { get; set; }
        internal string Description { get; set; }
        internal ActivityType ActivityType { get; set; }
        internal List<string> Links { get; set; }
    }

    internal class ActivityFilters
    {
        internal Nullable<long> ActivityId { get; set; }
        internal Nullable<DateTime> Date { get; set; }
        internal Nullable<ActivityType> ActivityType { get; set; }
        internal Nullable<long> InvestigationId { get; set; }
    }
}
