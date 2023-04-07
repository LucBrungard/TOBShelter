using System;

namespace TOBShelter.Types.Composed.Activities
{
    internal class PhoneCall : Activity
    {
        internal PhoneCall(DateTime date, string description, string investigation) : base(date, description, investigation)
        {
        }
    }
}