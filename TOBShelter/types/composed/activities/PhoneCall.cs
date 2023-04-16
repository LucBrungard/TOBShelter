using System;

namespace TOBShelter.Types.Composed.Activities
{
    public class PhoneCall : Activity
    {
        public PhoneCall(DateTime date, string description, string investigation) : base(date, description, investigation)
        {
        }
    }
}