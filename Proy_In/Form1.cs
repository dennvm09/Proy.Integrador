using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Threading;
using model;
using System.Collections;
using System.Diagnostics;

namespace Proy_In
{
    public partial class Form1 : Form
    {

        //VALENTINAAAAA, NO OLVIDES HACER LO DE ELIMINAR LOS OVERLAYS, YA SABES CÓMO (: -DENNYS

        private GMapOverlay markOv;

        private GMapOverlay gmapStreet;
        private GMapOverlay gmapStations;
        private GMapOverlay gmapReserves;


        private GMapOverlay GZ0;
        private GMapOverlay GZ1;
        private GMapOverlay GZ2;
        private GMapOverlay GZ3;
        private GMapOverlay GZ4;
        private GMapOverlay GZ5;
        private GMapOverlay GZ6;
        private GMapOverlay GZ7;
        private GMapOverlay GZ8;

        private GMapOverlay polygon;



        private Principal ppal;

        private int preEstaciones = 0;
        private int preCalle = 0;
        private int preZona = 0;
        private int preReservas = 0;
        private int paradaEnZona = 0;

        private int poly0 = 0;
        private int poly1 = 0;
        private int poly2 = 0;
        private int poly3 = 0;
        private int poly4 = 0;
        private int poly5 = 0;
        private int poly6 = 0;
        private int poly7 = 0;
        private int poly8 = 0;

        private double zoom = 0;

        private delegate void SafeCallDelegate(int h);
        private Button btCompleteSimulation, btCustomSimulationt;
        private Label lbH, lbM, lbS;
        private TextBox tbTimeHours, tbHour, tbMin, tbSec;
        private Thread simulationThread;
        private Hashtable marks;


        public Form1()
        {
            tbTimeHours = new TextBox
            {
                Location = new Point(822, 350),
                Size = new Size(40, 22),
                Text = "HRS",
                Visible = false,

            };
            tbTimeHours.Click += new EventHandler(TbTimeHours_Click);

            tbHour = new TextBox
            {
                Location = new Point(908, 350),
                Size = new Size(30, 22),
                Text = "HH",
                Visible = false,
            };
            tbHour.Click += new EventHandler(TbHour_Click);

            tbMin = new TextBox
            {
                Location = new Point(960, 350),
                Size = new Size(30, 22),
                Text = "MM",
                Visible = false,
            };
            tbMin.Click += new EventHandler(TbMin_Click);

            tbSec = new TextBox
            {
                Location = new Point(1010, 350),
                Size = new Size(30, 22),
                Text = "SS",
                Visible = false,
            };
            tbSec.Click += new EventHandler(TbSec_Click);

            btCompleteSimulation = new Button
            {
                Location = new Point(820, 350),
                Size = new Size(154, 28),
                Text = "Simulacion completa",
                Visible = false,
            };
            btCompleteSimulation.Click += new EventHandler(BtCompleteSimulation_Click);
            btCustomSimulation = new Button
            {
                Location = new Point(970, 400),
                Size = new Size(75, 23),
                Text = "Iniciar",
                Visible = false,
            };
            btCustomSimulation.Click += new EventHandler(BtCustomSimulation_Click);


            lbH = new Label
            {
                Location = new Point(733, 37),
                Size = new Size(30, 24),
                Text = "00",
                Visible = false
            };
            lbM = new Label
            {
                Location = new Point(776, 37),
                Size = new Size(30, 24),
                Text = "00",
                Visible = false
            };
            lbS = new Label
            {
                Location = new Point(826, 37),
                Size = new Size(30, 24),
                Text = "00",
                Visible = false
            };
            Controls.Add(tbTimeHours);
            Controls.Add(tbHour);
            Controls.Add(tbMin);
            Controls.Add(tbSec);
            Controls.Add(btCustomSimulation);
            Controls.Add(btCompleteSimulation);
            Controls.Add(lbH);
            Controls.Add(lbM);
            Controls.Add(lbS);



            InitializeComponent();



            marks = new Hashtable();
            ppal = new Principal();
            //ppal.addStopsAsync();
            ppal.addStops();
            markOv = new GMapOverlay("marker");
            paneZonas.Visible = false;
            paneOp1.Visible = false;
            paneOp2.Visible = false;
            timer1.Start();
        }

        private void Map_Load(object sender, EventArgs e)
        {
            map.SetPositionByKeywords("Colombia,Cali");
            actualZoom.Text = map.Zoom.ToString() + " %";

           // GMarkerGoogle mark = new GMarkerGoogle(new GMap.NET.PointLatLng(3.44327333, -76.54844800), new Bitmap("images/bus.png"));
            //markOv.Markers.Add(mark);

            /*
            GMap.NET.WindowsForms.Markers.GMarkerGoogle curPos = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new GMap.NET.PointLatLng(3.43686833, -76.54497667), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_pushpin);
            GMap.NET.MapRoute path = GMap.NET.MapProviders.GoogleMapProvider.Instance.GetRoute(new GMap.NET.PointLatLng(3.43686833, -76.54497667), new GMap.NET.PointLatLng(3.447155, -76.55863833), false, false, 15);
            GMapRoute route = new GMapRoute(path.Points, "My route");
            GMapOverlay overlayRoute = new GMapOverlay("dsf");
            overlayRoute.Routes.Clear();
            overlayRoute.Routes.Add(route);
            map.Overlays.Add(overlayRoute);*/

            /**
             * Makes routes
             */

            GMapOverlay routes = new GMapOverlay("routes");
            List<GMap.NET.PointLatLng> points = new List<GMap.NET.PointLatLng>();
            points.Add(new GMap.NET.PointLatLng(3.43686833, -76.54497667));
            points.Add(new GMap.NET.PointLatLng(3.447155, -76.55863833));
            // points.Add(new PointLatLng(48.861017, 2.330030));
            GMapRoute route = new GMapRoute(points, "A walk in the park");



            /**
             * GENERAR RUTA ABSOLUTA
             */

            //**********************
            //string p2 = System.IO.Directory.GetCurrentDirectory();
            string p3 = @"..\..\..\Data\stops.txt";

            //string exeFile = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
            //string exeDir = Path.GetDirectoryName(path1);

            Console.WriteLine("this would be the full path {0}", Path.GetFullPath(p3));

            StreamReader leer = new StreamReader(Path.GetFullPath(p3));
            String line = leer.ReadLine();
            Console.WriteLine(line);

            //**********************

            route.Stroke = new Pen(Color.Red, 3);
            routes.Routes.Add(route);
            map.Overlays.Add(routes);

            map.Overlays.Add(markOv);



        }

        public void TbTimeHours_Click(object sender, EventArgs e)
        {
            tbTimeHours.Text = "";
        }

        public void TbHour_Click(object sender, EventArgs e)
        {
            tbHour.Text = "";
        }
        public void TbMin_Click(object sender, EventArgs e)
        {
            tbMin.Text = "";
        }
        public void TbSec_Click(object sender, EventArgs e)
        {
            tbSec.Text = "";
        }

        public void BtCompleteSimulation_Click(object sender, EventArgs e)
        {

            ThreadStart delegated = new ThreadStart(startCompleteSimulation);
            simulationThread = new Thread(delegated);
            simulationThread.Start();

        }

        public void BtCustomSimulation_Click(object sender, EventArgs e)
        {
            ThreadStart delegated = new ThreadStart(startCustomSimulation);
            simulationThread = new Thread(delegated);
            simulationThread.Start();
        }

        private void SetTimeLabelHSafe(int hour)
        {
            if (lbH.InvokeRequired)
            {
                var d = new SafeCallDelegate(SetTimeLabelHSafe);
                lbH.Invoke(d, new object[] { hour });

            }
            else
            {
                lbH.Text = Convert.ToString(hour);

            }
        }
        private void SetTimeLabelMSafe(int min)
        {
            if (lbM.InvokeRequired)
            {
                var d = new SafeCallDelegate(SetTimeLabelMSafe);

                lbM.Invoke(d, new object[] { min });
            }
            else
            {
                lbM.Text = Convert.ToString(min);

            }
        }
        private void SetTimeLabelSSafe(int sec)
        {
            if (lbS.InvokeRequired)
            {
                var d = new SafeCallDelegate(SetTimeLabelSSafe);

                lbS.Invoke(d, new object[] { sec });
            }
            else
            {
                lbS.Text = Convert.ToString(sec);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
        }


        private void ActualZoom_Click(object sender, EventArgs e)
        {

        }

        private void ZoomOut_Click(object sender, EventArgs e)
        {
            map.Zoom -= 2;
            actualZoom.Text = map.Zoom.ToString() + " %";
            zoom = map.Zoom;

            if (zoom >= 17 && preEstaciones == 1)
            {
                wagonsStations();
            }
            else if (polygon != null && zoom <= 15)
            {

                polygon.Clear();
            }

        }

        private void ZoomIn_Click(object sender, EventArgs e)
        {
            map.Zoom += 2;
            actualZoom.Text = map.Zoom.ToString() + " %";
            zoom = map.Zoom;

            if (zoom >= 17 && preEstaciones == 1)  
            {
                wagonsStations();
            }
            else if (polygon != null && zoom <= 15)
            {

                polygon.Clear();
            }
        }

        private void startCustomSimulation()
        {
            int h = Convert.ToInt32(tbHour.Text);
            int m = Convert.ToInt32(tbMin.Text);
            int s = Convert.ToInt32(tbSec.Text);
            int t = Convert.ToInt32(tbTimeHours.Text);

            Console.WriteLine("here");

            int count = h + t;

            while (h < count)
            {
                Thread.Sleep(500);
                if (s > 60)
                {
                    s = 0;
                    m++;
                    if (m > 60)
                    {
                        m = 0;
                        h++;
                    }
                }

                SetTimeLabelHSafe(h);
                SetTimeLabelMSafe(m);
                SetTimeLabelSSafe(s);
                locateBusesAccordingToTime(h, m, s);

                s++;
            }

        }


        private void startCompleteSimulation()
        {
            int h = 1;
            int m = 0;
            int s = 0;
            int t = 1;

            Console.WriteLine("here");

            int count = h + t;

            while (h < count)
            {
                Thread.Sleep(500);
                if (s > 60)
                {
                    s = 0;
                    m++;
                    if (m > 60)
                    {
                        m = 0;
                        h++;
                    }
                }

                SetTimeLabelHSafe(h);
                SetTimeLabelMSafe(m);
                SetTimeLabelSSafe(s);
                locateBusesAccordingToTime(h, m, s);

                s++;
            }

        }
        /*
        private void startCustomSimulation()
        {

            int h = Convert.ToInt32(tbHour.Text);
            int m = Convert.ToInt32(tbMin.Text);
            int s = Convert.ToInt32(tbSec.Text);
            int t = Convert.ToInt32(tbTime.Text);

            int count = h + t;

            while (h < count)
            {             
                if (s > 60)
                {
                    s = 0;
                    m++;
                    if (m > 60)
                    {
                        m = 0;
                        h++;
                    }
                }
                SetTimeLabelHSafe(h);
                SetTimeLabelMSafe(m);
                SetTimeLabelSSafe(s);
                locateBusesAccordingToTime(h, m, s);

                s++;
            }
        }*/

        private void locateBusesAccordingToTime(int hour, int min, int sec)
        {
            String id = hour + "." + min + "." + sec;

            Bitmap bm = new Bitmap("images/bus.png");

            if (ppal.getBuses().ContainsKey(id))
            {

                List<Bus> buses = (List<Bus>)ppal.getBuses()[id];

                for (int j = 0; j < buses.Count; j++)
                {
                    if (marks != null)
                    {
                        if (marks.ContainsKey(buses[j].BusId))
                        {
                            GMarkerGoogle markAux = (GMarkerGoogle)marks[buses[j].BusId];
                            markAux.Position = new GMap.NET.PointLatLng(buses[j].Latitude, buses[j].Longitude);
                           
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            GMarkerGoogle markAux1 = new GMarkerGoogle(new GMap.NET.PointLatLng(buses[j].Latitude, buses[j].Longitude),bm );
                            marks.Add(buses[j].BusId, markAux1);

                            markAux1.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                            markAux1.ToolTipText = String.Format("Ruta: " + ppal.descripcionLine(buses[j].IdLine));
                            markAux1.ToolTip.TextPadding = new Size(7, 7);
                            markAux1.ToolTip.Fill = Brushes.FloralWhite;

                            markOv.Markers.Add(markAux1);
                            Console.WriteLine("efectily");
                            //Thread.Sleep(300);
                        }
                    }
                    else
                    {
                        GMarkerGoogle mark1 = new GMarkerGoogle(new GMap.NET.PointLatLng(buses[j].Latitude, buses[j].Longitude), bm);

                        marks.Add(buses[j].BusId, mark1);

                        markOv.Markers.Add(mark1);
                        // Thread.Sleep(300);

                    }
                }
            }
            else
            {
                Debug.WriteLine("Key " + id + "Not found in Hashtable buses");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ppal.test();
        }


        /**
         * este metodo era utilizado por el boton ubicar que se habia creado inicialmente.
         * no es necesario, pero no lo elimino porque me da miedo jeje
  
         
        private void LocateBt_Click(object sender, EventArgs e)
        {
            foreach (var aux in ppal.Stops)
            {

                GMapOverlay markOv = new GMapOverlay("marker");
                GMarkerGoogle mark = new GMarkerGoogle(new GMap.NET.PointLatLng(aux.Latit, aux.Longit), GMarkerGoogleType.red);


                markOv.Markers.Add(mark);

              //  map.Overlays.ElementAt<GMapOverlay>(1).Markers.ElementAt<GMapMarker>(1).Position
         

                mark.ToolTipMode = MarkerTooltipMode.Always;
                mark.ToolTipText = string.Format("Lat: " + aux.Latit + "\n" + "Lng: " + aux.Longit);

                map.Overlays.Add(markOv);
                //Console.WriteLine(aux.Latit);
                // Console.WriteLine(aux.Name + " ");
            }
        }

        */
        private void TestMotion_Click(object sender, EventArgs e)
        {

            //markOv.Markers.ElementAt(0).Position= new GMap.NET.PointLatLng(3.440465, -76.54748);


            // label10.Text = (path.Distance * 1000).ToString();
            map.Refresh();

        }



        /////////////////////aqui van los metodos para el poligono por estaciones
        ///hacer la opcion de que a determinado zoom, mostrar el poligono, sino mostrar un marcador normal

        public int cross(Stop a, Stop b, Stop c)
        {
            double val = (b.Latit - a.Latit) * (c.Longit - b.Longit) - (b.Longit - a.Longit) * (c.Latit - b.Latit);

            if (val == 0)
            {
                return 0;
            }
            else if (val > 0)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }


        public List<Stop> convexHullMethod(List<Stop> list, int p)
        {
            List<Stop> hull = new List<Stop>();
            int l = 0;

            for (int i = 1; i < p; i++)
            {
                if (list[i].Longit < list[l].Longit)
                {
                    l = i;
                }
            }

            int a = l, b;

            do
            {
                hull.Add(list[a]);
                b = (a + 1) % p;

                for (int i = 0; i < p; i++)
                {
                    if (cross(list[a], list[i], list[b]) == 2)
                    {
                        b = i;
                    }
                }

                a = b;
            } while (a != l);

            return hull;
        }


        public void wagonsStations()
        {

            List<Stop> auxList = new List<Stop>();

            List<Stop> stationsStops = ppal.TerminalStops;

            String shortName = stationsStops[0].ShortName;


            for (int i = 0; i < stationsStops.Count; i++)
            {
                if (stationsStops[i].ShortName.Substring(0, stationsStops[i].ShortName.Length - 2).Equals(shortName.Substring(0, shortName.Length - 2)))
                {
                    auxList.Add(stationsStops[i]);
                }
                else
                {
                    stationsPolygon(convexHullMethod(auxList, auxList.Count));
                    shortName = stationsStops[i].ShortName;
                    auxList.Clear();
                    auxList.Add(stationsStops[i]);
                }
            }


        }

        public void stationsPolygon(List<Stop> a)
        {
            polygon = new GMapOverlay("Polygon");
            List<PointLatLng> points = new List<PointLatLng>();

            for (int i = 0; i < a.Count; i++)
            {
                points.Add(new PointLatLng(a[i].Latit, a[i].Longit));
            }

            GMapPolygon pointsPolygon = new GMapPolygon(points, "Polygon");
            polygon.Polygons.Add(pointsPolygon);

            map.Overlays.Add(polygon);
        }

        /////////////////////////////////////7

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool estado = checkBEstaciones.Checked;

            if (estado)
            {
                preEstaciones = 1;
                filtroTerminal();
            }
            else
            {
                preEstaciones = 0;
                //gmapStations.Clear();

            }
        }

        private void CheckBZonas_CheckedChanged(object sender, EventArgs e)
        {

            bool estado = checkBZonas.Checked;

            if (estado)
            {
                paneZonas.Visible = true;
            }
            else
            {
                paneZonas.Visible = false;
            }
        }

        private void CheckBCalle_CheckedChanged(object sender, EventArgs e)
        {

            bool estado = checkBCalle.Checked;

            if (estado)
            {
                preCalle = 1;
                filtroCalle();
            }
            else
            {
                preCalle = 0;
            }
        }

        private void filtroCalle()
        {

            foreach (var aux in ppal.StreetStops)
            {
                gmapStreet = new GMapOverlay("marker");
                GMarkerGoogle mark = new GMarkerGoogle(new GMap.NET.PointLatLng(aux.Latit, aux.Longit), GMarkerGoogleType.yellow_small);

                gmapStreet.Markers.Add(mark);

                mark.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                mark.ToolTipText = String.Format("Parada: " + aux.ShortName + "\n" + "ID: " + aux.StopId + "\n" + "Latitud: " + aux.Latit + "\n" + "Longitud: " + aux.Longit);
                mark.ToolTip.TextPadding = new Size(10, 10);
                mark.ToolTip.Fill = Brushes.FloralWhite;

                map.Overlays.Add(gmapStreet);
            }
        }

        private void filtroTerminal()
        {

            foreach (var aux in ppal.TerminalStops)
            {
                gmapStations = new GMapOverlay("marker");
                GMarkerGoogle mark = new GMarkerGoogle(new GMap.NET.PointLatLng(aux.Latit, aux.Longit), GMarkerGoogleType.blue);
                gmapStations.Markers.Add(mark);

                mark.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                mark.ToolTipText = String.Format(aux.LongName + "\n" + "Latitud: " + aux.Latit + "\n" + "Longitud: " + aux.Longit);
                mark.ToolTip.TextPadding = new Size(10, 10);
                mark.ToolTip.Fill = Brushes.FloralWhite;


                map.Overlays.Add(gmapStations);
            }
            map.Refresh();
        }

        private void filtroReserva()
        {

            foreach (var aux in ppal.ReserveStops)
            {
                gmapReserves = new GMapOverlay("marker");
                GMarkerGoogle mark = new GMarkerGoogle(new GMap.NET.PointLatLng(aux.Latit, aux.Longit), GMarkerGoogleType.green_small);

                gmapReserves.Markers.Add(mark);

                mark.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                mark.ToolTipText = String.Format(aux.LongName + "\n" + "Latitud: " + aux.Latit + "\n" + "Longitud: " + aux.Longit);
                mark.ToolTip.TextPadding = new Size(10, 10);
                mark.ToolTip.Fill = Brushes.FloralWhite;

                map.Overlays.Add(gmapReserves);
            }
            map.Refresh();
        }

        private void sinFiltroParadas()
        {
            foreach (var aux in ppal.Stops)
            {

                GMapOverlay markOv = new GMapOverlay("marker");
                GMarkerGoogle mark = new GMarkerGoogle(new GMap.NET.PointLatLng(aux.Latit, aux.Longit), GMarkerGoogleType.red);

                markOv.Markers.Add(mark);

                //mark.ToolTipMode = MarkerTooltipMode.Always;
                //mark.ToolTipText = string.Format("Lat: " + aux.Latit + "\n" + "Lng: " + aux.Longit);

                map.Overlays.Add(markOv);

            }
            map.Refresh();

        }

        private void BtFiltrar_Click(object sender, EventArgs e)
        {

            if (preCalle == 1)
            {
                filtroCalle();
            }
            if (preEstaciones == 1)
            {
                filtroTerminal();
            }
            if (preCalle != 1 && preEstaciones != 1)
            {
                MessageBox.Show("No se ha seleccionado el filtro");
            }

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            paneOp1.Visible = true;
            paneOp2.Visible = false;
            btCompleteSimulation.Visible = false;
            btCustomSimulation.Visible = false;
            lbH.Visible = false;
            lbM.Visible = false;
            lbS.Visible = false;
        }
        /*
        private void BtAnimacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí va lo de brayan");

            Thread t = new Thread(animacion);
            t.Start();
        }*/
        /*
        private void animacion()
        {
            List<Bus> bus = ppal.getBusElementAt(txtBusId.Text);
            ppal.sortBusesByDateTime(bus);
            Console.WriteLine(bus.Count);
            GMarkerGoogle mark1 = new GMarkerGoogle(new GMap.NET.PointLatLng(bus.ElementAt(0).Latitude, bus.ElementAt(0).Longitude), GMarkerGoogleType.red);
            markOv.Markers.Add(mark1);

            map.Overlays.Add(markOv);

            for (int i = 1; i < bus.Count / 10; i++)
            {

                mark1.Position = new GMap.NET.PointLatLng(bus.ElementAt(i).Latitude, bus.ElementAt(i).Longitude);
                Thread.Sleep(200);
            }
        }*/



        private void RbtOpcion2_CheckedChanged(object sender, EventArgs e)
        {
            paneOp2.Visible = true;
            paneOp1.Visible = false;
            btCompleteSimulation.Visible = false;
            lbH.Visible = true;
            lbM.Visible = true;
            lbS.Visible = true;
        }

        private void CheckBTodas_CheckedChanged(object sender, EventArgs e)
        {
            bool estado = checkBTodas.Checked;

            if (estado)
            {
                checkBZonas.Enabled = false;
                checkBCalle.Enabled = false;
                checkBEstaciones.Enabled = false;
                btFiltrar.Enabled = false;
                sinFiltroParadas();

            }
            else
            {
                checkBZonas.Enabled = true;
                checkBCalle.Enabled = true;
                checkBEstaciones.Enabled = true;
                btFiltrar.Enabled = true;
            }
        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            map.Overlays.Clear();
            map.Refresh();

            checkBCalle.Checked = false;
            checkBReservas.Checked = false;
            checkBEstaciones.Checked = false;
        }

        private void polyZ0()
        {
            GZ0 = new GMapOverlay("Zona 0 (Centro)");
            List<PointLatLng> pZ0 = new List<PointLatLng>();

            pZ0.Add(new PointLatLng(3.458952, -76.513447));
            pZ0.Add(new PointLatLng(3.463029, -76.521014));
            pZ0.Add(new PointLatLng(3.460478, -76.527052));
            pZ0.Add(new PointLatLng(3.450851, -76.537823));
            pZ0.Add(new PointLatLng(3.451531, -76.541646));
            pZ0.Add(new PointLatLng(3.455851, -76.542208));
            pZ0.Add(new PointLatLng(3.458972, -76.553556));
            pZ0.Add(new PointLatLng(3.458552, -76.582726));
            pZ0.Add(new PointLatLng(3.448433, -76.562660));
            pZ0.Add(new PointLatLng(3.452630, -76.549432));
            pZ0.Add(new PointLatLng(3.441510, -76.536748));
            pZ0.Add(new PointLatLng(3.428423, -76.533186));
            pZ0.Add(new PointLatLng(3.434846, -76.523287));
            pZ0.Add(new PointLatLng(3.443270, -76.518067));


            GMapPolygon polygonZ0 = new GMapPolygon(pZ0, "ZONA 0");

            GZ0.Polygons.Add(polygonZ0);
            map.Overlays.Add(GZ0);
            map.Zoom = map.Zoom + 1;
            map.Zoom = map.Zoom - 1;

            if (paradaEnZona == 1)
            {
                stopsInsidePolygon(polygonZ0, GZ0);
            }

        }

        private void CheckBZ0_CheckedChanged(object sender, EventArgs e)
        {
            bool estado = checkBZ0.Checked;
            if (estado)
            {
                polyZ0();
                poly0 = 1;
            }
            else
            {
                GZ0.Clear();
                poly0 = 0;
            }
        }

        private void polyZ1()
        {
            GZ1 = new GMapOverlay("ZONA 1 (Universidades)");
            List<PointLatLng> pZ1 = new List<PointLatLng>();

            pZ1.Add(new PointLatLng(3.382049, -76.507089));
            pZ1.Add(new PointLatLng(3.387889, -76.513426));
            pZ1.Add(new PointLatLng(3.388507, -76.519616));
            pZ1.Add(new PointLatLng(3.387518, -76.524073));
            pZ1.Add(new PointLatLng(3.392462, -76.524631));
            pZ1.Add(new PointLatLng(3.392956, -76.532493));
            pZ1.Add(new PointLatLng(3.387827, -76.532647));
            pZ1.Add(new PointLatLng(3.384706, -76.560319));
            pZ1.Add(new PointLatLng(3.380813, -76.558586));
            pZ1.Add(new PointLatLng(3.380381, -76.562300));
            pZ1.Add(new PointLatLng(3.373645, -76.559390));
            pZ1.Add(new PointLatLng(3.370925, -76.553571));
            pZ1.Add(new PointLatLng(3.371060, -76.543718));
            pZ1.Add(new PointLatLng(3.367526, -76.541765));
            pZ1.Add(new PointLatLng(3.361442, -76.542623));
            pZ1.Add(new PointLatLng(3.353045, -76.549232));
            pZ1.Add(new PointLatLng(3.342849, -76.551550));
            pZ1.Add(new PointLatLng(3.315172, -76.546142));
            pZ1.Add(new PointLatLng(3.314658, -76.523140));
            pZ1.Add(new PointLatLng(3.314572, -76.522882));
            pZ1.Add(new PointLatLng(3.325626, -76.522367));
            pZ1.Add(new PointLatLng(3.348247, -76.522968));
            pZ1.Add(new PointLatLng(3.348932, -76.506574));
            pZ1.Add(new PointLatLng(3.355787, -76.509492));
            pZ1.Add(new PointLatLng(3.354073, -76.516273));
            pZ1.Add(new PointLatLng(3.364698, -76.516359));
            pZ1.Add(new PointLatLng(3.366069, -76.508377));
            pZ1.Add(new PointLatLng(3.371381, -76.509578));

            GMapPolygon polygonZ1 = new GMapPolygon(pZ1, "ZONA 1");
            GZ1.Polygons.Add(polygonZ1);
            map.Overlays.Add(GZ1);
            map.Zoom = map.Zoom + 1;
            map.Zoom = map.Zoom - 1;

            if (paradaEnZona == 1)
            {
                stopsInsidePolygon(polygonZ1, GZ1);
            }

        }

        private void CheckBZ1_CheckedChanged(object sender, EventArgs e)
        {
            bool estado = checkBZ1.Checked;
            if (estado)
            {
                polyZ1();
                poly1 = 1;
            }
            else
            {
                GZ1.Clear();
                poly1 = 0;
            }
        }

        private void polyZ2()
        {
            GZ2 = new GMapOverlay("Zona 2 (MENGA)");
            List<PointLatLng> pZ2 = new List<PointLatLng>();

            pZ2.Add(new PointLatLng(3.499343, -76.492160));
            pZ2.Add(new PointLatLng(3.463029, -76.521014));
            pZ2.Add(new PointLatLng(3.460478, -76.527052));
            pZ2.Add(new PointLatLng(3.450851, -76.537823));
            pZ2.Add(new PointLatLng(3.451531, -76.541646));
            pZ2.Add(new PointLatLng(3.455851, -76.542208));
            pZ2.Add(new PointLatLng(3.454776, -76.540491));
            pZ2.Add(new PointLatLng(3.454776, -76.540491));
            pZ2.Add(new PointLatLng(3.454776, -76.540491));
            pZ2.Add(new PointLatLng(3.475791, -76.532884));
            pZ2.Add(new PointLatLng(3.478440, -76.529107));
            pZ2.Add(new PointLatLng(3.481190, -76.529311));
            pZ2.Add(new PointLatLng(3.488169, -76.537783));
            pZ2.Add(new PointLatLng(3.489748, -76.538549));
            pZ2.Add(new PointLatLng(3.494435, -76.535436));
            pZ2.Add(new PointLatLng(3.489850, -76.528852));
            pZ2.Add(new PointLatLng(3.496918, -76.526449));
            pZ2.Add(new PointLatLng(3.498546, -76.522458));
            pZ2.Add(new PointLatLng(3.506085, -76.521685));
            pZ2.Add(new PointLatLng(3.516365, -76.519454));
            pZ2.Add(new PointLatLng(3.519449, -76.533659));
            pZ2.Add(new PointLatLng(3.520434, -76.519239));
            pZ2.Add(new PointLatLng(3.521805, -76.517651));
            pZ2.Add(new PointLatLng(3.521805, -76.517651));
            pZ2.Add(new PointLatLng(3.521805, -76.517651));
            pZ2.Add(new PointLatLng(3.523958, -76.495361));
            pZ2.Add(new PointLatLng(3.505948, -76.500053));
            pZ2.Add(new PointLatLng(3.505516, -76.492691));


            GMapPolygon polygonZ2 = new GMapPolygon(pZ2, "ZONA 2");
            GZ2.Polygons.Add(polygonZ2);
            map.Overlays.Add(GZ2);
            map.Zoom = map.Zoom + 1;
            map.Zoom = map.Zoom - 1;

            if (paradaEnZona == 1)
            {
                stopsInsidePolygon(polygonZ2, GZ2);
            }
        }

        private void CheckBZ2_CheckedChanged(object sender, EventArgs e)
        {
            bool estado = checkBZ2.Checked;
            if (estado)
            {
                polyZ2();
                poly2 = 1;
            }
            else
            {
                GZ2.Clear();
                poly2 = 0;
            }
        }


        private void polyZ3()
        {
            GZ3 = new GMapOverlay("ZONA 3 (PASO DEL COMERCIO)");
            List<PointLatLng> pZ3 = new List<PointLatLng>();

            pZ3.Add(new PointLatLng(3.463029, -76.521014));
            pZ3.Add(new PointLatLng(3.499343, -76.492160));
            pZ3.Add(new PointLatLng(3.497010, -76.485022));
            pZ3.Add(new PointLatLng(3.482987, -76.482092));
            pZ3.Add(new PointLatLng(3.480321, -76.479688));
            pZ3.Add(new PointLatLng(3.477062, -76.479344));
            pZ3.Add(new PointLatLng(3.474059, -76.476589));
            pZ3.Add(new PointLatLng(3.468334, -76.475987));
            pZ3.Add(new PointLatLng(3.458952, -76.513447));


            GMapPolygon polygonZ3 = new GMapPolygon(pZ3, "ZONA 3");
            GZ3.Polygons.Add(polygonZ3);
            map.Overlays.Add(GZ3);
            map.Zoom = map.Zoom + 1;
            map.Zoom = map.Zoom - 1;

            if (paradaEnZona == 1)
            {
                stopsInsidePolygon(polygonZ3, GZ3);
            }
        }

        private void CheckBZ3_CheckedChanged(object sender, EventArgs e)
        {
            bool estado = checkBZ3.Checked;
            if (estado)
            {
                polyZ3();
                poly3 = 1;
            }
            else
            {
                GZ3.Clear();
                poly3 = 0;
            }
        }

        private void polyZ4()
        {
            GZ4 = new GMapOverlay("ZONA 4 (ANDRÉS SANÍN)");

            List<PointLatLng> pZ4 = new List<PointLatLng>();
            pZ4.Add(new PointLatLng(3.443270, -76.518067));
            pZ4.Add(new PointLatLng(3.458952, -76.513447));
            pZ4.Add(new PointLatLng(3.468334, -76.475987));
            pZ4.Add(new PointLatLng(3.465410, -76.474958));
            pZ4.Add(new PointLatLng(3.460690, -76.478052));
            pZ4.Add(new PointLatLng(3.440685, -76.472893));
            pZ4.Add(new PointLatLng(3.441297, -76.466824));
            pZ4.Add(new PointLatLng(3.436129, -76.463077));
            pZ4.Add(new PointLatLng(3.399183, -76.466336));
            pZ4.Add(new PointLatLng(3.400404, -76.476322));
            pZ4.Add(new PointLatLng(3.413793, -76.482086));
            pZ4.Add(new PointLatLng(3.418084, -76.486381));
            pZ4.Add(new PointLatLng(3.428568, -76.483722));
            pZ4.Add(new PointLatLng(3.446679, -76.484064));
            pZ4.Add(new PointLatLng(3.443159, -76.493519));

            GMapPolygon polygonZ4 = new GMapPolygon(pZ4, "ZONA 4");
            GZ4.Polygons.Add(polygonZ4);
            map.Overlays.Add(GZ4);
            map.Zoom = map.Zoom + 1;
            map.Zoom = map.Zoom - 1;

            if (paradaEnZona == 1)
            {
                stopsInsidePolygon(polygonZ4, GZ4);
            }

        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            bool estado = checkBZ4.Checked;
            if (estado)
            {
                polyZ4();
                poly4 = 1;
            }
            else
            {
                GZ4.Clear();
                poly4 = 0;
            }
        }

        private void polyZ5()
        {
            GZ5 = new GMapOverlay("ZONA 5 (NUEVO LATIR)");

            List<PointLatLng> pZ5 = new List<PointLatLng>();
            pZ5.Add(new PointLatLng(3.443827, -76.491165));
            pZ5.Add(new PointLatLng(3.428302, -76.498642));
            pZ5.Add(new PointLatLng(3.407200, -76.521070));
            pZ5.Add(new PointLatLng(3.404841, -76.518878));
            pZ5.Add(new PointLatLng(3.402954, -76.520984));
            pZ5.Add(new PointLatLng(3.403125, -76.522445));
            pZ5.Add(new PointLatLng(3.400466, -76.523132));
            pZ5.Add(new PointLatLng(3.394890, -76.523605));
            pZ5.Add(new PointLatLng(3.394333, -76.519308));
            pZ5.Add(new PointLatLng(3.390859, -76.519738));
            pZ5.Add(new PointLatLng(3.390215, -76.516300));
            pZ5.Add(new PointLatLng(3.391288, -76.516000));
            pZ5.Add(new PointLatLng(3.393732, -76.513164));
            pZ5.Add(new PointLatLng(3.388929, -76.509598));
            pZ5.Add(new PointLatLng(3.392801, -76.504657));
            pZ5.Add(new PointLatLng(3.402838, -76.499415));
            pZ5.Add(new PointLatLng(3.414504, -76.483088));
            pZ5.Add(new PointLatLng(3.418084, -76.486381));
            pZ5.Add(new PointLatLng(3.428568, -76.483722));
            pZ5.Add(new PointLatLng(3.446679, -76.484064));

            GMapPolygon polygonZ5 = new GMapPolygon(pZ5, "CIUDAD CORDOBA");
            GZ5.Polygons.Add(polygonZ5);
            map.Overlays.Add(GZ5);
            map.Zoom = map.Zoom + 1;
            map.Zoom = map.Zoom - 1;

            if (paradaEnZona == 1)
            {
                stopsInsidePolygon(polygonZ5, GZ5);
            }
        }

        private void CheckBZ5_CheckedChanged(object sender, EventArgs e)
        {
            bool estado = checkBZ5.Checked;
            if (estado)
            {
                polyZ5();
                poly5 = 1;
            }
            else
            {
                GZ5.Clear();
                poly5 = 0;
            }
        }

        private void polyZ6()
        {
            GZ6 = new GMapOverlay("ZONA 6 (GUADALUPE)");
            List<PointLatLng> pZ6 = new List<PointLatLng>();


            pZ6.Add(new PointLatLng(3.419485, -76.508024));
            pZ6.Add(new PointLatLng(3.419999, -76.508604));
            pZ6.Add(new PointLatLng(3.419432, -76.521462));
            pZ6.Add(new PointLatLng(3.434846, -76.523287));
            pZ6.Add(new PointLatLng(3.428423, -76.533186));
            pZ6.Add(new PointLatLng(3.398191, -76.538025));
            pZ6.Add(new PointLatLng(3.398277, -76.542537));
            pZ6.Add(new PointLatLng(3.386310, -76.544481));
            pZ6.Add(new PointLatLng(3.387827, -76.532647));
            pZ6.Add(new PointLatLng(3.392956, -76.532493));
            pZ6.Add(new PointLatLng(3.392462, -76.524631));
            pZ6.Add(new PointLatLng(3.387518, -76.524073));
            pZ6.Add(new PointLatLng(3.389252, -76.519946));
            pZ6.Add(new PointLatLng(3.389971, -76.520956));
            pZ6.Add(new PointLatLng(3.389209, -76.522588));
            pZ6.Add(new PointLatLng(3.392104, -76.523738));
            pZ6.Add(new PointLatLng(3.394890, -76.523605));
            pZ6.Add(new PointLatLng(3.400466, -76.523132));
            pZ6.Add(new PointLatLng(3.403125, -76.522445));
            pZ6.Add(new PointLatLng(3.402954, -76.520984));
            pZ6.Add(new PointLatLng(3.404841, -76.518878));
            pZ6.Add(new PointLatLng(3.407200, -76.521070));


            GMapPolygon poligonoZ6 = new GMapPolygon(pZ6, "ZONA 6");
            GZ6.Polygons.Add(poligonoZ6);
            map.Overlays.Add(GZ6);
            map.Zoom = map.Zoom + 1;
            map.Zoom = map.Zoom - 1;

            if (paradaEnZona == 1)
            {
                stopsInsidePolygon(poligonoZ6, GZ6);
            }
        }

        private void CheckBZ6_CheckedChanged(object sender, EventArgs e)
        {
            bool estado = checkBZ6.Checked;
            if (estado)
            {
                polyZ6();
                poly6 = 1;
            }
            else
            {
                GZ6.Clear();
                poly6 = 0;
            }
        }

        private void polyZ7()
        {
            GZ7 = new GMapOverlay("ZONA 7 (CAÑAVERALEJO)");
            List<PointLatLng> pZ7 = new List<PointLatLng>();

            pZ7.Add(new PointLatLng(3.386310, -76.544481));
            pZ7.Add(new PointLatLng(3.398277, -76.542537));
            pZ7.Add(new PointLatLng(3.398191, -76.538025));
            pZ7.Add(new PointLatLng(3.428423, -76.533186));
            pZ7.Add(new PointLatLng(3.441510, -76.536748));
            pZ7.Add(new PointLatLng(3.452630, -76.549432));
            pZ7.Add(new PointLatLng(3.448433, -76.562660));
            pZ7.Add(new PointLatLng(3.435942, -76.557605));
            pZ7.Add(new PointLatLng(3.427738, -76.571950));
            pZ7.Add(new PointLatLng(3.417393, -76.567787));
            pZ7.Add(new PointLatLng(3.411738, -76.574267));
            pZ7.Add(new PointLatLng(3.407067, -76.578130));
            pZ7.Add(new PointLatLng(3.402269, -76.571864));
            pZ7.Add(new PointLatLng(3.391773, -76.572207));
            pZ7.Add(new PointLatLng(3.384706, -76.560319));

            GMapPolygon polygonZ7 = new GMapPolygon(pZ7, "CAÑAVERALEJO");
            GZ7.Polygons.Add(polygonZ7);
            map.Overlays.Add(GZ7);
            map.Zoom = map.Zoom + 1;
            map.Zoom = map.Zoom - 1;

            if (paradaEnZona == 1)
            {
                stopsInsidePolygon(polygonZ7, GZ7);
            }
        }

        private void CheckBZ7_CheckedChanged(object sender, EventArgs e)
        {
            bool estado = checkBZ7.Checked;
            if (estado)
            {
                polyZ7();
                poly7 = 1;
            }
            else
            {
                GZ7.Clear();
                poly7 = 0;
            }
        }

        private void polyZ8()
        {
            GZ8 = new GMapOverlay("ZONA 8 (CALIPSO)");
            List<PointLatLng> pZ8 = new List<PointLatLng>();

            pZ8.Add(new PointLatLng(3.443827, -76.491165));
            pZ8.Add(new PointLatLng(3.428302, -76.498642));
            pZ8.Add(new PointLatLng(3.419485, -76.508024));
            pZ8.Add(new PointLatLng(3.419999, -76.508604));
            pZ8.Add(new PointLatLng(3.419432, -76.521462));
            pZ8.Add(new PointLatLng(3.434846, -76.523287));
            pZ8.Add(new PointLatLng(3.443270, -76.518067));
            pZ8.Add(new PointLatLng(3.443159, -76.493519));
            GMapPolygon poligonoZ8 = new GMapPolygon(pZ8, "PRADO");

            //poligonoZ8.Fill = new SolidBrush(Color.FromName("blue"));
            //poligonoZ8.Fill = Brushes.LightSeaGreen;
            // System.Windows.Media.Brushes.LightSeaGreen;
            //FromArgb(255, 220, 213)
            GZ8.Polygons.Add(poligonoZ8);
            map.Overlays.Add(GZ8);
            map.Zoom = map.Zoom + 1;
            map.Zoom = map.Zoom - 1;

            if (paradaEnZona == 1)
            {
                stopsInsidePolygon(poligonoZ8, GZ8);
            }

        }

        private void CheckBZ8_CheckedChanged(object sender, EventArgs e)
        {
            bool estado = checkBZ8.Checked;
            if (estado)
            {
                polyZ8();
                poly8 = 1;
            }
            else
            {
                GZ8.Clear();
                poly8 = 0;
            }
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void BtCustomSimulationt_Click(object sender, EventArgs e)
        {

        }

        private void BtSimulacionCompleta_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            timer1.Enabled = true;
            timer1.Interval = 500;
        }

        

        private void callAgainPolyZn()
        {
            if (poly0 == 1)
            {
                GZ0.Clear();
                polyZ0();
            }

            if (poly1 == 1)
            {
                GZ1.Clear();
                polyZ1();
            }

            if (poly2 == 1)
            {
                GZ2.Clear();
                polyZ2();
            }

            if (poly3 == 1)
            {
                GZ3.Clear();
                polyZ3();
            }

            if (poly4 == 1)
            {
                GZ4.Clear();
                polyZ4();
            }

            if (poly5 == 1)
            {
                GZ5.Clear();
                polyZ5();
            }

            if (poly6 == 1)
            {
                GZ6.Clear();
                polyZ6();
            }

            if (poly7 == 1)
            {
                GZ7.Clear();
                polyZ7();
            }

            if (poly8 == 1)
            {
                GZ8.Clear();
                polyZ8();
            }
        }

        private void CheckBParadas_CheckedChanged_1(object sender, EventArgs e)
        {
            bool estado = checkBParadas.Checked;
            if (estado)
            {
                paradaEnZona = 1;
                callAgainPolyZn();
            }
            else
            {
                paradaEnZona = 0;
            }
        }

        private void RbtSimulacionPersonal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtSimulacionPersonal.Checked)
            {
                panelCustomSimulation.Visible = true;
                btCustomSimulation.Visible = true;
                tbTimeHours.Visible = true;
                tbHour.Visible = true;
                tbMin.Visible = true;
                tbSec.Visible = true;
            }
            else
            {
                panelCustomSimulation.Visible = false;
                btCustomSimulation.Visible = false;
                tbTimeHours.Visible = false;
                tbHour.Visible = false;
                tbMin.Visible = false;
                tbSec.Visible = false;
            }
              
            
     
        }

        private void RbtSimulacionCompleta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtSimulacionCompleta.Checked)
            {
                btCompleteSimulation.Visible = true;
            }
            else
            {
                btCompleteSimulation.Visible = false;
            }
            
        }

        private void CheckBReservas_CheckedChanged(object sender, EventArgs e)
        {
            bool estado = checkBReservas.Checked;

            if (estado)
            {
                preReservas = 1;

            }
            else
            {
                preReservas = 0;
                eliminar();

            }
        }

        private void eliminar()
        {
            map.Overlays.Remove(gmapReserves);
            map.Refresh();
        }

        private void TxtBusId_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click_1(object sender, EventArgs e)
        {

        }

       /** private void CbCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCustom.Checked)
            {
                panelCustomSimulation.Visible = true;
                btCustomSimulation.Visible = true;
                tbTimeHours.Visible = true;
                tbHour.Visible = true;
                tbMin.Visible = true;
                tbSec.Visible = true;
            }
            else
            {
                panelCustomSimulation.Visible = false;
                btCustomSimulation.Visible = false;
                tbTimeHours.Visible = false;
                tbHour.Visible = false;
                tbMin.Visible = false;
                tbSec.Visible = false;
            }

        }**/

        private void stopsInsidePolygon(GMapPolygon polygon, GMapOverlay gzn)
        {
            if (paradaEnZona == 1)
            {
                foreach (var actual in ppal.StreetStops)
                {
                    var p = new PointLatLng(actual.Latit, actual.Longit);
                    if (polygon.IsInside(p))
                    {
                        GMapMarker marker = new GMarkerGoogle(p, GMarkerGoogleType.yellow_small);
                        polygon.Overlay.Markers.Add(marker);
                    }
                }



            }

        }


        /* private void busesInsidePolygon(GMapPolygon polygon, GMapOverlay gzn)
         {
             foreach (var actual in ppal.getBuses())
             {

             }
         }*/

    }
}

