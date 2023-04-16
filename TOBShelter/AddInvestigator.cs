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
using TOBShelter.Types.Base;

namespace TOBShelter
{
    public partial class AddInvestigator : Form
    {
        public AddInvestigator()
        {
            InitializeComponent();
            this.cbxCivility.DataSource = Enum.GetValues(typeof(IdentityTitle));
            this.cbxRouteType.DataSource = Enum.GetValues(typeof(RouteType));
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                InvestigatorCreateDTO investigator = new InvestigatorCreateDTO(
                                (IdentityTitle)this.cbxCivility.SelectedItem,
                                this.txtName.Text,
                                this.txtFirstName.Text,
                                this.txtNumber.Text,
                                (RouteType)this.cbxRouteType.SelectedItem,
                                this.txtRouteName.Text,
                                this.txtPostalCode.Text,
                                this.txtCity.Text,
                                true,
                                true,
                                this.txtSector.Text
                                );

                if (!String.IsNullOrEmpty(this.txtTel.Text))
                    investigator.Home = this.txtTel.Text;

                if (!String.IsNullOrEmpty(this.txtMobile.Text))
                    investigator.Mobile = this.txtMobile.Text;

                if (!String.IsNullOrEmpty(this.txtEmail.Text))
                    investigator.Email = this.txtEmail.Text;

                try
                {
                    InvestigatorDetailsDTO createdInvestigator = TOBShelter.Services.InvestigatorService.Create(investigator, true);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Impossible d'ajouter un enquêteur pour le moment. Vérifier qu'il n'est pas déjà présent dans la base de données", "Impossible d'ajouter un enquêteur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Certains champs obligatoires sont vides ou mal renseignés.", "Impossible d'ajouter un enquêteur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}