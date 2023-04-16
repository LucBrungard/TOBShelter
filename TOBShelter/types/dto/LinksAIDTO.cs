
using System;

namespace TOBShelter.Types.Dto
{
    public class LinksAICreateDTO
    {
        public long InvestigationId { get; set; }
        public long AnimalId { get; set; }
    }

    public class LinksAIRemoveDTO : LinksAICreateDTO { }

    public class LinksAIDetailsDTO : LinksAICreateDTO { }

    public class LinksAIFilters
    {
        public Nullable<long> InvestigationId { get; set; }
        public Nullable<long> AnimalId { get; set; }
    }
}
