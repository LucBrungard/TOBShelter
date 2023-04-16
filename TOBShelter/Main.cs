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
            this.dataGridInvestigators.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            this.dataGridInvestigators.AlternatingRowsDefaultCellStyle.BackColor =
                Color.White;
        }

        private void updateInvestigatorDataGrid(InvestigatorFilters filter)
        {
            this.dataGridInvestigators.Rows.Clear();

            List<InvestigatorDTO> investigators = TOBShelter.Services.InvestigatorService.FindAll(filter).ToList();
            foreach (InvestigatorDTO investigator in investigators)
            {
                this.dataGridInvestigators.Rows.Add(
                    investigator.Name,
                    investigator.FirstName,
                    investigator.Available ? iconCheck.ToBitmap() : iconCross.ToBitmap(),
                    investigator.NbInvestigations.ToString());
            }
        }

        private void updateInvestigationDataGrid(InvestigationFilters filter)
        {
            this.dataGridInvestigators.Rows.Clear();

            List<InvestigationDTO> investigations = TOBShelter.Services.InvestigationService.FindAll(filter).ToList();
            foreach (InvestigationDTO investigation in investigations)
            {
                this.dataGridInvestigators.Rows.Add(
                    investigation.Id,
                    investigation.Title,
                    investigation.InvestigatorFirstName + " " + investigation.InvestigatorName
                    // TODO Ajouter date de derniere modif
                    );
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
        }

        private void ckxOpenInvestigation_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox isOpen = (sender as CheckBox);
            InvestigationFilters filters = new InvestigationFilters();

            if (isOpen.Checked)
                filters.Closed = false;

            updateInvestigationDataGrid(filters);
        }
    }
}