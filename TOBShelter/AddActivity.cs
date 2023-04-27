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
        private long _investigationId;

        public AddActivity(long investigationId)
        {
            InitializeComponent();
            this.comboBox1.DataSource = Enum.GetValues(typeof(ActivityType));
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.CustomFormat = "yyyyMMdd";
            this._investigationId = investigationId;
        }

        private void add_Click(object sender, EventArgs e)
        {
            string[] links = null;
            ActivityDTOCreate activity = null;
            if (this.comboBox1.SelectedItem.ToString() == "PHOTO")
            {
                try
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string directoryWithId = @"C:\Documents\" + _investigationId.ToString();
                        string path = openFileDialog.FileName;
                        if (!Directory.Exists(directoryWithId))
                            Directory.CreateDirectory(directoryWithId);
                        string filePathDestination = directoryWithId + path.Substring(path.LastIndexOf(@"\"));
                        File.Copy(path, filePathDestination, true);
                        links.Append(filePathDestination);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Impossible d'ajouter une photo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            try
            {
                activity = new ActivityDTOCreate(this.dateTimePicker1.Value, this.textBox1.Text, (ActivityType)this.comboBox1.SelectedItem, _investigationId, links);
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
    }
}