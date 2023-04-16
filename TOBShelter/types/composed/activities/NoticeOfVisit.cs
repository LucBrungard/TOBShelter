using System;

namespace TOBShelter.Types.Composed.Activities
{
    public class NoticeOfVisit : Activity
    {
        public NoticeOfVisit(DateTime date, string description, string investigation) : base(date, description, investigation) { }
    }
}
