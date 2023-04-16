
using System;
using System.Collections.Generic;
using TOBShelter.Types.Base;
using TOBShelter.Types.Composed;

namespace TOBShelter.Types.Dto
{
    public class InvestigationCreateDTO
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public long ComplainantId { get; set; }
        public long OffenderId { get; set; }
        public string Reason { get; set; }
        public long InvestigatorId { get; set; }
        public List<Animal> Animals { get; set; }
        public List<DocumentCreateDTO> Documents { get; set; }
        public string Notice { get; set; }
        public bool Closed { get; set; }
    }
    public class InvestigationDTO
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public IdentityTitle InvestigatorTitle { get; set; }
        public string InvestigatorName { get; set; }
        public string InvestigatorFirstName { get; set; }
        public DateTime LastModification { get; set; }
        public bool Closed { get; set; }
    }
    public class InvestigationEditDTO
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public Nullable<long> InvestigatorId { get; set; }
        public string Notice { get; set; }
        public Nullable<bool> Closed { get; set; }
    }

    public class InvestigationDetailsDTO
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public PersonDTO Complainant { get; set; }
        public PersonDTO Offender { get; set; }
        public string Reason { get; set; }
        public InvestigatorDTO Investigator { get; set; }
        public List<Animal> Animals { get; set; }
        public List<DocumentDetailsDTO> Documents { get; set; }
        public string Notice { get; set; }
        public bool Closed { get; set; }
    }

    public class InvestigationFilters
    {
        public Nullable<long> Id { get; set; }
        public string Title { get; set; }
        public Nullable<long> ComplainantId { get; set; }
        public Nullable<long> OffenderId { get; set; }
        public Nullable<long> InvestigatorId { get; set; }
        public Nullable<bool> Closed { get; set; }
    }
}
