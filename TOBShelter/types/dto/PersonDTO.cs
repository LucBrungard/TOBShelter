using TOBShelter.Types.Base;

namespace TOBShelter.Types.Dto
{
    internal class PersonDetailsDTO
    {
        internal IdentityTitle Title { get; set; }
        internal string Name { get; set; }
        internal string FirstName { get; set; }
        internal string Mobile { get; set; }
        internal string Home { get; set; }
        internal string Email { get; set; }
        internal string NumRoute { get; set; }
        internal RouteType RouteType { get; set; }
        internal string RouteName { get; set; }
        internal string PostalCode { get; set; }
        internal string City { get; set; }
    }

    internal class PersonEditDTO
    {
        internal string Mobile { get; set; }
        internal string Home { get; set; }
        internal string Email { get; set; }
        internal string NumRoute { get; set; }
        internal RouteType RouteType { get; set; }
        internal string RouteName { get; set; }
        internal string PostalCode { get; set; }
        internal string City { get; set; }
    }
}
