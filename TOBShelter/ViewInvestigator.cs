using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOBShelter.Types.Dto;
using TOBShelter.Services;

namespace TOBShelter
{
    public partial class ViewInvestigator : Form
    {
        private InvestigatorDetailsDTO _investigator;

        public ViewInvestigator(InvestigatorDetailsDTO investigator)
        {
            InitializeComponent();
            _investigator = investigator;
            initData();
            updateDataGridInvestigation();
        }

        public void initData()
        {
            this.lblIdentity.Text = _investigator.Title + " " + _investigator.Name + " " + _investigator.FirstName;
            this.lblAddress.Text = _investigator.NumRoute + " " + _investigator.RouteType.ToString().ToLower() + " " + _investigator.RouteName + ", " + _investigator.PostalCode + " " + _investigator.City;
            this.lblTel.Text = "Tel : " + (String.IsNullOrEmpty(_investigator.Home) ? "Non renseigné" : _investigator.Home);
            this.lblMobile.Text = "Mobile : " + (String.IsNullOrEmpty(_investigator.Mobile) ? "Non renseigné" : _investigator.Mobile);
            this.lblEmail.Text = "Email : " + (String.IsNullOrEmpty(_investigator.Email) ? "Non renseigné" : _investigator.Email);
            this.lblSecteur.Text = "Secteur : " + _investigator.BusinessSector + "km";
            this.chkAvailable.Checked = _investigator.Available;
            this.chkInOperation.Checked = _investigator.InOperation;
        }

        private void updateDataGridInvestigation()
        {
            InvestigationFilters filters = new InvestigationFilters
            {
                InvestigatorId = _investigator.Id,
                Closed = false
            };

            try
            {
                List<InvestigationDTO> investigations = InvestigationService.FindAll(filters);

                foreach (InvestigationDTO investigation in investigations)
                {
                    this.dataGridViewInvestigations.Rows.Add(
                        investigation.Id, 
                        investigation.Title, 
                        investigation.LastModification);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("L'accès a la base de données est momentanément indisponible", "Impossible d'accéder à la base de données", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditInvestigator fEdit = new EditInvestigator(_investigator);
            fEdit.ShowDialog();
            Console.WriteLine("tada " + fEdit._investigator.ToString());
            if (!fEdit._investigator.Equals(_investigator))
            {
                _investigator = fEdit._investigator;
                initData();
            }
        }

        private void btnDetailInvestigation_Click(object sender, EventArgs e)
        {
            // TODO check quand des enquetes auront été ajoutées.
            //if (this.dataGridViewInvestigations.SelectedRows.Count > 0)
            //{
            //    try
            //    {
            //        long id = long.Parse(this.dataGridViewInvestigations.SelectedRows[0].Cells["ColumnId"].Value.ToString());
            //        InvestigationDetailsDTO investigation = TOBShelter.Services.InvestigationService.FindById(id);
            //        new ViewInvestigation(investigation).ShowDialog();
            //        updateDataGridInvestigation();
            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show("L'accès aux détails de cet enquête est momentanément indisponible", "Impossible d'afficher les détails de l'enquêteur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
        }
    }
}