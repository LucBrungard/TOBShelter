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
using System.IO;

namespace TOBShelter
{
    public partial class AddActivity : Form
    {
        private long investigationId;
        private string[] links = null;

        public AddActivity(long investigationId)
        {
            InitializeComponent();
            this.cmbType.DataSource = Enum.GetValues(typeof(ActivityType));
            this.dtpActivity.Format = DateTimePickerFormat.Custom;
            this.dtpActivity.CustomFormat = "yyyyMMdd";
            this.investigationId = investigationId;
        }
        private void btnAddActivity_Click(object sender, EventArgs e)
        {

            ActivityDTOCreate activity = null;
            try
            {
                activity = new ActivityDTOCreate(this.dtpActivity.Value.ToString("yyyyMMdd"), this.txtDescription.Text, (ActivityType)this.cmbType.SelectedItem, investigationId, links);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Impossible d'ajouter l'activité", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                ActivityDTODetails activityCreated = ActivityService.Create(activity);
            }
            catch (Exception)
            {
                MessageBox.Show("L'ajout d'activité est momentanément indisponible", "Impossible d'ajouter une activité", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbType.SelectedItem.ToString() == "PHOTO")
            {
                try
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string directoryWithId = @"C:\Documents\" + investigationId.ToString();
                        string path = openFileDialog.FileName;

                        if (!Directory.Exists(directoryWithId))
                            Directory.CreateDirectory(directoryWithId);

                        string filePathDestination = directoryWithId + path.Substring(path.LastIndexOf(@"\"));
                        File.Copy(path, filePathDestination, true);
                        this.links.Append(filePathDestination);
                    }
                }
                    catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Impossible d'ajouter une photo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}