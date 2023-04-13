
using System;

namespace TOBShelter.Types.Dto
{
    internal class DocumentCreateDTO
    {
        internal string Path { get; set; }
        internal long InvestigationId { get; set; }
    }

    internal class DocumentEditDTO
    {
        internal long Id { get; set; }
        internal string Path { get; set; }
    }

    internal class DocumentDetailsDTO: DocumentCreateDTO
    {
        internal long Id { get; set; }
    }

    internal class DocumentFilters
    {
        internal Nullable<long> Id { get; set; }
        internal string Path { get; set; }
        internal Nullable<long> InvestigationId { get; set; }
    }
}
