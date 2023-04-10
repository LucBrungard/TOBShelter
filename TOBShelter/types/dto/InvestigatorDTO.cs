using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOBShelter.Types.Base;
using TOBShelter.Types.Dto;

namespace TOBShelter.Types.Dto
{
    internal class InvestigatorCreateDTO : PersonCreateDTO
    {
        internal bool Available { get; set; }
        internal bool InOperation { get; set; }
        internal string BusinessSector { get; set; }
        internal InvestigatorCreateDTO(
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

    internal class InvestigatorDTO : PersonDTO
    {
        internal bool Available { get; set; }
        internal bool InOperation { get; set; }
        internal int NbInvestigations { get; set; }
    }

    internal class InvestigatorEditDTO : PersonEditDTO
    {
        internal Nullable<bool> Available { get; set; }
        internal Nullable<bool> InOperation { get; set; }
        internal string BusinessSector { get; set; }
    }

    internal class InvestigatorDetailsDTO : PersonDetailsDTO
    {
        internal bool Available { get; set; }
        internal bool InOperation { get; set; }
        internal HashSet<InvestigationDTO> Investigations { get; set; }
        internal string BusinessSector { get; set; }

        internal InvestigatorDetailsDTO(PersonDetailsDTO personDetailsDTO)
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

    internal class InvestigatorFilters : PersonFilters
    {
        internal Nullable<bool> Available { get; set; }
        internal Nullable<bool> InOperation { get; set; }
    }
}
