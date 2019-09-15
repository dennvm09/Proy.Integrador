using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{

    public class Principal
    {
        private List<Stop> stops;

        public Principal()
        {
            stops = new List<Stop>();
        }

        public List<Stop> Stops { get => stops; set => stops = value; }

        public void addStops() {
            StreamReader leer = new StreamReader(Path.GetFullPath("stops.txt"));
            //StreamReader leer = new StreamReader(Path.GetFullPath("StopPratice.txt"));
            String line = leer.ReadLine();
            Stop newS = null;

            try
            {
                while (line != null) {
                    String[] lineS = line.Split(',');
                    if (lineS.Length == 8) {
                        newS = new Stop(lineS[0], Int32.Parse(lineS[1]), lineS[2], lineS[3], Double.Parse(lineS[4]), Double.Parse(lineS[5]), Double.Parse(lineS[6]), Double.Parse(lineS[7]));
                        stops.Add(newS);
                        Console.WriteLine(newS.StopId);
                    }
                }
                line = leer.ReadLine();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }

        }

        public Stop SearchStops(String IDStop) {

            Stop search = null;
            int left, right, means;
            left = 0;
            right = stops.Count - 1;
            means = (right - left) / 2;

            while (IDStop != stops[means].StopId && left < right) {
                int comparations = IDStop.CompareTo(stops[means].StopId);

                if (comparations > 0) {
                    left = means + 1;
                } else if (comparations < 0) {
                    right = means - 1;
                }
                means = (right + right) / 2;
            }
            if (IDStop == stops[means].StopId)
            {
                search = stops[means];
            }
            else {
                Console.WriteLine("Stop not found");
            }

            Console.WriteLine(search.StopId);
            return search;
        }

       // public static void methodTest1()
        //{ 
          //  Console.WriteLine("methodTest1 is running");
       // }

        //static void Main()
        //{
        //}
    }
}
