using System;

namespace TOBShelter.Types.Composed
{
    public class Activity
    {
        private protected DateTime _date;
        private protected string _description;
        private protected string _investigation;

        public Activity(DateTime date, string description, string investigation)
        {
            _date = date;
            _description = description;
            _investigation = investigation;
        }
    }
}