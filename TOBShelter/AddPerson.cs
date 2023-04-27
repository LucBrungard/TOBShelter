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
    public partial class AddPerson : Form
    {
        public PersonDetailsDTO createdPerson = null;

        public AddPerson()

        {
            InitializeComponent();
            this.cbxCivility.DataSource = Enum.GetValues(typeof(IdentityTitle));
            this.cbxRouteType.DataSource = Enum.GetValues(typeof(RouteType));
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                PersonCreateDTO person = new PersonCreateDTO(
                    (IdentityTitle)this.cbxCivility.SelectedItem,
                    this.txtName.Text.ToUpper(),
                    this.txtFirstName.Text,
                    this.txtNumber.Text,
                    (RouteType)this.cbxRouteType.SelectedItem,
                    this.txtRouteName.Text,
                    this.txtPostalCode.Text,
                    this.txtCity.Text);

                if (!String.IsNullOrEmpty(this.txtTel.Text))
                    person.Home = this.txtTel.Text;

                if (!String.IsNullOrEmpty(this.txtMobile.Text))
                    person.Mobile = this.txtMobile.Text;

                if (!String.IsNullOrEmpty(this.txtEmail.Text))
                    person.Email = this.txtEmail.Text;

                try
                {
                    createdPerson = TOBShelter.Services.PersonService.Create(person);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Impossible d'ajouter une personne pour le moment. Vérifier qu'elle n'est pas déjà présente dans la base de données", "Impossible d'ajouter une nouvelle personne", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Certains champs obligatoires sont vides ou mal renseignés.", "Impossible d'ajouter une nouvelle personne", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}