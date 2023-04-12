
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TOBShelter.Types.Base;
using TOBShelter.Types.Composed;

namespace TOBShelter.Types.Dto
{
    internal class InvestigationCreateDTO
    {
        internal long Id { get; set; }
        internal string Title { get; set; }
        internal long ComplainantId { get; set; }
        internal long OffenderId { get; set; }
        internal string Reason { get; set; }
        internal long InvestigatorId { get; set; }
        internal List<Animal> Animals { get; set; }
        internal string Notice { get; set; }
        internal bool Closed { get; set; }
    }
    internal class InvestigationDTO
    {
        internal long Id { get; set; }
        internal string Title { get; set; }
        internal IdentityTitle InvestigatorTitle { get; set; }
        internal string InvestigatorName { get; set; }
        internal string InvestigatorFirstName { get; set; }
        internal DateTime LastModification { get; set; }
        internal bool Closed { get; set; }
    }
    internal class InvestigationEditDTO
    {
        internal long Id { get; set; }
        internal string Title { get; set; }
        internal Nullable<long> InvestigatorId { get; set; }
        internal string Notice { get; set; }
        internal Nullable<bool> Closed { get; set; }
    }

    internal class InvestigationDetailsDTO
    {
        internal long Id { get; set; }
        internal string Title { get; set; }
        internal PersonDTO Complainant { get; set; }
        internal PersonDTO Offender { get; set; }
        internal string Reason { get; set; }
        internal InvestigatorDTO Investigator { get; set; }
        internal List<Animal> Animals { get; set; }
        internal string Notice { get; set; }
        internal bool Closed { get; set; }
    }

    internal class InvestigationFilters
    {
        internal Nullable<long> Id { get; set; }
        internal string Title { get; set; }
        internal Nullable<long> ComplainantId { get; set; }
        internal Nullable<long> OffenderId { get; set; }
        internal Nullable<long> InvestigatorId { get; set; }
        internal Nullable<bool> Closed { get; set; }
    }
}
