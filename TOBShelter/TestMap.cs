using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOBShelter
{
    using GMap.NET;
    using GMap.NET.MapProviders;
    using GMap.NET.WindowsForms;
    using GMap.NET.WindowsForms.Markers;
    using System;
    using System.Windows.Forms;

    public partial class TestMap : Form
    {
        public TestMap()
        {
            InitializeComponent();
            GMapControl gMapControl1 = new GMapControl();
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(48.856614, 2.3522219); // Paris
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 10;
            Controls.Add(gMapControl1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialisation de la carte
            //this.BackColor = Color.Red;

            //// Ajout d'un marqueur
            //GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(48.8589507, 2.2770205), GMarkerGoogleType.red);
            //GMapOverlay overlay = new GMapOverlay("markers");
            //overlay.Markers.Add(marker);
            //gMapControl1.Overlays.Add(overlay);

            //gmap.MapProvider = BingHybridMapProvider.Instance;
            //GMaps.Instance.Mode = AccessMode.ServerOnly;
            //gmap.SetPositionByKeywords("Paris, France");
            //gmap.ShowCenter = false;

            //GMapOverlay markers = new GMapOverlay("markers");
            //GMapMarker marker = new GMarkerGoogle(
            //    new PointLatLng(48.8617774, 2.349272),
            //    GMarkerGoogleType.blue_pushpin);
            //markers.Markers.Add(marker);
            //gmap.Overlays.Add(markers);
        }
    }
}