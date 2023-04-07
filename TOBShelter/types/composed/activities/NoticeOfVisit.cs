using System;

namespace Projet_Ortega_Thil_Brungard.Types.Composed.Activities
{
    internal class NoticeOfVisit : Activity
    {
        internal NoticeOfVisit(DateTime date, string description, string investigation) : base(date, description, investigation) { }
    }
}
