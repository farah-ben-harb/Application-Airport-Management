using AM.Core.Domain; // pour accéder à Flight
using System;
namespace AM.Core.Extensions
{
    public static class FlightExtensions
    {
        public static int GetDelay(this Flight flight)
        {
            int realDuration = (int)(flight.EffectiveArrival - flight.FlightDate).TotalMinutes;

            int delay = realDuration - flight.EstimateDuration;

            return delay;
        }
    }
}
