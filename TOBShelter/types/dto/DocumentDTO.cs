
using System;

namespace TOBShelter.Types.Dto
{
    public class DocumentCreateDTO
    {
        public string Path { get; set; }
        public Nullable<long> InvestigationId { get; set; }
    }

    public class DocumentEditDTO
    {
        public long Id { get; set; }
        public string Path { get; set; }
    }

    public class DocumentDetailsDTO: DocumentCreateDTO
    {
        public long Id { get; set; }
    }

    public class DocumentFilters
    {
        public Nullable<long> Id { get; set; }
        public string Path { get; set; }
        public Nullable<long> InvestigationId { get; set; }
    }
}
