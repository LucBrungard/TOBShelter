
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddInvestigation = new System.Windows.Forms.Button();
            this.btnEditInvestigation = new System.Windows.Forms.Button();
            this.btnViewInvestigation = new System.Windows.Forms.Button();
            this.ckxOpenInvestigation = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddInvestigator = new System.Windows.Forms.Button();
            this.btnEditInvestigator = new System.Windows.Forms.Button();
            this.btnViewInvestigator = new System.Windows.Forms.Button();
            this.investigatorSearchFirstName = new System.Windows.Forms.TextBox();
            this.btnSearchInvestigator = new System.Windows.Forms.Button();
            this.investigatorSearchName = new System.Windows.Forms.TextBox();
            this.comboBoxInvestigatorAvailibility = new System.Windows.Forms.ComboBox();
            this.dataGridInvestigators = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInvestigators)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(688, 464);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.ckxOpenInvestigation);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(680, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enquêtes";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(215)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnId,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewImageColumn2,
            this.dataGridViewTextBoxColumn7});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.Location = new System.Drawing.Point(138, 72);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.RowTemplate.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(525, 325);
            this.dataGridView2.StandardTab = true;
            this.dataGridView2.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumnId
            // 
            this.dataGridViewTextBoxColumnId.HeaderText = "Identifiant";
            this.dataGridViewTextBoxColumnId.MinimumWidth = 6;
            this.dataGridViewTextBoxColumnId.Name = "dataGridViewTextBoxColumnId";
            this.dataGridViewTextBoxColumnId.ReadOnly = true;
            this.dataGridViewTextBoxColumnId.Width = 130;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Intitulé";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 130;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Délégué Enquêteur";
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Dernière modification";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 130;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.btnAddInvestigation);
            this.panel2.Controls.Add(this.btnEditInvestigation);
            this.panel2.Controls.Add(this.btnViewInvestigation);
            this.panel2.Location = new System.Drawing.Point(16, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 372);
            this.panel2.TabIndex = 17;
            // 
            // btnAddInvestigation
            // 
            this.btnAddInvestigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(239)))), ((int)(((byte)(236)))));
            this.btnAddInvestigation.BackgroundImage = global::TOBShelter.Properties.Resources.add;
            this.btnAddInvestigation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddInvestigation.Location = new System.Drawing.Point(18, 20);
            this.btnAddInvestigation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddInvestigation.Name = "btnAddInvestigation";
            this.btnAddInvestigation.Size = new System.Drawing.Size(66, 67);
            this.btnAddInvestigation.TabIndex = 1;
            this.btnAddInvestigation.UseVisualStyleBackColor = false;
            this.btnAddInvestigation.Click += new System.EventHandler(this.btnAddInvestigation_Click);
            // 
            // btnEditInvestigation
            // 
            this.btnEditInvestigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(239)))), ((int)(((byte)(236)))));
            this.btnEditInvestigation.BackgroundImage = global::TOBShelter.Properties.Resources.edit;
            this.btnEditInvestigation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditInvestigation.Location = new System.Drawing.Point(18, 286);
            this.btnEditInvestigation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditInvestigation.Name = "btnEditInvestigation";
            this.btnEditInvestigation.Size = new System.Drawing.Size(66, 67);
            this.btnEditInvestigation.TabIndex = 12;
            this.btnEditInvestigation.UseVisualStyleBackColor = false;
            this.btnEditInvestigation.Click += new System.EventHandler(this.btnEditInvestigation_Click);
            // 
            // btnViewInvestigation
            // 
            this.btnViewInvestigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(239)))), ((int)(((byte)(236)))));
            this.btnViewInvestigation.BackgroundImage = global::TOBShelter.Properties.Resources.details;
            this.btnViewInvestigation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewInvestigation.Location = new System.Drawing.Point(18, 153);
            this.btnViewInvestigation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewInvestigation.Name = "btnViewInvestigation";
            this.btnViewInvestigation.Size = new System.Drawing.Size(66, 67);
            this.btnViewInvestigation.TabIndex = 11;
            this.btnViewInvestigation.UseVisualStyleBackColor = false;
            this.btnViewInvestigation.Click += new System.EventHandler(this.btnViewInvestigation_Click);
            // 
            // ckxOpenInvestigation
            // 
            this.ckxOpenInvestigation.AutoSize = true;
            this.ckxOpenInvestigation.Location = new System.Drawing.Point(600, 32);
            this.ckxOpenInvestigation.Name = "ckxOpenInvestigation";
            this.ckxOpenInvestigation.Size = new System.Drawing.Size(64, 17);
            this.ckxOpenInvestigation.TabIndex = 16;
            this.ckxOpenInvestigation.Text = "Ouverte";
            this.ckxOpenInvestigation.UseVisualStyleBackColor = true;
            this.ckxOpenInvestigation.CheckedChanged += new System.EventHandler(this.ckxOpenInvestigation_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(258, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.button1.Location = new System.Drawing.Point(352, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Size = new System.Drawing.Size(15, 16);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 26);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.MinimumSize = new System.Drawing.Size(93, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 20);
            this.textBox2.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.investigatorSearchFirstName);
            this.tabPage2.Controls.Add(this.btnSearchInvestigator);
            this.tabPage2.Controls.Add(this.investigatorSearchName);
            this.tabPage2.Controls.Add(this.comboBoxInvestigatorAvailibility);
            this.tabPage2.Controls.Add(this.dataGridInvestigators);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(680, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Enquêteurs";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.btnAddInvestigator);
            this.panel1.Controls.Add(this.btnEditInvestigator);
            this.panel1.Controls.Add(this.btnViewInvestigator);
            this.panel1.Location = new System.Drawing.Point(16, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 372);
            this.panel1.TabIndex = 10;
            // 
            // btnAddInvestigator
            // 
            this.btnAddInvestigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(239)))), ((int)(((byte)(236)))));
            this.btnAddInvestigator.BackgroundImage = global::TOBShelter.Properties.Resources.add;
            this.btnAddInvestigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddInvestigator.Location = new System.Drawing.Point(18, 20);
            this.btnAddInvestigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddInvestigator.Name = "btnAddInvestigator";
            this.btnAddInvestigator.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnAddInvestigator.Size = new System.Drawing.Size(66, 67);
            this.btnAddInvestigator.TabIndex = 5;
            this.btnAddInvestigator.UseVisualStyleBackColor = false;
            this.btnAddInvestigator.Click += new System.EventHandler(this.btnAddInvestigator_Click);
            // 
            // btnEditInvestigator
            // 
            this.btnEditInvestigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(239)))), ((int)(((byte)(236)))));
            this.btnEditInvestigator.BackgroundImage = global::TOBShelter.Properties.Resources.edit;
            this.btnEditInvestigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditInvestigator.Location = new System.Drawing.Point(18, 286);
            this.btnEditInvestigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditInvestigator.Name = "btnEditInvestigator";
            this.btnEditInvestigator.Size = new System.Drawing.Size(66, 67);
            this.btnEditInvestigator.TabIndex = 7;
            this.btnEditInvestigator.UseVisualStyleBackColor = false;
            this.btnEditInvestigator.Click += new System.EventHandler(this.btnEditInvestigator_Click);
            // 
            // btnViewInvestigator
            // 
            this.btnViewInvestigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(239)))), ((int)(((byte)(236)))));
            this.btnViewInvestigator.BackgroundImage = global::TOBShelter.Properties.Resources.details;
            this.btnViewInvestigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewInvestigator.Location = new System.Drawing.Point(18, 153);
            this.btnViewInvestigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewInvestigator.Name = "btnViewInvestigator";
            this.btnViewInvestigator.Size = new System.Drawing.Size(66, 67);
            this.btnViewInvestigator.TabIndex = 6;
            this.btnViewInvestigator.UseVisualStyleBackColor = false;
            this.btnViewInvestigator.Click += new System.EventHandler(this.btnViewInvestigator_Click);
            // 
            // investigatorSearchFirstName
            // 
            this.investigatorSearchFirstName.Location = new System.Drawing.Point(258, 24);
            this.investigatorSearchFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.investigatorSearchFirstName.MinimumSize = new System.Drawing.Size(93, 22);
            this.investigatorSearchFirstName.Name = "investigatorSearchFirstName";
            this.investigatorSearchFirstName.Size = new System.Drawing.Size(95, 20);
            this.investigatorSearchFirstName.TabIndex = 2;
            // 
            // btnSearchInvestigator
            // 
            this.btnSearchInvestigator.BackColor = System.Drawing.Color.White;
            this.btnSearchInvestigator.BackgroundImage = global::TOBShelter.Properties.Resources.search;
            this.btnSearchInvestigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchInvestigator.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSearchInvestigator.Location = new System.Drawing.Point(354, 24);
            this.btnSearchInvestigator.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchInvestigator.Name = "btnSearchInvestigator";
            this.btnSearchInvestigator.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchInvestigator.Size = new System.Drawing.Size(20, 20);
            this.btnSearchInvestigator.TabIndex = 3;
            this.btnSearchInvestigator.UseVisualStyleBackColor = false;
            this.btnSearchInvestigator.Click += new System.EventHandler(this.btnSearchInvestigator_Click);
            // 
            // investigatorSearchName
            // 
            this.investigatorSearchName.Location = new System.Drawing.Point(136, 24);
            this.investigatorSearchName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.investigatorSearchName.MinimumSize = new System.Drawing.Size(93, 22);
            this.investigatorSearchName.Name = "investigatorSearchName";
            this.investigatorSearchName.Size = new System.Drawing.Size(114, 20);
            this.investigatorSearchName.TabIndex = 1;
            // 
            // comboBoxInvestigatorAvailibility
            // 
            this.comboBoxInvestigatorAvailibility.FormattingEnabled = true;
            this.comboBoxInvestigatorAvailibility.Items.AddRange(new object[] {
            "Tous",
            "Disponible",
            "Retraité"});
            this.comboBoxInvestigatorAvailibility.Location = new System.Drawing.Point(530, 24);
            this.comboBoxInvestigatorAvailibility.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(215)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridInvestigators.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridInvestigators.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridInvestigators.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridInvestigators.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridInvestigators.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridInvestigators.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInvestigators.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.ColumnId,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridInvestigators.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridInvestigators.Location = new System.Drawing.Point(136, 72);
            this.dataGridInvestigators.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridInvestigators.MultiSelect = false;
            this.dataGridInvestigators.Name = "dataGridInvestigators";
            this.dataGridInvestigators.ReadOnly = true;
            this.dataGridInvestigators.RowHeadersVisible = false;
            this.dataGridInvestigators.RowHeadersWidth = 51;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridInvestigators.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridInvestigators.RowTemplate.Height = 24;
            this.dataGridInvestigators.RowTemplate.ReadOnly = true;
            this.dataGridInvestigators.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridInvestigators.Size = new System.Drawing.Size(525, 324);
            this.dataGridInvestigators.StandardTab = true;
            this.dataGridInvestigators.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nom";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 118;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Prénom";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 118;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Disponible";
            this.Column3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 105;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Enquêtes en cours";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 129;
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox investigatorSearchFirstName;
        private System.Windows.Forms.Button btnSearchInvestigator;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox ckxOpenInvestigation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditInvestigator;
        private System.Windows.Forms.Button btnViewInvestigator;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddInvestigation;
        private System.Windows.Forms.Button btnEditInvestigation;
        private System.Windows.Forms.Button btnViewInvestigation;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}