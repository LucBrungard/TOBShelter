using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOBShelter.Services;
using TOBShelter.Types.Composed;
using TOBShelter.Types.Dto;

namespace TOBShelter
{
    public partial class ViewInvestigation : Form
    {
        public ViewInvestigation(InvestigationDetailsDTO investigation)
        {
            InitializeComponent();

            this.lblTitle.Text = investigation.Title;
            this.lblReason.Text = investigation.Reason;
            this.lblComplaignant.Text = investigation.Complainant.FirstName + " " + investigation.Complainant.Name;
            this.lblOffender.Text = investigation.Offender.FirstName + " " + investigation.Offender.Name;
            this.lblInvestigator.Text = investigation.Investigator.FirstName + " " + investigation.Investigator.Name;

            if (investigation.Closed)
            {
                this.lblClosed.Text = "Enquête cloturé";
                this.lblClosed.ForeColor = Color.Red;
            }
            else
            {
                this.lblClosed.Text = "Enquête ouverte";
                this.lblClosed.ForeColor = Color.Green;
            }

            if (investigation.Notice != null)
                this.txtNotice.Text = investigation.Notice;

            foreach (Animal animal in investigation.Animals)
            {
                this.lstAnimals.Items.Add(animal.Name);
            }

            ActivityFilters filter = new ActivityFilters();
            filter.InvestigationId = investigation.Id;

            List<ActivityDTO> activities = ActivityService.FindAll(filter);
            foreach (ActivityDTO activity in activities)
            {
                this.lstActivities.Items.Add(activity.Description);
            }
        }
    }
}
