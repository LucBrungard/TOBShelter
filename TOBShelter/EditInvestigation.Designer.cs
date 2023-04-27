
namespace TOBShelter
{
    partial class EditInvestigation
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstActivities = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstAnimals = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEditInvestigation = new System.Windows.Forms.Button();
            this.brnAddDocuments = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNotice = new System.Windows.Forms.TextBox();
            this.chkClosed = new System.Windows.Forms.CheckBox();
            this.lblNotice = new System.Windows.Forms.Label();
            this.txtComplaignant = new System.Windows.Forms.TextBox();
            this.txtOffender = new System.Windows.Forms.TextBox();
            this.btnAddInvestigator = new System.Windows.Forms.Button();
            this.cmbInvestigator = new System.Windows.Forms.ComboBox();
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Activités";
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
            // lstActivities
            // 
            this.lstActivities.FormattingEnabled = true;
            this.lstActivities.Location = new System.Drawing.Point(344, 32);
            this.lstActivities.Name = "lstActivities";
            this.lstActivities.Size = new System.Drawing.Size(294, 134);
            this.lstActivities.TabIndex = 12;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtReason);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 76);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enquete";
            // 
            // txtReason
            // 
            this.txtReason.Enabled = false;
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
            // lstAnimals
            // 
            this.lstAnimals.FormattingEnabled = true;
            this.lstAnimals.Location = new System.Drawing.Point(27, 32);
            this.lstAnimals.Name = "lstAnimals";
            this.lstAnimals.Size = new System.Drawing.Size(294, 134);
            this.lstAnimals.TabIndex = 13;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gMapControl);
            this.groupBox2.Controls.Add(this.btnAddInvestigator);
            this.groupBox2.Controls.Add(this.cmbInvestigator);
            this.groupBox2.Controls.Add(this.txtOffender);
            this.groupBox2.Controls.Add(this.txtComplaignant);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 229);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personnes concernées";
            // 
            // btnEditInvestigation
            // 
            this.btnEditInvestigation.Location = new System.Drawing.Point(305, 715);
            this.btnEditInvestigation.Name = "btnEditInvestigation";
            this.btnEditInvestigation.Size = new System.Drawing.Size(75, 23);
            this.btnEditInvestigation.TabIndex = 19;
            this.btnEditInvestigation.Text = "Modifier";
            this.btnEditInvestigation.UseVisualStyleBackColor = true;
            this.btnEditInvestigation.Click += new System.EventHandler(this.btnEditInvestigation_Click);
            // 
            // brnAddDocuments
            // 
            this.brnAddDocuments.Location = new System.Drawing.Point(407, 171);
            this.brnAddDocuments.Margin = new System.Windows.Forms.Padding(2);
            this.brnAddDocuments.Name = "brnAddDocuments";
            this.brnAddDocuments.Size = new System.Drawing.Size(169, 23);
            this.brnAddDocuments.TabIndex = 11;
            this.brnAddDocuments.Text = "Ajouter une activité";
            this.brnAddDocuments.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lstAnimals);
            this.groupBox3.Controls.Add(this.lstActivities);
            this.groupBox3.Controls.Add(this.brnAddDocuments);
            this.groupBox3.Location = new System.Drawing.Point(12, 332);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(660, 208);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Animaux et Activités";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtNotice);
            this.groupBox4.Controls.Add(this.chkClosed);
            this.groupBox4.Controls.Add(this.lblNotice);
            this.groupBox4.Location = new System.Drawing.Point(12, 546);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(660, 163);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cloture";
            // 
            // txtNotice
            // 
            this.txtNotice.Enabled = false;
            this.txtNotice.Location = new System.Drawing.Point(27, 55);
            this.txtNotice.Multiline = true;
            this.txtNotice.Name = "txtNotice";
            this.txtNotice.Size = new System.Drawing.Size(611, 99);
            this.txtNotice.TabIndex = 17;
            // 
            // chkClosed
            // 
            this.chkClosed.AutoSize = true;
            this.chkClosed.Location = new System.Drawing.Point(27, 19);
            this.chkClosed.Name = "chkClosed";
            this.chkClosed.Size = new System.Drawing.Size(101, 17);
            this.chkClosed.TabIndex = 16;
            this.chkClosed.Text = "Enquête cloturé";
            this.chkClosed.UseVisualStyleBackColor = true;
            this.chkClosed.CheckedChanged += new System.EventHandler(this.chkClosed_CheckedChanged);
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.Enabled = false;
            this.lblNotice.Location = new System.Drawing.Point(24, 39);
            this.lblNotice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(27, 13);
            this.lblNotice.TabIndex = 15;
            this.lblNotice.Text = "Avis";
            // 
            // txtComplaignant
            // 
            this.txtComplaignant.Enabled = false;
            this.txtComplaignant.Location = new System.Drawing.Point(27, 43);
            this.txtComplaignant.Name = "txtComplaignant";
            this.txtComplaignant.Size = new System.Drawing.Size(169, 20);
            this.txtComplaignant.TabIndex = 16;
            // 
            // txtOffender
            // 
            this.txtOffender.Enabled = false;
            this.txtOffender.Location = new System.Drawing.Point(247, 43);
            this.txtOffender.Name = "txtOffender";
            this.txtOffender.Size = new System.Drawing.Size(169, 20);
            this.txtOffender.TabIndex = 17;
            // 
            // btnAddInvestigator
            // 
            this.btnAddInvestigator.Location = new System.Drawing.Point(467, 83);
            this.btnAddInvestigator.Name = "btnAddInvestigator";
            this.btnAddInvestigator.Size = new System.Drawing.Size(169, 23);
            this.btnAddInvestigator.TabIndex = 19;
            this.btnAddInvestigator.Text = "Ajouter un enquêteur";
            this.btnAddInvestigator.UseVisualStyleBackColor = true;
            this.btnAddInvestigator.Click += new System.EventHandler(this.btnAddInvestigator_Click_1);
            // 
            // cmbInvestigator
            // 
            this.cmbInvestigator.FormattingEnabled = true;
            this.cmbInvestigator.Location = new System.Drawing.Point(467, 45);
            this.cmbInvestigator.Margin = new System.Windows.Forms.Padding(2);
            this.cmbInvestigator.Name = "cmbInvestigator";
            this.cmbInvestigator.Size = new System.Drawing.Size(169, 21);
            this.cmbInvestigator.TabIndex = 18;
            // 
            // gMapControl
            // 
            this.gMapControl.Bearing = 0F;
            this.gMapControl.CanDragMap = true;
            this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl.GrayScaleMode = false;
            this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl.LevelsKeepInMemory = 5;
            this.gMapControl.Location = new System.Drawing.Point(27, 69);
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
            this.gMapControl.Size = new System.Drawing.Size(389, 145);
            this.gMapControl.TabIndex = 20;
            this.gMapControl.Zoom = 0D;
            this.gMapControl.Load += new System.EventHandler(this.gMapControl_Load);
            // 
            // EditInvestigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 789);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnEditInvestigation);
            this.Controls.Add(this.groupBox3);
            this.Name = "EditInvestigation";
            this.Text = "EditInvestigation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstActivities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstAnimals;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditInvestigation;
        private System.Windows.Forms.Button brnAddDocuments;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtNotice;
        private System.Windows.Forms.CheckBox chkClosed;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.Button btnAddInvestigator;
        private System.Windows.Forms.ComboBox cmbInvestigator;
        private System.Windows.Forms.TextBox txtOffender;
        private System.Windows.Forms.TextBox txtComplaignant;
        private GMap.NET.WindowsForms.GMapControl gMapControl;
    }
}