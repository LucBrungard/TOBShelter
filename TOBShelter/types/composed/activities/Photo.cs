using System;
using System.Collections.Generic;

namespace Projet_Ortega_Thil_Brungard.Types.Composed.Activities
{
    internal class Photo : Activity
    {
        private HashSet<string> _links;
        internal Photo(DateTime date, string description, string investigation, HashSet<string> links) : base(date, description, investigation)
        {
            _links = links ?? new HashSet<string>();
        }
    }
}