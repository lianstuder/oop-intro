using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReisedauerMond
{
    class Travel
    {
        private int travelSpeed;
        private bool timeAsDays;

        public Travel(string travelSpeed, bool timeAsDays)
        {
            if (!int.TryParse(travelSpeed, out this.travelSpeed))
            {
                throw new Exception("Input has to be a string.");
            }
            this.timeAsDays = timeAsDays;
        }

        public int GetTravelTime()
        {
            const int lunarDistance_km = 384402;
            int travelTime = lunarDistance_km / travelSpeed; // in hours
            if (timeAsDays) travelTime /= 24; // Conditional conversion to days
            return travelTime;
        }
    }
}
