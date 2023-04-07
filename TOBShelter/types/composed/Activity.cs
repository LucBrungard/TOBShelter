using System;

namespace Projet_Ortega_Thil_Brungard.Types.Composed
{
    internal class Activity
    {
        private protected DateTime _date;
        private protected string _description;
        private protected string _investigation;

        internal Activity(DateTime date, string description, string investigation)
        {
            _date = date;
            _description = description;
            _investigation = investigation;
        }
    }
}