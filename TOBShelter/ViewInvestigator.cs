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
            this.lblTel.Text += String.IsNullOrEmpty(_investigator.Home) ? "Non renseigné" : _investigator.Home;
            this.lblMobile.Text += String.IsNullOrEmpty(_investigator.Mobile) ? "Non renseigné" : _investigator.Mobile;
            this.lblEmail.Text += String.IsNullOrEmpty(_investigator.Email) ? "Non renseigné" : _investigator.Email;
            this.lblSecteur.Text += _investigator.BusinessSector + "km";
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

            List<InvestigationDTO> investigations = InvestigationService.FindAll(filters);

            foreach (InvestigationDTO investigation in investigations)
            {
                this.dataGridViewInvestigations.Rows.Add(investigation.Id, investigation.Title, investigation.LastModification);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditInvestigator fEdit = new EditInvestigator(_investigator);
            this.ShowDialog();
        }

        private void btnDetailInvestigation_Click(object sender, EventArgs e)
        {
        }
    }
}