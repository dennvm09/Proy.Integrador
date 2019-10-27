using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Stop
    {
        private String stopId;
        private int planVersionId;
        private String shortName;
        private String longName;
        private int gpsX;
        private int gpsY;
        private double longit;
        private double latit;

        public Stop(String stopId, int planVersionId, String shortName, String longName, int gpsX, int gpsY, double longit, double latit)
        {
            this.stopId = stopId;
            this.planVersionId = planVersionId;
            this.shortName = shortName;
            this.longName = longName;
            this.gpsX = gpsX;
            this.gpsY = gpsY;
            this.longit = longit;
            this.latit = latit;
        }

        public String StopId { get => stopId; set => stopId = value; }
        public String ShortName { get => shortName; set => shortName = value; }
        public String LongName { get => longName; set => longName = value; }
        public double Longit { get => longit; set => Longit = value; }
        public double Latit { get => latit; set => latit = value; }


    }
}