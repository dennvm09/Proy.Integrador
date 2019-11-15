using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Arc
    {
        private int arcId;
        private int stopIdStart;
        private int stopIdEnd;
        private string startPoint;
        private string endPoint;
        private int length;
        private int time;
        private int planVersionId;

        public Arc(int arcId, int stopIdStart, int stopIdEnd, string startPoint, string endPoint, int length)
        {
            this.arcId = arcId;
            this.stopIdStart = stopIdStart;
            this.stopIdEnd = stopIdEnd;
            this.startPoint = startPoint;
            this.endPoint = endPoint;
            this.length = length;
        }
        public int ArcId { get=>arcId; set=>ArcId=value; }
        public int StopIdStart { get => stopIdStart; set => stopIdStart = value; }
        public int StopIdEnd { get => stopIdEnd; set => stopIdEnd = value; }
        public int Time { get => time; set => time = value; }

    }
}
