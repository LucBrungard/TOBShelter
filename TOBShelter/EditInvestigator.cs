using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOBShelter.Types.Base;
using TOBShelter.Types.Dto;
using TOBShelter.Services;

namespace TOBShelter
{
    public partial class EditInvestigator : Form
    {
        public InvestigatorDetailsDTO _investigator;

        public EditInvestigator(InvestigatorDetailsDTO investigator)
        {
            InitializeComponent();
            this.cbxCivility.DataSource = Enum.GetValues(typeof(IdentityTitle));
            this.cbxRouteType.DataSource = Enum.GetValues(typeof(RouteType));
            this.cbxCivility.SelectedItem = investigator.Title;
            this.txtName.Text = investigator.Name;
            this.txtFirstName.Text = investigator.FirstName;
            this.txtNumber.Text = investigator.NumRoute;
            this.cbxRouteType.SelectedItem = investigator.RouteType;
            this.txtRouteName.Text = investigator.RouteName;
            this.txtPostalCode.Text = investigator.PostalCode;
            this.txtCity.Text = investigator.City;
            this.txtTel.Text = investigator.Home;
            this.txtMobile.Text = investigator.Mobile;
            this.txtSector.Text = investigator.BusinessSector;
            this.chkAvailable.Checked = investigator.Available;
            this.chkInOperation.Checked = investigator.InOperation;
            this._investigator = investigator;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                InvestigatorEditDTO investigator = new InvestigatorEditDTO();
                investigator.Id = this._investigator.Id;
                investigator.Title = (IdentityTitle)this.cbxCivility.SelectedItem;
                investigator.Name = this.txtName.Text;
                investigator.FirstName = this.txtFirstName.Text;
                investigator.NumRoute = this.txtNumber.Text;
                investigator.RouteType = (RouteType)this.cbxRouteType.SelectedItem;
                investigator.RouteName = this.txtRouteName.Text;
                investigator.PostalCode = this.txtPostalCode.Text;
                investigator.City = this.txtCity.Text;
                investigator.Home = this.txtTel.Text;
                investigator.Mobile = this.txtMobile.Text;
                investigator.BusinessSector = this.txtSector.Text;
                investigator.Available = this.chkAvailable.Checked;
                investigator.InOperation = this.chkInOperation.Checked;
                try
                {
                    _investigator = InvestigatorService.Update(investigator);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Impossible de modifier cet enquêteur pour le moment.", "Impossible de modifier cet enquêteur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Impossible de modifier cet enquêteur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkInOperation_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBox inOperation = (CheckBox)sender;
            if (!inOperation.Checked) this.chkAvailable.Checked = false;
        }
    }
}