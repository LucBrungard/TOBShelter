using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOBShelter.Types.Dto;

namespace TOBShelter
{
    public partial class AddDocument : Form
    {
        const string directory = @"C:\Documents\";
        private string directoryWithId;
        private long id;
        public DocumentCreateDTO document;

        public AddDocument(long id)
        {
            this.id = id;
            this.directoryWithId = directory + id.ToString();
            InitializeComponent();
        }

        private void btnParcourir_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    this.lblPath.Text = openFileDialog.FileName;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Impossible d'ajouter un document", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddDocument_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(this.directoryWithId))
                {
                    Directory.CreateDirectory(this.directoryWithId);
                }
                string filePathDestination = this.directoryWithId + this.lblPath.Text.Substring(this.lblPath.Text.LastIndexOf(@"\"));
                File.Copy(this.lblPath.Text, filePathDestination, true);

                this.document = new DocumentCreateDTO()
                {
                    Path = filePathDestination,
                    InvestigationId = this.id
                };

                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Impossible d'ajouter un document", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
