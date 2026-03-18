using AM.Core.Domain;
using System;
using System.Collections.Generic;

namespace AM.Core.Services
{
    public interface IFlightService // tp 3 : (Domain ↔ Service ↔ Console
    {
        IList<DateTime> GetFlightDates(string destination);

        void ShowFlightDetails(Plane plane);

        int GetWeeklyFlightNumber(DateTime startDate);
    }
}
