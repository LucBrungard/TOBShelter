
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ckxOpenInvestigation = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button2 = new System.Windows.Forms.Button();
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
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(688, 464);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ckxOpenInvestigation);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(680, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enquêtes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ckxOpenInvestigation
            // 
            this.ckxOpenInvestigation.AutoSize = true;
            this.ckxOpenInvestigation.Location = new System.Drawing.Point(584, 32);
            this.ckxOpenInvestigation.Name = "ckxOpenInvestigation";
            this.ckxOpenInvestigation.Size = new System.Drawing.Size(64, 17);
            this.ckxOpenInvestigation.TabIndex = 16;
            this.ckxOpenInvestigation.Text = "Ouverte";
            this.ckxOpenInvestigation.UseVisualStyleBackColor = true;
            this.ckxOpenInvestigation.CheckedChanged += new System.EventHandler(this.ckxOpenInvestigation_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.MinimumSize = new System.Drawing.Size(93, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 20);
            this.textBox1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::TOBShelter.Properties.Resources.search;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(251, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(2);
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(35, 26);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.MinimumSize = new System.Drawing.Size(93, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 20);
            this.textBox2.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(28, 74);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(625, 267);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Identifiant";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Intitulé";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Délégué Enquêteur";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Date de dernière modification";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Width = 32;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "";
            this.dataGridViewButtonColumn2.MinimumWidth = 6;
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            this.dataGridViewButtonColumn2.Width = 32;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 362);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "Ajouter une enquête";
            this.button2.UseVisualStyleBackColor = true;
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
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(680, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Enquêteurs";
            // 
            // investigatorSearchFirstName
            // 
            this.investigatorSearchFirstName.Location = new System.Drawing.Point(154, 24);
            this.investigatorSearchFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.investigatorSearchFirstName.MinimumSize = new System.Drawing.Size(93, 22);
            this.investigatorSearchFirstName.Name = "investigatorSearchFirstName";
            this.investigatorSearchFirstName.Size = new System.Drawing.Size(93, 20);
            this.investigatorSearchFirstName.TabIndex = 9;
            // 
            // btnSearchInvestigator
            // 
            this.btnSearchInvestigator.BackgroundImage = global::TOBShelter.Properties.Resources.search;
            this.btnSearchInvestigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchInvestigator.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSearchInvestigator.Location = new System.Drawing.Point(248, 24);
            this.btnSearchInvestigator.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchInvestigator.Name = "btnSearchInvestigator";
            this.btnSearchInvestigator.Padding = new System.Windows.Forms.Padding(2);
            this.btnSearchInvestigator.Size = new System.Drawing.Size(24, 24);
            this.btnSearchInvestigator.TabIndex = 8;
            this.btnSearchInvestigator.UseVisualStyleBackColor = true;
            this.btnSearchInvestigator.Click += new System.EventHandler(this.btnSearchInvestigator_Click);
            // 
            // investigatorSearchName
            // 
            this.investigatorSearchName.Location = new System.Drawing.Point(32, 24);
            this.investigatorSearchName.Margin = new System.Windows.Forms.Padding(2);
            this.investigatorSearchName.MinimumSize = new System.Drawing.Size(93, 22);
            this.investigatorSearchName.Name = "investigatorSearchName";
            this.investigatorSearchName.Size = new System.Drawing.Size(112, 20);
            this.investigatorSearchName.TabIndex = 7;
            // 
            // comboBoxInvestigatorAvailibility
            // 
            this.comboBoxInvestigatorAvailibility.FormattingEnabled = true;
            this.comboBoxInvestigatorAvailibility.Items.AddRange(new object[] {
            "Tous",
            "Disponible",
            "Retraité"});
            this.comboBoxInvestigatorAvailibility.Location = new System.Drawing.Point(520, 24);
            this.comboBoxInvestigatorAvailibility.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxInvestigatorAvailibility.MaxLength = 32;
            this.comboBoxInvestigatorAvailibility.MinimumSize = new System.Drawing.Size(76, 0);
            this.comboBoxInvestigatorAvailibility.Name = "comboBoxInvestigatorAvailibility";
            this.comboBoxInvestigatorAvailibility.Size = new System.Drawing.Size(128, 21);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridInvestigators.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridInvestigators.Location = new System.Drawing.Point(25, 72);
            this.dataGridInvestigators.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridInvestigators.MultiSelect = false;
            this.dataGridInvestigators.Name = "dataGridInvestigators";
            this.dataGridInvestigators.ReadOnly = true;
            this.dataGridInvestigators.RowHeadersVisible = false;
            this.dataGridInvestigators.RowHeadersWidth = 51;
            this.dataGridInvestigators.RowTemplate.Height = 24;
            this.dataGridInvestigators.RowTemplate.ReadOnly = true;
            this.dataGridInvestigators.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridInvestigators.Size = new System.Drawing.Size(625, 267);
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
            this.btnAddInvestigator.Location = new System.Drawing.Point(273, 360);
            this.btnAddInvestigator.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddInvestigator.Name = "btnAddInvestigator";
            this.btnAddInvestigator.Size = new System.Drawing.Size(129, 28);
            this.btnAddInvestigator.TabIndex = 1;
            this.btnAddInvestigator.Text = "Ajouter un enquêteur";
            this.btnAddInvestigator.UseVisualStyleBackColor = true;
            this.btnAddInvestigator.Click += new System.EventHandler(this.btnAddInvestigator_Click);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox ckxOpenInvestigation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
    }
}