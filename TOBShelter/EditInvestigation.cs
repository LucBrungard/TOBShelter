using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TOBShelter.Services;
using TOBShelter.Types.Base;
using TOBShelter.Types.Composed;
using TOBShelter.Types.Dto;

namespace TOBShelter
{
    public partial class EditInvestigation : Form
    {
        private List<Animal> listAnimaux = new List<Animal>();
        private Dictionary<string, long> dic = new Dictionary<string, long>();
        private InvestigationDetailsDTO investigation;
        private List<InvestigatorDTO> listInvestigator;

        public EditInvestigation(InvestigationDetailsDTO investigation)
        {
            InitializeComponent();

            this.investigation = investigation;

            this.listInvestigator = InvestigatorService.FindAll(null);

            foreach (InvestigatorDTO investigator in listInvestigator)
            {
                string str = investigator.FirstName + " " + investigator.Name;
                if (!this.dic.ContainsKey(str))
                {
                    this.dic.Add(str, investigator.Id);
                    this.cmbInvestigator.Items.Add(str);
                }
            }

            this.txtTitle.Text = investigation.Title;
            this.txtReason.Text = investigation.Reason;
            this.txtComplaignant.Text = investigation.Complainant.FirstName + " " + investigation.Complainant.Name;
            this.txtOffender.Text = investigation.Offender.FirstName + " " + investigation.Offender.Name;
            this.cmbInvestigator.SelectedItem = investigation.Investigator.FirstName + " " + investigation.Investigator.Name;
            if (investigation.Notice != null)
                this.txtNotice.Text = investigation.Notice;

            foreach (Animal animal in investigation.Animals)
            {
                this.lstAnimals.Items.Add(animal.Name);
            }

            ActivityFilters filter = new ActivityFilters();
            filter.InvestigationId = investigation.Id;
            List<ActivityDTO> listActivities = ActivityService.FindAll(filter);

            foreach (ActivityDTO activity in listActivities)
            {
                this.lstActivities.Items.Add(activity.Description + ", date:" + activity.Date.ToShortDateString());
            }

            if (investigation.Closed)
            {
                this.chkClosed.Checked = true;
                this.txtNotice.Enabled = true;
                this.lblNotice.Enabled = true;
            }
        }

        private void btnEditInvestigation_Click(object sender, EventArgs e)
        {
            try
            {
                string notice = null;
                if (this.chkClosed.Checked)
                {
                    notice = this.txtNotice.Text.Trim();
                }

                InvestigationEditDTO investigationUpdated = new InvestigationEditDTO()
                {
                    Id = this.investigation.Id,
                    Title = this.txtTitle.Text.Trim(),
                    InvestigatorId = this.dic[cmbInvestigator.SelectedItem.ToString()],
                    Notice = notice,
                    Closed = this.chkClosed.Checked
                };

            try
            {
                this.investigation = InvestigationService.Update(investigationUpdated);
                    this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de modifier cette enquête pour le moment.", "Impossible de modifier cette enquête", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Impossible de modifier cet enquêteur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void chkClosed_CheckedChanged(object sender, EventArgs e)
        {
            this.txtNotice.Enabled = !this.txtNotice.Enabled;
            this.lblNotice.Enabled = !this.lblNotice.Enabled;
        }

        private void btnAddInvestigator_Click_1(object sender, EventArgs e)
        {
            AddInvestigator addInvestigator = new AddInvestigator();
            addInvestigator.ShowDialog(this);
            InvestigatorDetailsDTO newInvestigator = addInvestigator.createdInvestigator;
            if (newInvestigator is not null)
            {
                InvestigatorDTO person = new InvestigatorDTO { Id = newInvestigator.Id, Title = (IdentityTitle)newInvestigator.Title, Name = newInvestigator.Name, FirstName = newInvestigator.FirstName, Available = true, InOperation = true, NbInvestigations = 0 };
                this.listInvestigator.Add(person);
                this.cmbInvestigator.Items.Add(person.FirstName + " " + person.Name + ", 0");
            }
        }

        private async void gMapControl_Load(object sender, EventArgs e)
        {
            this.gMapControl.MapProvider = GMapProviders.GoogleMap;
            this.gMapControl.Position = new PointLatLng(49.133333, 6.166667); // Metz
            this.gMapControl.MinZoom = 0;
            this.gMapControl.MaxZoom = 24;
            this.gMapControl.Zoom = 10;

            // On permet à l'utilisateur de se déplacer sur la map
            this.gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl.CanDragMap = true;
            this.gMapControl.DragButton = MouseButtons.Left;

            this.gMapControl.PolygonsEnabled = true;
            this.gMapControl.MarkersEnabled = true;

            try
            {
                List<InvestigatorDTO> listInvestigator = InvestigatorService.FindAll(null);
                // On dessine le secteur de chaque enqueteur sur la map
                foreach (InvestigatorDTO investigator in listInvestigator)
                {
                    InvestigatorDetailsDTO detailInvestigator = TOBShelter.Services.InvestigatorService.FindById(investigator.Id);
                    Coordinates coords = await (TOBShelter.services.GeoAPIService.GetCommuneCoordinates(detailInvestigator.PostalCode, detailInvestigator.City));
                    PointLatLng center = new PointLatLng(coords.Y, coords.X);

                    // On dessine un pins ou l'enqueteur habite
                    GMapOverlay markers = new GMapOverlay("markers");
                    GMapMarker marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(center, GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_dot);
                    marker.ToolTipText = investigator.FirstName + " " + investigator.Name + "\n En cours :" + InvestigatorService.GetNbInvestigation(investigator.Id).ToString();
                    markers.Markers.Add(marker);
                    gMapControl.Overlays.Add(markers);

                    // On dessine le secteur
                    double radius = double.Parse(detailInvestigator.BusinessSector) * 1000;
                    List<PointLatLng> points = new List<PointLatLng>();
                    // Ajouter les points du cercle à la liste
                    for (int i = 0; i < 36; i++)
                    {
                        double angle = (Math.PI / 180) * (i * (360 / 36));
                        double lat = center.Lat + radius / 111300 * Math.Cos(angle);
                        double lng = center.Lng + (radius / 111300 * Math.Sin(angle)) / Math.Cos(center.Lat * (Math.PI / 180));
                        points.Add(new PointLatLng(lat, lng));
                    }

                    // On crée le cercle
                    GMapOverlay polygons = new GMapOverlay("polygons");
                    GMapPolygon circle = new GMapPolygon(points, "sector" + investigator.Name);
                    circle.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
                    circle.Stroke = new Pen(Color.Red, 1);
                    polygons.Polygons.Add(circle);
                    gMapControl.Overlays.Add(polygons);
                }
            }
            catch (Exception) { }
        }

        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            AddActivity addActivity = new AddActivity(this.investigation.Id);
            addActivity.ShowDialog();
            updateActivities();
        }

        private void updateActivities()
        {
            this.lstActivities.Items.Clear();

            ActivityFilters filter = new ActivityFilters();
            filter.InvestigationId = this.investigation.Id;
            List<ActivityDTO> listActivities = ActivityService.FindAll(filter);
            try
            {
                foreach (ActivityDTO activity in listActivities)
                {
                    this.lstActivities.Items.Add(activity.Description + ", date:" + activity.Date.ToShortDateString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("L'accès a la base de données est momentanément indisponible", "Impossible d'accéder à la base de données", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}