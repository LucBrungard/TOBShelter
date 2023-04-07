using System;

namespace TOBShelter.Types.Composed.Activities
{
    internal class Visit : Activity
    {
        internal Visit(DateTime date, string description, string investigation) : base(date, description, investigation)
        {
        }
    }
}