
namespace TOBShelter
{
    partial class AddInvestigation
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cmbComplainant = new System.Windows.Forms.ComboBox();
            this.cmbOffender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.brnAddDocuments = new System.Windows.Forms.Button();
            this.btnAddInvestigation = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbInvestigator = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.btnAddInvestigator = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstAnimals = new System.Windows.Forms.ListBox();
            this.lstDocuments = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titre de l\'enquête";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(27, 40);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(295, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // cmbComplainant
            // 
            this.cmbComplainant.FormattingEnabled = true;
            this.cmbComplainant.Location = new System.Drawing.Point(27, 46);
            this.cmbComplainant.Margin = new System.Windows.Forms.Padding(2);
            this.cmbComplainant.Name = "cmbComplainant";
            this.cmbComplainant.Size = new System.Drawing.Size(169, 21);
            this.cmbComplainant.TabIndex = 2;
            // 
            // cmbOffender
            // 
            this.cmbOffender.FormattingEnabled = true;
            this.cmbOffender.Location = new System.Drawing.Point(247, 46);
            this.cmbOffender.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOffender.Name = "cmbOffender";
            this.cmbOffender.Size = new System.Drawing.Size(169, 21);
            this.cmbOffender.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Plaignant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Infracteur suspecté";
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(90, 171);
            this.btnAddAnimal.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(169, 23);
            this.btnAddAnimal.TabIndex = 8;
            this.btnAddAnimal.Text = "Ajouter un animal";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(344, 40);
            this.txtReason.Margin = new System.Windows.Forms.Padding(2);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(295, 20);
            this.txtReason.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Motif";
            // 
            // brnAddDocuments
            // 
            this.brnAddDocuments.Location = new System.Drawing.Point(407, 171);
            this.brnAddDocuments.Margin = new System.Windows.Forms.Padding(2);
            this.brnAddDocuments.Name = "brnAddDocuments";
            this.brnAddDocuments.Size = new System.Drawing.Size(169, 23);
            this.brnAddDocuments.TabIndex = 11;
            this.brnAddDocuments.Text = "Ajouter un document";
            this.brnAddDocuments.UseVisualStyleBackColor = true;
            this.brnAddDocuments.Click += new System.EventHandler(this.brnAddDocuments_Click);
            // 
            // btnAddInvestigation
            // 
            this.btnAddInvestigation.Location = new System.Drawing.Point(300, 614);
            this.btnAddInvestigation.Name = "btnAddInvestigation";
            this.btnAddInvestigation.Size = new System.Drawing.Size(75, 23);
            this.btnAddInvestigation.TabIndex = 13;
            this.btnAddInvestigation.Text = "Ajouter";
            this.btnAddInvestigation.UseVisualStyleBackColor = true;
            this.btnAddInvestigation.Click += new System.EventHandler(this.btnAddInvestigation_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Enqueteur Titulaire";
            // 
            // cmbInvestigator
            // 
            this.cmbInvestigator.FormattingEnabled = true;
            this.cmbInvestigator.Location = new System.Drawing.Point(467, 46);
            this.cmbInvestigator.Margin = new System.Windows.Forms.Padding(2);
            this.cmbInvestigator.Name = "cmbInvestigator";
            this.cmbInvestigator.Size = new System.Drawing.Size(169, 21);
            this.cmbInvestigator.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtReason);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 76);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enquete";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gMapControl);
            this.groupBox2.Controls.Add(this.btnAddInvestigator);
            this.groupBox2.Controls.Add(this.btnAddPerson);
            this.groupBox2.Controls.Add(this.cmbOffender);
            this.groupBox2.Controls.Add(this.cmbComplainant);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbInvestigator);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 287);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personnes concernées";
            // 
            // gMapControl
            // 
            this.gMapControl.Bearing = 0F;
            this.gMapControl.CanDragMap = true;
            this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl.GrayScaleMode = false;
            this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl.LevelsKeepInMemory = 5;
            this.gMapControl.Location = new System.Drawing.Point(27, 124);
            this.gMapControl.MarkersEnabled = true;
            this.gMapControl.MaxZoom = 2;
            this.gMapControl.MinZoom = 2;
            this.gMapControl.MouseWheelZoomEnabled = true;
            this.gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl.Name = "gMapControl";
            this.gMapControl.NegativeMode = false;
            this.gMapControl.PolygonsEnabled = true;
            this.gMapControl.RetryLoadTile = 0;
            this.gMapControl.RoutesEnabled = true;
            this.gMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl.ShowTileGridLines = false;
            this.gMapControl.Size = new System.Drawing.Size(609, 145);
            this.gMapControl.TabIndex = 17;
            this.gMapControl.Zoom = 0D;
            this.gMapControl.Load += new System.EventHandler(this.gMapControl_Load);
            // 
            // btnAddInvestigator
            // 
            this.btnAddInvestigator.Location = new System.Drawing.Point(467, 84);
            this.btnAddInvestigator.Name = "btnAddInvestigator";
            this.btnAddInvestigator.Size = new System.Drawing.Size(169, 23);
            this.btnAddInvestigator.TabIndex = 16;
            this.btnAddInvestigator.Text = "Ajouter un enquêteur";
            this.btnAddInvestigator.UseVisualStyleBackColor = true;
            this.btnAddInvestigator.Click += new System.EventHandler(this.btnAddInvestigator_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(27, 84);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(169, 23);
            this.btnAddPerson.TabIndex = 14;
            this.btnAddPerson.Text = "Ajouter une personne";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lstAnimals);
            this.groupBox3.Controls.Add(this.lstDocuments);
            this.groupBox3.Controls.Add(this.btnAddAnimal);
            this.groupBox3.Controls.Add(this.brnAddDocuments);
            this.groupBox3.Location = new System.Drawing.Point(12, 387);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(660, 208);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Animaux et Documents";
            // 
            // lstAnimals
            // 
            this.lstAnimals.FormattingEnabled = true;
            this.lstAnimals.Location = new System.Drawing.Point(27, 32);
            this.lstAnimals.Name = "lstAnimals";
            this.lstAnimals.Size = new System.Drawing.Size(294, 134);
            this.lstAnimals.TabIndex = 13;
            // 
            // lstDocuments
            // 
            this.lstDocuments.FormattingEnabled = true;
            this.lstDocuments.Location = new System.Drawing.Point(344, 32);
            this.lstDocuments.Name = "lstDocuments";
            this.lstDocuments.Size = new System.Drawing.Size(294, 134);
            this.lstDocuments.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Animaux";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Documents";
            // 
            // AddInvestigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 655);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddInvestigation);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddInvestigation";
            this.Text = "AddInvestigation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cmbComplainant;
        private System.Windows.Forms.ComboBox cmbOffender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button brnAddDocuments;
        private System.Windows.Forms.Button btnAddInvestigation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbInvestigator;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstAnimals;
        private System.Windows.Forms.ListBox lstDocuments;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnAddInvestigator;
        private GMap.NET.WindowsForms.GMapControl gMapControl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}