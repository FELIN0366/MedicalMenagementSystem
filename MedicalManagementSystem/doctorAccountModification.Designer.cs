namespace MedicalMenagementSystem
{
    partial class doctorAccountModification
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
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nameContentLabel = new System.Windows.Forms.Label();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.infoSaveButton = new System.Windows.Forms.Button();
            this.infoEditButton = new System.Windows.Forms.Button();
            this.enTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.goBackButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(20, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(239, 39);
            this.button3.TabIndex = 14;
            this.button3.Text = "LOAD";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(489, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 35);
            this.label9.TabIndex = 15;
            this.label9.Text = "Change Informations";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.nameContentLabel);
            this.panel3.Controls.Add(this.departmentComboBox);
            this.panel3.Controls.Add(this.infoSaveButton);
            this.panel3.Controls.Add(this.infoEditButton);
            this.panel3.Controls.Add(this.enTextbox);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.nameLabel);
            this.panel3.Location = new System.Drawing.Point(487, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(282, 412);
            this.panel3.TabIndex = 13;
            // 
            // nameContentLabel
            // 
            this.nameContentLabel.AutoSize = true;
            this.nameContentLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameContentLabel.Location = new System.Drawing.Point(147, 95);
            this.nameContentLabel.Name = "nameContentLabel";
            this.nameContentLabel.Size = new System.Drawing.Size(58, 24);
            this.nameContentLabel.TabIndex = 8;
            this.nameContentLabel.Text = "姓名";
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(20, 275);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(239, 32);
            this.departmentComboBox.TabIndex = 7;
            this.departmentComboBox.SelectedIndexChanged += new System.EventHandler(this.departmentComboBox_SelectedIndexChanged);
            // 
            // infoSaveButton
            // 
            this.infoSaveButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.infoSaveButton.Location = new System.Drawing.Point(151, 343);
            this.infoSaveButton.Name = "infoSaveButton";
            this.infoSaveButton.Size = new System.Drawing.Size(110, 51);
            this.infoSaveButton.TabIndex = 6;
            this.infoSaveButton.Text = "Save";
            this.infoSaveButton.UseVisualStyleBackColor = true;
            this.infoSaveButton.Click += new System.EventHandler(this.infoSaveButton_Click);
            // 
            // infoEditButton
            // 
            this.infoEditButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.infoEditButton.Location = new System.Drawing.Point(20, 343);
            this.infoEditButton.Name = "infoEditButton";
            this.infoEditButton.Size = new System.Drawing.Size(110, 49);
            this.infoEditButton.TabIndex = 6;
            this.infoEditButton.Text = "Edit";
            this.infoEditButton.UseVisualStyleBackColor = true;
            this.infoEditButton.Click += new System.EventHandler(this.infoEditButton_Click);
            // 
            // enTextbox
            // 
            this.enTextbox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.enTextbox.Location = new System.Drawing.Point(20, 184);
            this.enTextbox.Name = "enTextbox";
            this.enTextbox.Size = new System.Drawing.Size(239, 35);
            this.enTextbox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Employee Number";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(24, 95);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(64, 28);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(18, 467);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 84);
            this.panel2.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(337, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(303, 55);
            this.button2.TabIndex = 0;
            this.button2.Text = "Delete Account";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(19, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(303, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "Doctor Account Management";
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.DimGray;
            this.goBackButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.goBackButton.Location = new System.Drawing.Point(684, 467);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(93, 84);
            this.goBackButton.TabIndex = 11;
            this.goBackButton.Text = "Close";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.dgv1);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.loadButton);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(18, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 412);
            this.panel1.TabIndex = 9;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(19, 75);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersWidth = 62;
            this.dgv1.RowTemplate.Height = 30;
            this.dgv1.Size = new System.Drawing.Size(411, 232);
            this.dgv1.TabIndex = 4;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveButton.Location = new System.Drawing.Point(325, 343);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(110, 49);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.editButton.Location = new System.Drawing.Point(209, 343);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(110, 49);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loadButton.Location = new System.Drawing.Point(19, 23);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(411, 36);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Load Doctors\' Accounts";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(19, 352);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(184, 35);
            this.passwordTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Change Password";
            // 
            // doctorAccountModification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 563);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "doctorAccountModification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "docotrAccountManagement";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.doctorAccountModification_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.doctorAccountModification_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.doctorAccountModification_MouseUp);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button infoSaveButton;
        private System.Windows.Forms.Button infoEditButton;
        private System.Windows.Forms.TextBox enTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Label nameContentLabel;
    }
}