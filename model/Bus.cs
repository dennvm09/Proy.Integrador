using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Bus
    {

        private int busId;
        private double longitude;
        private double latitude;
        private DateTime dataGramDate;
        private int idLine;
        private int stopId;

        public Bus(int busId, double longitude, double latitude, DateTime dataGramDate, int idLine, int stopId)
        {
            this.busId = busId;
            this.longitude = longitude;
            this.latitude = latitude;
            this.dataGramDate = dataGramDate;
            this.idLine = idLine;
            this.stopId = stopId;
        }

        public int BusId { get => busId; set => busId = value; }
        public double Longitude { get => longitude; set => longitude = value; }
        public double Latitude { get => latitude; set => latitude = value; }
        public DateTime DataGramDate { get => dataGramDate; }
        public int IdLine { get => idLine; set => idLine  = value; }

    }
}
