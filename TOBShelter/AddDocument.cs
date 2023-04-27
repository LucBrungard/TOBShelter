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
        long id;
        public AddDocument(long id)
        {
            this.id = id;
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
                string dir = "TOBShelter\\TOBShelter\\Documents\\" + this.id.ToString();
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                DocumentCreateDTO document = new DocumentCreateDTO()
                {
                    Path = dir + this.lblPath.Text.Substring(this.lblPath.Text.LastIndexOf("\\") + 1),
                    InvestigationId = this.id
                };

                /*try
                {*/
                    DocumentDetailsDTO createdInvestigator = Services.DocumentService.Create(document);
                    this.Close();
                /*}
                catch (Exception)
                {
                    MessageBox.Show("Impossible d'ajouter un document pour le moment.", "Impossible d'ajouter un document", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Impossible d'ajouter un document", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
