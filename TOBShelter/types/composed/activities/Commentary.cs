using System;

namespace TOBShelter.Types.Composed.Activities
{
    internal class Commentary : Activity
    {
        internal Commentary(DateTime date, string description, string investigation) : base(date, description, investigation)
        {
        }
    }
}