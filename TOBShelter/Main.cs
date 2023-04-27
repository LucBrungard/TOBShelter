using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TOBShelter.Types.Dto;

namespace TOBShelter
{
    public partial class Main : Form
    {
        private Icon iconCheck = TOBShelter.Properties.Resources.check;
        private Icon iconCross = TOBShelter.Properties.Resources.cross;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            updateInvestigatorDataGrid(null);
            updateInvestigationDataGrid(null);
            comboBoxInvestigatorAvailibility.SelectedIndex = 0;
        }

        private void updateInvestigatorDataGrid(InvestigatorFilters filter)
        {
            this.dataGridInvestigators.Rows.Clear();

            try
            {
                List<InvestigatorDTO> investigators = Services.InvestigatorService.FindAll(filter).ToList();
                foreach (InvestigatorDTO investigator in investigators)
                {
                    this.dataGridInvestigators.Rows.Add(
                        investigator.Name,
                        investigator.FirstName,
                        investigator.Id,
                        investigator.Available ? iconCheck.ToBitmap() : iconCross.ToBitmap(),
                        investigator.NbInvestigations.ToString()
                        );
                }
            }
            catch (Exception)
            {
                MessageBox.Show("L'accès a la base de données est momentanément indisponible", "Impossible d'accéder à la base de données", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void updateInvestigationDataGrid(InvestigationFilters filter)
        {
            this.dataGridViewInvestigation.Rows.Clear();

            try
            {
                List<InvestigationDTO> investigations = Services.InvestigationService.FindAll(filter).ToList();
                foreach (InvestigationDTO investigation in investigations)
                {
                    this.dataGridViewInvestigation.Rows.Add(
                        investigation.Id,
                        investigation.Title,
                        investigation.InvestigatorFirstName + " " + investigation.InvestigatorName,
                        investigation.LastModification
                        );
                }
            }
            catch (Exception)
            {
                MessageBox.Show("L'accès a la base de données est momentanément indisponible", "Impossible d'accéder à la base de données", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBoxInvestigatorAvailibility_SelectedIndexChanged(object sender, EventArgs e)
        {
            InvestigatorFilters filter = new InvestigatorFilters();
            String item = (string)(sender as ComboBox).SelectedItem;

            if (item == "Disponible")
                filter.Available = true;
            else if (item == "Retraité")
                filter.InOperation = false;
            updateInvestigatorDataGrid(filter);
        }

        private void btnSearchInvestigator_Click(object sender, EventArgs e)
        {
            InvestigatorFilters filters = new InvestigatorFilters();
            string name = this.investigatorSearchName.Text.ToString().Trim();
            string firstName = this.investigatorSearchFirstName.Text.Trim();

            if (name is not null && name != "") filters.Name = name;
            if (firstName is not null && firstName != "") filters.FirstName = firstName;

            updateInvestigatorDataGrid(filters);
        }

        private void btnAddInvestigator_Click(object sender, EventArgs e)
        {
            AddInvestigator f = new AddInvestigator();
            f.ShowDialog(this);
            updateInvestigatorDataGrid(null);
        }

        private void ckxOpenInvestigation_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox isOpen = (sender as CheckBox);
            InvestigationFilters filters = new InvestigationFilters();

            if (isOpen.Checked)
                filters.Closed = false;

            updateInvestigationDataGrid(filters);
        }

        private void btnViewInvestigator_Click(object sender, EventArgs e)
        {
            if (this.dataGridInvestigators.SelectedRows.Count > 0)
            {
                try
                {
                    long id = long.Parse(this.dataGridInvestigators.SelectedRows[0].Cells["ColumnId"].Value.ToString());
                    InvestigatorDetailsDTO investigator = Services.InvestigatorService.FindById(id);
                    new ViewInvestigator(investigator).ShowDialog();
                    updateInvestigatorDataGrid(null);
                }
                catch (Exception)
                {
                    MessageBox.Show("L'accès aux détails de cet enquêteur est momentanément indisponible", "Impossible d'afficher les détails de l'enquêteur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEditInvestigator_Click(object sender, EventArgs e)
        {
            if (this.dataGridInvestigators.SelectedRows.Count > 0)
            {
                try
                {
                    long id = long.Parse(this.dataGridInvestigators.SelectedRows[0].Cells["ColumnId"].Value.ToString());
                    InvestigatorDetailsDTO investigator = Services.InvestigatorService.FindById(id);
                    new EditInvestigator(investigator).ShowDialog();
                    updateInvestigatorDataGrid(null);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cet enquêteur ne peut pas être modifié pour le moment", "Impossible de modifier les informations de l'enquêteur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnAddInvestigation_Click(object sender, EventArgs e)
        {
            AddInvestigation addInvestigation = new AddInvestigation();
            addInvestigation.ShowDialog(this);
            updateInvestigationDataGrid(null);
        }

        private void btnViewInvestigation_Click(object sender, EventArgs e)
        {
        }

        private void btnEditInvestigation_Click(object sender, EventArgs e)
        {
        }
    }
}