using System;

namespace TOBShelter.Types.Composed.Activities
{
    public class Visit : Activity
    {
        public Visit(DateTime date, string description, string investigation) : base(date, description, investigation)
        {
        }
    }
}