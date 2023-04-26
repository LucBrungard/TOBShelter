using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TOBShelter.Services;
using TOBShelter.Types.Composed;
using TOBShelter.Types.Dto;

namespace TOBShelter
{
    public partial class AddInvestigation : Form
    {
        Dictionary<string, long> dic = new Dictionary<string, long>();

        public AddInvestigation()
        {
            InitializeComponent();
            List<PersonDTO> listPerson = PersonService.FindAll(null);
            List<InvestigatorDTO> listInvestigator = InvestigatorService.FindAll(null);

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
            try
            {
                DateTime today = DateTime.Today;
                long id = long.Parse(today.ToString("yyyyMMdd"));

                List<Animal> listAnimals = this.lstAnimals.Items.Cast<Animal>().ToList();
                List<DocumentCreateDTO> listActivities = this.lstDocuments.Items.Cast<DocumentCreateDTO>().ToList();

                InvestigationCreateDTO investigation = new InvestigationCreateDTO()
                {
                    Id = id,
                    Title = this.txtTitle.Text.Trim(),
                    ComplainantId = this.dic[cmbComplainant.SelectedItem.ToString()],
                    OffenderId = this.dic[cmbOffender.SelectedItem.ToString()],
                    Reason = this.txtReason.Text.Trim(),
                    InvestigatorId = this.dic[cmbInvestigator.SelectedItem.ToString()],
                    Animals = listAnimals,
                    Documents = listActivities,
                    Notice = null,
                    Closed = false
                };
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Impossible d'ajouter une enquête", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void gMapControl_Load(object sender, EventArgs e)
        {
            this.gMapControl.MapProvider = GMapProviders.GoogleMap;
            this.gMapControl.Position = new PointLatLng(49.133333, 6.166667); // Metz
            this.gMapControl.MinZoom = 0;
            this.gMapControl.MaxZoom = 24;
            this.gMapControl.Zoom = 10;
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            AddAnimal addAnimal = new AddAnimal();
            addAnimal.ShowDialog(this);
        }

        private void brnAddDocuments_Click(object sender, EventArgs e)
        {

        }
    }
}
