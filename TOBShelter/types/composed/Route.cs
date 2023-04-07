using Projet_Ortega_Thil_Brungard.Types.Base;

namespace Projet_Ortega_Thil_Brungard.Types.Composed
{
    internal class Route
    {
        private string _num;
        private RouteType _type;
        private string _name;

        internal Route(string num, RouteType type, string name)
        {
            _num = num;
            _type = type;
            _name = name;
        }
    }
}