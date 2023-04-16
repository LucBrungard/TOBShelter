using System;

namespace TOBShelter.Types.Composed.Activities
{
    public class Commentary : Activity
    {
        public Commentary(DateTime date, string description, string investigation) : base(date, description, investigation)
        {
        }
    }
}