﻿
namespace TOBShelter
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.investigatorSearchFirstName = new System.Windows.Forms.TextBox();
            this.btnSearchInvestigator = new System.Windows.Forms.Button();
            this.investigatorSearchName = new System.Windows.Forms.TextBox();
            this.comboBoxInvestigatorAvailibility = new System.Windows.Forms.ComboBox();
            this.dataGridInvestigators = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddInvestigator = new System.Windows.Forms.Button();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInvestigators)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(917, 571);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(909, 523);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enquêtes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.investigatorSearchFirstName);
            this.tabPage2.Controls.Add(this.btnSearchInvestigator);
            this.tabPage2.Controls.Add(this.investigatorSearchName);
            this.tabPage2.Controls.Add(this.comboBoxInvestigatorAvailibility);
            this.tabPage2.Controls.Add(this.dataGridInvestigators);
            this.tabPage2.Controls.Add(this.btnAddInvestigator);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(909, 523);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Enquêteurs";
            // 
            // investigatorSearchFirstName
            // 
            this.investigatorSearchFirstName.Location = new System.Drawing.Point(205, 30);
            this.investigatorSearchFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.investigatorSearchFirstName.MinimumSize = new System.Drawing.Size(123, 22);
            this.investigatorSearchFirstName.Name = "investigatorSearchFirstName";
            this.investigatorSearchFirstName.Size = new System.Drawing.Size(123, 22);
            this.investigatorSearchFirstName.TabIndex = 9;
            // 
            // btnSearchInvestigator
            // 
            this.btnSearchInvestigator.BackgroundImage = global::TOBShelter.Properties.Resources.search;
            this.btnSearchInvestigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchInvestigator.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSearchInvestigator.Location = new System.Drawing.Point(331, 30);
            this.btnSearchInvestigator.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchInvestigator.Name = "btnSearchInvestigator";
            this.btnSearchInvestigator.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchInvestigator.Size = new System.Drawing.Size(32, 30);
            this.btnSearchInvestigator.TabIndex = 8;
            this.btnSearchInvestigator.UseVisualStyleBackColor = true;
            this.btnSearchInvestigator.Click += new System.EventHandler(this.btnSearchInvestigator_Click);
            // 
            // investigatorSearchName
            // 
            this.investigatorSearchName.Location = new System.Drawing.Point(43, 30);
            this.investigatorSearchName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.investigatorSearchName.MinimumSize = new System.Drawing.Size(123, 22);
            this.investigatorSearchName.Name = "investigatorSearchName";
            this.investigatorSearchName.Size = new System.Drawing.Size(148, 22);
            this.investigatorSearchName.TabIndex = 7;
            // 
            // comboBoxInvestigatorAvailibility
            // 
            this.comboBoxInvestigatorAvailibility.FormattingEnabled = true;
            this.comboBoxInvestigatorAvailibility.Items.AddRange(new object[] {
            "Tous",
            "Disponible",
            "Retraité"});
            this.comboBoxInvestigatorAvailibility.Location = new System.Drawing.Point(693, 30);
            this.comboBoxInvestigatorAvailibility.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxInvestigatorAvailibility.MaxLength = 32;
            this.comboBoxInvestigatorAvailibility.MinimumSize = new System.Drawing.Size(100, 0);
            this.comboBoxInvestigatorAvailibility.Name = "comboBoxInvestigatorAvailibility";
            this.comboBoxInvestigatorAvailibility.Size = new System.Drawing.Size(169, 24);
            this.comboBoxInvestigatorAvailibility.TabIndex = 4;
            this.comboBoxInvestigatorAvailibility.SelectedIndexChanged += new System.EventHandler(this.comboBoxInvestigatorAvailibility_SelectedIndexChanged);
            // 
            // dataGridInvestigators
            // 
            this.dataGridInvestigators.AllowUserToAddRows = false;
            this.dataGridInvestigators.AllowUserToDeleteRows = false;
            this.dataGridInvestigators.AllowUserToOrderColumns = true;
            this.dataGridInvestigators.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridInvestigators.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridInvestigators.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInvestigators.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridInvestigators.Location = new System.Drawing.Point(33, 89);
            this.dataGridInvestigators.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridInvestigators.MultiSelect = false;
            this.dataGridInvestigators.Name = "dataGridInvestigators";
            this.dataGridInvestigators.ReadOnly = true;
            this.dataGridInvestigators.RowHeadersVisible = false;
            this.dataGridInvestigators.RowHeadersWidth = 51;
            this.dataGridInvestigators.RowTemplate.Height = 24;
            this.dataGridInvestigators.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridInvestigators.Size = new System.Drawing.Size(833, 329);
            this.dataGridInvestigators.StandardTab = true;
            this.dataGridInvestigators.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nom";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Prénom";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Disponible";
            this.Column3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Enquêtes en cours";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 32;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 32;
            // 
            // btnAddInvestigator
            // 
            this.btnAddInvestigator.Location = new System.Drawing.Point(364, 443);
            this.btnAddInvestigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddInvestigator.Name = "btnAddInvestigator";
            this.btnAddInvestigator.Size = new System.Drawing.Size(172, 34);
            this.btnAddInvestigator.TabIndex = 1;
            this.btnAddInvestigator.Text = "Ajouter un enquêteur";
            this.btnAddInvestigator.UseVisualStyleBackColor = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(912, 567);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "Form2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInvestigators)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridInvestigators;
        private System.Windows.Forms.Button btnAddInvestigator;
        private System.Windows.Forms.ComboBox comboBoxInvestigatorAvailibility;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.TextBox investigatorSearchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.TextBox investigatorSearchFirstName;
        private System.Windows.Forms.Button btnSearchInvestigator;
    }
}