using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOBShelter.Types.Base;
using TOBShelter.Types.Dto;

namespace TOBShelter.Types.Dto
{
    public class InvestigatorCreateDTO : PersonCreateDTO
    {
        public bool Available { get; set; }
        public bool InOperation { get; set; }

        private string _businessSector;

        public string BusinessSector
        {
            get { return _businessSector; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Le secteur d'activité doit être renseigné.");
                _businessSector = value;
            }
        }

        public InvestigatorCreateDTO(
            IdentityTitle title,
            string name,
            string firstName,
            string numRoute,
            RouteType routeType,
            string routeName,
            string postalCode,
            string city,
            bool available,
            bool inOperation,
            string businessSector)
            : base(title, name, firstName, numRoute, routeType, routeName, postalCode, city)
        {
            Available = available;
            InOperation = inOperation;
            BusinessSector = businessSector;
        }
    }

    public class InvestigatorDTO : PersonDTO
    {
        public bool Available { get; set; }
        public bool InOperation { get; set; }
        public int NbInvestigations { get; set; }
    }

    public class InvestigatorEditDTO : PersonEditDTO
    {
        public Nullable<bool> Available { get; set; }
        public Nullable<bool> InOperation { get; set; }
        public string BusinessSector { get; set; }
    }

    public class InvestigatorDetailsDTO : PersonDetailsDTO
    {
        public bool Available { get; set; }
        public bool InOperation { get; set; }
        public string BusinessSector { get; set; }

        public InvestigatorDetailsDTO(PersonDetailsDTO personDetailsDTO)
        {
            Id = personDetailsDTO.Id;
            Title = personDetailsDTO.Title;
            Name = personDetailsDTO.Name;
            FirstName = personDetailsDTO.FirstName;
            Mobile = personDetailsDTO.Mobile;
            Home = personDetailsDTO.Home;
            Email = personDetailsDTO.Email;
            NumRoute = personDetailsDTO.NumRoute;
            RouteType = personDetailsDTO.RouteType;
            RouteName = personDetailsDTO.RouteName;
            PostalCode = personDetailsDTO.PostalCode;
            City = personDetailsDTO.City;
        }
    }

    public class InvestigatorFilters : PersonFilters
    {
        public Nullable<bool> Available { get; set; }
        public Nullable<bool> InOperation { get; set; }
    }
}