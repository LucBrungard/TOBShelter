using System;

namespace Projet_Ortega_Thil_Brungard.Types.Composed.Activities
{
    internal class Commentary : Activity
    {
        internal Commentary(DateTime date, string description, string investigation) : base(date, description, investigation)
        {
        }
    }
}