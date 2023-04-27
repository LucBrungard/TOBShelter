
namespace TOBShelter
{
    partial class ViewInvestigator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSecteur = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.chkInOperation = new System.Windows.Forms.CheckBox();
            this.chkAvailable = new System.Windows.Forms.CheckBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblIdentity = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDetailInvestigation = new System.Windows.Forms.Button();
            this.dataGridViewInvestigations = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvestigations)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSecteur);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.chkInOperation);
            this.groupBox1.Controls.Add(this.chkAvailable);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblMobile);
            this.groupBox1.Controls.Add(this.lblTel);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblIdentity);
            this.groupBox1.Location = new System.Drawing.Point(24, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(864, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations personnelles";
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Location = new System.Drawing.Point(400, 160);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(69, 17);
            this.lblSecteur.TabIndex = 10;
            this.lblSecteur.Text = "Secteur : ";
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::TOBShelter.Properties.Resources.edit_small2;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.Location = new System.Drawing.Point(744, 154);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(96, 32);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Modifier";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // chkInOperation
            // 
            this.chkInOperation.AutoSize = true;
            this.chkInOperation.Enabled = false;
            this.chkInOperation.Location = new System.Drawing.Point(208, 159);
            this.chkInOperation.Name = "chkInOperation";
            this.chkInOperation.Size = new System.Drawing.Size(95, 21);
            this.chkInOperation.TabIndex = 8;
            this.chkInOperation.Text = "En activité";
            this.chkInOperation.UseVisualStyleBackColor = true;
            // 
            // chkAvailable
            // 
            this.chkAvailable.AutoSize = true;
            this.chkAvailable.Enabled = false;
            this.chkAvailable.Location = new System.Drawing.Point(24, 159);
            this.chkAvailable.Name = "chkAvailable";
            this.chkAvailable.Size = new System.Drawing.Size(96, 21);
            this.chkAvailable.TabIndex = 7;
            this.chkAvailable.Text = "Disponible";
            this.chkAvailable.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(24, 127);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 17);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email : ";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(402, 95);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(61, 17);
            this.lblMobile.TabIndex = 5;
            this.lblMobile.Text = "Mobile : ";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(24, 95);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(40, 17);
            this.lblTel.TabIndex = 4;
            this.lblTel.Text = "Tel : ";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(24, 63);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(60, 17);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Adresse";
            // 
            // lblIdentity
            // 
            this.lblIdentity.AutoSize = true;
            this.lblIdentity.Location = new System.Drawing.Point(24, 31);
            this.lblIdentity.Name = "lblIdentity";
            this.lblIdentity.Size = new System.Drawing.Size(54, 17);
            this.lblIdentity.TabIndex = 2;
            this.lblIdentity.Text = "Identité";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDetailInvestigation);
            this.groupBox2.Controls.Add(this.dataGridViewInvestigations);
            this.groupBox2.Location = new System.Drawing.Point(24, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(864, 288);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enquêtes en cours";
            // 
            // btnDetailInvestigation
            // 
            this.btnDetailInvestigation.Image = global::TOBShelter.Properties.Resources.details_small2;
            this.btnDetailInvestigation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetailInvestigation.Location = new System.Drawing.Point(332, 248);
            this.btnDetailInvestigation.Name = "btnDetailInvestigation";
            this.btnDetailInvestigation.Size = new System.Drawing.Size(200, 32);
            this.btnDetailInvestigation.TabIndex = 11;
            this.btnDetailInvestigation.Text = "Afficher plus de détails";
            this.btnDetailInvestigation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetailInvestigation.UseVisualStyleBackColor = true;
            this.btnDetailInvestigation.Click += new System.EventHandler(this.btnDetailInvestigation_Click);
            // 
            // dataGridViewInvestigations
            // 
            this.dataGridViewInvestigations.AllowUserToAddRows = false;
            this.dataGridViewInvestigations.AllowUserToDeleteRows = false;
            this.dataGridViewInvestigations.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(215)))), ((int)(((byte)(208)))));
            this.dataGridViewInvestigations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewInvestigations.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewInvestigations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInvestigations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewInvestigations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvestigations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewInvestigations.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewInvestigations.Location = new System.Drawing.Point(24, 40);
            this.dataGridViewInvestigations.MultiSelect = false;
            this.dataGridViewInvestigations.Name = "dataGridViewInvestigations";
            this.dataGridViewInvestigations.ReadOnly = true;
            this.dataGridViewInvestigations.RowHeadersVisible = false;
            this.dataGridViewInvestigations.RowHeadersWidth = 51;
            this.dataGridViewInvestigations.RowTemplate.Height = 24;
            this.dataGridViewInvestigations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInvestigations.Size = new System.Drawing.Size(816, 200);
            this.dataGridViewInvestigations.TabIndex = 0;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Identifiant";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 140;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Intitulé";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 318;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Dernière modification";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // ViewInvestigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 567);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ViewInvestigator";
            this.Text = "ViewInvestigator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvestigations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.CheckBox chkInOperation;
        private System.Windows.Forms.CheckBox chkAvailable;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblIdentity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.Button btnDetailInvestigation;
        private System.Windows.Forms.DataGridView dataGridViewInvestigations;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}