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
        Dictionary<string, long> dic = new Dictionary<string, long>();
        List<Animal> listAnimaux = new List<Animal>();
        List<DocumentCreateDTO> listDocuments = new List<DocumentCreateDTO>();

        long id = long.Parse(DateTime.Today.ToString("yyyyMMdd"));

        public AddInvestigation()
        {
            InitializeComponent();

            List<PersonDTO> listPerson = PersonService.FindAll(null);
            List<InvestigatorDTO> listInvestigator = InvestigatorService.FindAll(null);

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
                string str = investigator.FirstName + " " + investigator.Name;
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
        }

        private void btnAddInvestigator_Click(object sender, EventArgs e)
        {
            AddInvestigator addInvestigator = new AddInvestigator();
            addInvestigator.ShowDialog(this);
        }

        private async void gMapControl_Load(object sender, EventArgs e)
        {
            this.gMapControl.MapProvider = GMapProviders.GoogleMap;
            this.gMapControl.Position = new PointLatLng(49.133333, 6.166667); // Metz
            this.gMapControl.MinZoom = 0;
            this.gMapControl.MaxZoom = 24;
            this.gMapControl.Zoom = 10;

            this.gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl.CanDragMap = true;
            this.gMapControl.DragButton = MouseButtons.Left;

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
    public class SimpleMarker : GMapMarker
    {
        public SimpleMarker(PointLatLng pos) : base(pos)
        {
            Size = new System.Drawing.Size(20, 20);
            Offset = new System.Drawing.Point(-Size.Width / 2, -Size.Height / 2);
        }
    }
}
