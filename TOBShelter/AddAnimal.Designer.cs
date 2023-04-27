
namespace TOBShelter
{
    partial class AddAnimal
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
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbOwner = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBreed = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSexe = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(383, 235);
            this.btnAddAnimal.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(100, 28);
            this.btnAddAnimal.TabIndex = 8;
            this.btnAddAnimal.Text = "Ajouter";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtWeight);
            this.groupBox1.Controls.Add(this.cmbType);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbOwner);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbBreed);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbSexe);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudAge);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(832, 213);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animal";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(327, 108);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(180, 22);
            this.txtWeight.TabIndex = 5;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(607, 39);
            this.cmbType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(180, 24);
            this.cmbType.TabIndex = 3;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(603, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Type";
            // 
            // cmbOwner
            // 
            this.cmbOwner.FormattingEnabled = true;
            this.cmbOwner.Location = new System.Drawing.Point(47, 175);
            this.cmbOwner.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOwner.Name = "cmbOwner";
            this.cmbOwner.Size = new System.Drawing.Size(180, 24);
            this.cmbOwner.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Proprietaire";
            // 
            // cmbBreed
            // 
            this.cmbBreed.FormattingEnabled = true;
            this.cmbBreed.Location = new System.Drawing.Point(607, 107);
            this.cmbBreed.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBreed.Name = "cmbBreed";
            this.cmbBreed.Size = new System.Drawing.Size(180, 24);
            this.cmbBreed.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(603, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Race";
            // 
            // cmbSexe
            // 
            this.cmbSexe.FormattingEnabled = true;
            this.cmbSexe.Location = new System.Drawing.Point(327, 39);
            this.cmbSexe.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSexe.Name = "cmbSexe";
            this.cmbSexe.Size = new System.Drawing.Size(180, 24);
            this.cmbSexe.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sexe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Poids (en gramme)";
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(47, 107);
            this.nudAge.Margin = new System.Windows.Forms.Padding(4);
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(181, 22);
            this.nudAge.TabIndex = 4;
            this.nudAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Âge (en mois)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(47, 39);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 22);
            this.txtName.TabIndex = 1;
            // 
            // AddAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 273);
            this.Controls.Add(this.btnAddAnimal);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddAnimal";
            this.Text = "AddAnimal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.ComboBox cmbOwner;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBreed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSexe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtWeight;
    }
}