using Google.Protobuf.WellKnownTypes;
using System;
using TOBShelter.Types.Base;

namespace TOBShelter.Types.Composed
{
    internal class Route
    {
        private string _num;
        internal RouteType Type;
        private string _name;

        internal string Num
        {
            get { return _num; }
            set
            {
                // TODO Regex for num
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException($"Can't be null or empty", nameof(_num));
                _num = value;
            }
        }

        internal string Name
        {
            get { return _name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException($"Can't be null or empty", nameof(_name));
                _name = value;
            }
        }

        internal Route(string num, RouteType type, string name)
        {
            Num = num;
            Type = type;
            Name = name;
        }
    }
}