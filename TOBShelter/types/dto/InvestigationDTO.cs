
using System;
using System.Collections.Generic;
using TOBShelter.Types.Base;
using TOBShelter.Types.Composed;

namespace TOBShelter.Types.Dto
{
    public class InvestigationCreateDTO
    {
        public long Id { get; set; }

        private string _title;
        public string Title {
            get { return _title; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Le titre de l'enquête doit être renseigné.");
                _title = value;
            }
        }

        private long _complaignantId;
        public long ComplainantId {
            get { return _complaignantId; }
            set
            {
                if (String.IsNullOrEmpty(value.ToString()))
                    throw new ArgumentException("Le plaignant doit être renseigné.");
                _complaignantId = value;
            }
        }

        private long _offenderId;
        public long OffenderId {
            get { return _offenderId; }
            set
            {
                if (String.IsNullOrEmpty(value.ToString()))
                    throw new ArgumentException("L'infractaire doit être renseigné.");
                _offenderId = value;
            }
        }

        private string _reason;
        public string Reason {
            get { return _reason; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Le motif doit être renseigné.");
                _reason = value;
            }
        }

        private long _investigatorId;
        public long InvestigatorId {
            get { return _investigatorId; }
            set
            {
                if (String.IsNullOrEmpty(value.ToString()))
                    throw new ArgumentException("L'enquêteur titulaire doit être renseigné.");
                _investigatorId = value;
            }
        }

        private List<Animal> _animals;
        public List<Animal> Animals {
            get { return _animals; }
            set
            {
                if (value.Count == 0)
                    throw new ArgumentException("Au moins un animal doit être renseigné.");
                _animals = value;
            }
        }
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
        public Nullable<DateTime> LastModification { get; set; }
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
        public Nullable<DateTime> LastModification { get; set; }
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
