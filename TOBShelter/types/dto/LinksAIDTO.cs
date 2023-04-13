
using System;

namespace TOBShelter.Types.Dto
{
    internal class LinksAICreateDTO
    {
        internal long InvestigationId { get; set; }
        internal long AnimalId { get; set; }
    }

    internal class LinksAIRemoveDTO : LinksAICreateDTO { }

    internal class LinksAIDetailsDTO : LinksAICreateDTO { }

    internal class LinksAIFilters
    {
        internal Nullable<long> InvestigationId { get; set; }
        internal Nullable<long> AnimalId { get; set; }
    }
}
