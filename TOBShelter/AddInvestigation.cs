using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TOBShelter.Services;
using TOBShelter.Types.Base;
using TOBShelter.Types.Composed;
using TOBShelter.Types.Dto;

namespace TOBShelter
{
    public partial class AddInvestigation : Form
    {
        private Dictionary<string, long> dic = new Dictionary<string, long>();
        private List<Animal> listAnimaux = new List<Animal>();
        private List<DocumentCreateDTO> listDocuments = new List<DocumentCreateDTO>();
        private List<PersonDTO> listPerson;
        private List<InvestigatorDTO> listInvestigator;

        private long id = long.Parse(DateTime.Today.ToString("yyyyMMdd"));

        public AddInvestigation()
        {
            InitializeComponent();

            listPerson = PersonService.FindAll(null);
            listInvestigator = InvestigatorService.FindAll(null);

            int i = 1;
            while (InvestigationService.FindById((long)Convert.ToDouble(id + i.ToString())) != null)
            {
                i++;
            }
            this.id = (long)Convert.ToDouble(this.id.ToString() + i.ToString());

            /*InvestigationDetailsDTO lastId = InvestigationService.FindById(this.id + 0);
            while () {
                lastId = InvestigationService.FindById();
            }*/

            foreach (InvestigatorDTO investigator in listInvestigator)
            {
                string str = investigator.FirstName + " " + investigator.Name + ", " + InvestigatorService.GetNbInvestigation(investigator.Id).ToString();
                if (!dic.ContainsKey(str))
                {
                    this.dic.Add(str, investigator.Id);
                    this.cmbInvestigator.Items.Add(str);
                }
            }

            foreach (PersonDTO person in listPerson)
            {
                string str = person.FirstName + " " + person.Name;
                if (!dic.ContainsKey(str))
                {
                    this.dic.Add(str, person.Id);
                    this.cmbComplainant.Items.Add(str);
                    this.cmbOffender.Items.Add(str);
                }
            }
        }

        private void btnAddInvestigation_Click(object sender, EventArgs e)
        {
            /*try
            {*/
            InvestigationCreateDTO investigation = new InvestigationCreateDTO()
            {
                Id = id,
                Title = this.txtTitle.Text.Trim(),
                ComplainantId = this.dic[cmbComplainant.SelectedItem.ToString()],
                OffenderId = this.dic[cmbOffender.SelectedItem.ToString()],
                Reason = this.txtReason.Text.Trim(),
                InvestigatorId = this.dic[cmbInvestigator.SelectedItem.ToString()],
                Animals = this.listAnimaux,
                Documents = this.listDocuments,
                Notice = null,
                Closed = false
            };
            Console.WriteLine("avant crée" + listDocuments.Count());

            /*try
            {*/
            InvestigationService.Create(investigation);
            Console.WriteLine("crée" + listDocuments.Count());

            foreach (DocumentCreateDTO document in listDocuments)
            {
                Console.WriteLine("done");
                DocumentService.Create(document);
            }
            this.Close();
            /*}
            catch (Exception)
            {
                MessageBox.Show("Impossible d'ajouter une enquête pour le moment.", "Impossible d'ajouter une enquête", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            /*}
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Impossible d'ajouter une enquête", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            AddPerson addPerson = new AddPerson();
            addPerson.ShowDialog(this);
            PersonDetailsDTO newPerson = addPerson.createdPerson;
            if (newPerson is not null)
            {
                PersonDTO person = new PersonDTO { Id = newPerson.Id, Title = (IdentityTitle)newPerson.Title, Name = newPerson.Name, FirstName = newPerson.FirstName };
                this.listPerson.Add(person);
                this.cmbComplainant.Items.Add(person.FirstName + " " + person.Name);
                this.cmbOffender.Items.Add(person.FirstName + " " + person.Name);
            }
        }

        private void btnAddInvestigator_Click(object sender, EventArgs e)
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
                // On dessine le secteur de chaque enqueteur sur la map
                foreach (InvestigatorDTO investigator in this.listInvestigator)
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

        private async void cmbOffender_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GMapOverlay overlayToRemove = gMapControl.Overlays.FirstOrDefault(o => o.Id == "markersOffender");
                if (overlayToRemove != null)
                    gMapControl.Overlays.Remove(overlayToRemove);

                PersonDetailsDTO offender = PersonService.FindById(listPerson[(sender as ComboBox).SelectedIndex].Id);
                Coordinates coords = await (TOBShelter.services.GeoAPIService.GetCommuneCoordinates(offender.PostalCode, offender.City));
                PointLatLng center = new PointLatLng(coords.Y, coords.X);

                // On dessine un pins ou l'infracteur suspecté habite
                GMapOverlay markers = new GMapOverlay("markersOffender");
                GMapMarker marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(center, GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_dot);
                markers.Markers.Add(marker);
                gMapControl.Overlays.Add(markers);
            }
            catch (Exception) { }
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            AddAnimal addAnimal = new AddAnimal();
            addAnimal.ShowDialog(this);
            this.listAnimaux.Add(addAnimal.animal);

            this.updateAnimal();
        }

        private void updateAnimal()
        {
            this.lstAnimals.Items.Clear();
            try
            {
                foreach (Animal animal in this.listAnimaux)
                {
                    this.lstAnimals.Items.Add(animal.Name);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("L'accès a la base de données est momentanément indisponible", "Impossible d'accéder à la base de données", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void brnAddDocuments_Click(object sender, EventArgs e)
        {
            AddDocument addDocument = new AddDocument(id);
            addDocument.ShowDialog(this);
            listDocuments.Add(addDocument.document);

            this.updateDocuments();
        }

        private void updateDocuments()
        {
            this.lstDocuments.Items.Clear();

            try
            {
                foreach (DocumentCreateDTO document in listDocuments)
                {
                    this.lstDocuments.Items.Add(document.Path);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("L'accès a la base de données est momentanément indisponible", "Impossible d'accéder à la base de données", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}