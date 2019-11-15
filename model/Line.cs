using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{

    public class Line
    {
        private int lineId;
        private int planVersion;
        private string shortName;
        private string descripcion;

        public Line(int lineId, int planVersion, string shortName, string descripcion) {
            this.lineId = lineId;
            this.planVersion = planVersion;
            this.shortName = shortName;
            this.descripcion = descripcion;
        }

        public int LineId { get => lineId; set => lineId = value; }
        public int PlanVersion { get => LineId; set => lineId = value; }
        public string ShortName { get => shortName; set => shortName = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public string toString() {
            return shortName + ": " + descripcion;
        }

    }
}
