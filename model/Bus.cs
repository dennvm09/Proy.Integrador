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

        public Bus(int busId, double longitude, double latitude, DateTime dataGramDate)
        {
            this.busId = busId;
            this.longitude = longitude;
            this.latitude = latitude;
            this.dataGramDate = dataGramDate;
        }

        public int BusId { get => busId; set => busId = value; }
        public double Longitude { get => longitude; set => longitude = value; }
        public double Latitude { get => latitude; set => latitude = value; }
        public DateTime DataGramDate { get => dataGramDate; }


    }
}
