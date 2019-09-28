using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using model;

namespace Proy_In
{
    public partial class Form1 : Form
    {

        private GMapOverlay markOv;
        private Principal ppal;

      

        public Form1()
        {
            
            InitializeComponent();
            ppal = new Principal();
            markOv = new GMapOverlay("marker");
            paneZonas.Visible = false;
        }

        private void Map_Load(object sender, EventArgs e)
        {
            map.SetPositionByKeywords("Colombia,Cali");
            actualZoom.Text=map.Zoom.ToString()+" %";

            GMarkerGoogle mark = new GMarkerGoogle(new GMap.NET.PointLatLng(3.44327333 ,- 76.54844800), GMarkerGoogleType.red);
            markOv.Markers.Add(mark);

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
            route.Stroke = new Pen(Color.Red, 3);
            routes.Routes.Add(route);
            map.Overlays.Add(routes);

            map.Overlays.Add(markOv);
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
            map.Zoom -= 3;
            actualZoom.Text = map.Zoom.ToString() + " %";

        }

        private void ZoomIn_Click(object sender, EventArgs e)
        {
            map.Zoom += 3;
         
            actualZoom.Text = map.Zoom.ToString()+" %";
        }

        private void LoadDataBt_Click(object sender, EventArgs e)
        {
            String path;
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                path = openFile.FileName;
                Console.WriteLine(path);
                ppal.addStops(path);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ppal.test();
        }


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

        private void TestMotion_Click(object sender, EventArgs e)
        {

            //markOv.Markers.ElementAt(0).Position= new GMap.NET.PointLatLng(3.440465, -76.54748);

            
           // label10.Text = (path.Distance * 1000).ToString();
            map.Refresh();

        }

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

        
    }
}
