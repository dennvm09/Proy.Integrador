using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class DataGram : IComparer<DataGram>
    {


        private int eventType;
        private DateTime registerDate, dataGramDate;
        private int stopId, odometer, taskId, lineId, tripId, busId;
        private double latitude, longitude;
        private long dataGramId;

        public DataGram(int eventType, int stopId, int odometer, double latitude, double longitude, int taskId, int lineId, int tripId, long dataGramId,
            int busId, DateTime registerDate, DateTime dataGramDate)
        {
            this.eventType = eventType;
            this.stopId = stopId;
            this.odometer = odometer;
            this.latitude = latitude;
            this.longitude = longitude;
            this.taskId = taskId;
            this.lineId = lineId;
            this.tripId = tripId;
            this.dataGramId = dataGramId;
            this.busId = busId;
            this.registerDate = registerDate;
            this.dataGramDate = dataGramDate;
        }

        public DataGram() { }
        public int BusId { get => busId; set => busId = value; }
        public double Latitude { get => latitude; set => latitude = value; }
        public double Longitude { get => longitude; set => longitude = value; }
        public DateTime DataGramDate { get => dataGramDate; set => dataGramDate = value; }
        public long DataGramId { get => dataGramId; set => dataGramId = value; }
        public int LineId { get => lineId; set => lineId = value; }
        public int StopId { get => stopId; set => stopId = value; }

        public int Compare(DataGram x, DataGram y)
        {
            int result = 0;
            if (x.BusId > y.BusId)
            {
                result = 1;
            }
            else if (x.BusId < y.BusId)
            {
                result = -1;
            }
            return result;
        }
    }
}
