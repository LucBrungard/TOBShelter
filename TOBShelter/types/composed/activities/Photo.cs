using System;
using System.Collections.Generic;

namespace TOBShelter.Types.Composed.Activities
{
    public class Photo : Activity
    {
        private HashSet<string> _links;
        public Photo(DateTime date, string description, string investigation, HashSet<string> links) : base(date, description, investigation)
        {
            _links = links ?? new HashSet<string>();
        }
    }
}