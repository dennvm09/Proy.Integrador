﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace model
{

    public class Principal
    {
        private List<Stop> stops;
        private List<Stop> streetStops;
        private List<Stop> terminalStops;

        private List<DataGram> datagrams;
        private Hashtable buses;


        public Principal()
        {
            stops = new List<Stop>();
            buses = new Hashtable();

            datagrams = new List<DataGram>();
            streetStops = new List<Stop>();
            terminalStops = new List<Stop>();
            Thread t = new Thread(new ThreadStart(initilizeData));
            t.Start();


            //List<DataGram> aux = getListOfBussDatagrams(1051);
            /*
            getsetOfBuses();
            Console.WriteLine(buses.Count);
            Console.WriteLine(datagrams.Count);*/
            /*
            for (int i = 0; i < aux.Count; i++)
            {
                Console.WriteLine(aux.ElementAt(i).DataGramId + " " + aux.ElementAt(i).Latitude + " " + aux.ElementAt(i).Longitude);
            }*/
        }

        public List<Stop> Stops { get => stops; set => stops = value; }
        public List<Stop> StreetStops { get => streetStops; set => streetStops = value;}
        public List<Stop> TerminalStops { get => terminalStops; set => terminalStops = value; }

        public void initilizeData()
        {
            loadDataGramData();
            makeSetOfBuses();
        }

        public void loadDataGramData()
        {
            string path = @"..\..\..\Data\DATAGRAMS.txt";
            string fullPath = Path.GetFullPath(path);

            StreamReader read = new StreamReader(fullPath);

            try
            {
                read.ReadLine();
                String line = read.ReadLine();
                DataGram datagramAux = null;

                while (line != null)
                {
                    String[] lineS = line.Split(',');

                    if ((lineS.Length == 12) && !(lineS[4].Equals("-1") || lineS[5].Equals("-1")))
                    {

                        int eventType = Int32.Parse(lineS[0]);
                        int stopId = Int32.Parse(lineS[2]);
                        int odometer = Int32.Parse(lineS[3]);
                        int taskId = Int32.Parse(lineS[6]);
                        int lineId = Int32.Parse(lineS[7]);
                        int tripId = Int32.Parse(lineS[8]);
                        long dataGramId = Convert.ToInt64(lineS[9]);
                        int busId = Int32.Parse(lineS[11]);
                        double latitude = Double.Parse(lineS[4].Insert(1, "."));
                        double longitude = Double.Parse(lineS[5].Insert(3, "."));

                        String[] date1 = lineS[1].Split('-');
                        var registerDate = new DateTime(Int32.Parse(date1[2]), giveMonthByNumber((date1[1])), Int32.Parse(date1[0]));

                        String[] lineS2 = lineS[10].Split(' ');
                        String[] date2 = lineS2[0].Split('-');
                        String[] time = lineS2[1].Split('.');

                        var datagramDate = new DateTime(Int32.Parse(date2[2]), giveMonthByNumber((date2[1])), Int32.Parse(date2[0]), Int32.Parse(time[0]), Int32.Parse(time[1]), Int32.Parse(time[2]));

                        datagramAux = new DataGram(eventType, stopId, odometer, latitude, longitude, taskId, lineId, tripId, dataGramId, busId, registerDate, datagramDate);
                        datagrams.Add(datagramAux);
                    }
                    line = read.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /**
        * this method give the number corresponding to the month entered
        * 
        * INCOMPLETED METHOD. IT WORKS JUST IN SOME CASES
        */
        public int giveMonthByNumber(string month)
        {
            int num = 0;

            if (month.Equals("NOV"))
            {
                num = 11;
            }
            else if (month.Equals("JUN"))
            {
                num = 6;
            }
            return num;
        }

        public List<Bus> getBusElementAt(String busId)
        {
            int id = Convert.ToInt32(busId);
            List<Bus> aux = (List<Bus>)buses[id];

            return aux;
        }

        public void makeSetOfBuses()
        {
            List<Bus> setBus = new List<Bus>();
            List<DataGram> copy = datagrams;
            sortDataGramsByBusId(copy);
            int cont = 0;
            int id = 0;
            int i = 0;

            while (cont < copy.Count)
            {
                i = copy[id].BusId;
                //  Console.WriteLine("I= " + i);
                if (copy[cont].BusId == i)
                {
                    //  Console.WriteLine("cont= " + copy[cont].BusId);
                    Bus b = new Bus(copy[cont].BusId, copy[cont].Longitude, copy[cont].Latitude, copy[cont].DataGramDate);
                    setBus.Add(b);
                }
                else
                {
                    buses.Add(i, setBus);
                    setBus = new List<Bus>();
                    id = cont;
                }
                cont++;
            }

        }

        public List<DataGram> getListOfBussDatagrams(int busId)
        {
            List<DataGram> buses = new List<DataGram>();
            List<DataGram> copy = datagrams;
            // sortDataGramsByBusId(copy);
            Boolean bandera = false;

            while (bandera == false)
            {
                DataGram aux = searchDataGramByBusId(copy, busId);
                if (aux != null)
                {
                    buses.Add(aux);
                }
                else bandera = true;

            }
            //sortByDateTime(buses);
            return buses;
        }

        public DataGram searchDataGramByBusId(List<DataGram> list, int busId)
        {

            List<DataGram> aux = list;
            sortDataGramsByBusId(list);
            DataGram elem = null;

            int center = 0;
            int max = aux.Count - 1;
            int min = 0;

            while (min <= max)
            {
                center = (max + min) / 2;
                if (aux.ElementAt(center).BusId == busId)
                {
                    elem = aux.ElementAt(center);
                    list.RemoveAt(center);
                    break;
                }
                else if (aux.ElementAt(center).BusId > busId)
                {
                    max = center - 1;
                }
                else
                    min = center + 1;

            }
            return elem;
        }

        public void readDataGramsData(string path)
        {
        }

        public void test()
        {
            /*
            Console.WriteLine(stops.Count);
            foreach (var aux in stops)
            {
                Console.WriteLine(aux.StopId+"\t"+aux.Latit + "\t" + aux.Longit);
            }*/
            // loadDataGramData();
            /*
             Console.WriteLine(datagrams.Count);

             List<DataGram> aux = datagrams;
             sortDataGramsByBusId(aux);
             for (int i = 0; i < aux.Count; i++)
             {
                 Console.WriteLine(aux.ElementAt(i).BusId);
             }*/

            makeSetOfBuses();
            List<Bus> aux = (List<Bus>)buses[1051];



            Console.WriteLine(aux.Count);
            Console.WriteLine(aux.ElementAt(0).BusId + " " + aux.ElementAt(0).Longitude);
            Console.WriteLine(aux.ElementAt(1).BusId + " " + aux.ElementAt(1).Longitude);
            Console.WriteLine(aux.ElementAt(2).BusId + " " + aux.ElementAt(2).Longitude);
            Console.WriteLine(aux.ElementAt(3).BusId + " " + aux.ElementAt(3).Longitude);
            Console.WriteLine(aux.ElementAt(4).BusId + " " + aux.ElementAt(4).Longitude);

            /*
            for (int i = 0; i < aux.Count; i++)
            {
                Console.WriteLine(aux.ElementAt(i).DataGramId+" "+aux.ElementAt(i).Latitude+" "+aux.ElementAt(i).Longitude);
            }*/


        }

        public void sortDataGramsByBusId(List<DataGram> list)
        {
            List<DataGram> aux = list;
            DataGram dg = new DataGram();
            list.Sort((m, n) => dg.Compare(m, n));


            //return aux;
        }

        public void sortDatagramsByDateTime(List<DataGram> list)
        {

            List<DataGram> aux = list;
            aux.Sort((m, n) => DateTime.Compare(m.DataGramDate, n.DataGramDate));
        }

        public void sortBusesByDateTime(List<Bus> list)
        {
            List<Bus> aux = list;
            aux.Sort((m, n) => DateTime.Compare(m.DataGramDate, n.DataGramDate));
        }




        public void addStops() {
            //StreamReader leer = new StreamReader(Path.GetFullPath("stops.txt"));
            //StreamReader leer = new StreamReader(Path.GetFullPath("StopPratice.txt"));

           // Console.WriteLine(path);
            StreamReader leer = new StreamReader("Data/stops.txt");
           
            try
            {
                leer.ReadLine();
                String line = leer.ReadLine();
                
                Stop newS = null;
                while (line != null) {

                    line=line.TrimEnd('"');
                    String[] lineS = line.TrimStart('"').Split(',');

                    //Console.WriteLine(line);

                    if (lineS.Length == 8) {
                        newS = new Stop(lineS[0], Int32.Parse(lineS[1]), lineS[2], lineS[3], Convert.ToInt32(lineS[4]), Convert.ToInt32(lineS[5]), double.Parse(lineS[6], CultureInfo.InvariantCulture), double.Parse(lineS[7], CultureInfo.InvariantCulture));
                        stops.Add(newS);
                        classificationStops(newS);
                        //Console.WriteLine(newS.StopId);
                    }
                    line = leer.ReadLine();
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }

        }

        public void classificationStops(Stop sortOut) {

            if (sortOut != null) {
                String shortName = sortOut.ShortName;
                if (shortName != null && shortName.Length > 2) {
                    Boolean isNumber = char.IsLetter(shortName[2]);
                    if (isNumber == false)
                    {
                        streetStops.Add(sortOut);
                    }
                    else if (shortName[2] == 'V')
                    {
                        isNumber = char.IsLetter(shortName[3]);
                        if (isNumber == false)
                        {
                            streetStops.Add(sortOut);
                        }
                    }
                    else {
                        terminalStops.Add(sortOut);
                    }
                }
            }
        }

        public void test1()
        {
            Console.WriteLine(stops.Count);
            foreach (var aux in stops)
            {
                Console.WriteLine(aux.StopId+"\t"+aux.Latit + "\t" + aux.Longit);
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

      
       
        static void Main()
        {
        }
    }
}
