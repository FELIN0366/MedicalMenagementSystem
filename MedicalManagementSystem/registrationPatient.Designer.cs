namespace MedicalMenagementSystem
{
    partial class registrationPatient
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
            this.registrationLabel = new System.Windows.Forms.Label();
            this.chooseSectionOfficeLabel = new System.Windows.Forms.Label();
            this.chooseDocterLabel = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.doctorTimeLabel = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.appointmentTimeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.configurationButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.timePeriodLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.caseNumberLabel = new System.Windows.Forms.Label();
            this.goBackButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.selectButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationLabel.Location = new System.Drawing.Point(56, 33);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(386, 46);
            this.registrationLabel.TabIndex = 0;
            this.registrationLabel.Text = "Registration Window";
            this.registrationLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // chooseSectionOfficeLabel
            // 
            this.chooseSectionOfficeLabel.AutoSize = true;
            this.chooseSectionOfficeLabel.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseSectionOfficeLabel.Location = new System.Drawing.Point(27, 21);
            this.chooseSectionOfficeLabel.Name = "chooseSectionOfficeLabel";
            this.chooseSectionOfficeLabel.Size = new System.Drawing.Size(229, 40);
            this.chooseSectionOfficeLabel.TabIndex = 1;
            this.chooseSectionOfficeLabel.Text = "Choose Department";
            // 
            // chooseDocterLabel
            // 
            this.chooseDocterLabel.AutoSize = true;
            this.chooseDocterLabel.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseDocterLabel.Location = new System.Drawing.Point(60, 85);
            this.chooseDocterLabel.Name = "chooseDocterLabel";
            this.chooseDocterLabel.Size = new System.Drawing.Size(172, 40);
            this.chooseDocterLabel.TabIndex = 1;
            this.chooseDocterLabel.Text = "Choose Doctor";
            // 
            // checkButton
            // 
            this.checkButton.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkButton.Location = new System.Drawing.Point(558, 47);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(145, 64);
            this.checkButton.TabIndex = 3;
            this.checkButton.Text = "Load";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // doctorTimeLabel
            // 
            this.doctorTimeLabel.AutoSize = true;
            this.doctorTimeLabel.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorTimeLabel.Location = new System.Drawing.Point(60, 14);
            this.doctorTimeLabel.Name = "doctorTimeLabel";
            this.doctorTimeLabel.Size = new System.Drawing.Size(213, 40);
            this.doctorTimeLabel.TabIndex = 4;
            this.doctorTimeLabel.Text = "Doctor\'s  Schedule";
            this.doctorTimeLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(39, 317);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersWidth = 62;
            this.dgv1.RowTemplate.Height = 30;
            this.dgv1.Size = new System.Drawing.Size(392, 247);
            this.dgv1.TabIndex = 5;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // appointmentTimeLabel
            // 
            this.appointmentTimeLabel.AutoSize = true;
            this.appointmentTimeLabel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentTimeLabel.Location = new System.Drawing.Point(28, 14);
            this.appointmentTimeLabel.Name = "appointmentTimeLabel";
            this.appointmentTimeLabel.Size = new System.Drawing.Size(287, 35);
            this.appointmentTimeLabel.TabIndex = 6;
            this.appointmentTimeLabel.Text = "Time  Of  Your  Appoinment";
            this.appointmentTimeLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateLabel.Location = new System.Drawing.Point(66, 121);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(68, 28);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "Date";
            this.dateLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // configurationButton
            // 
            this.configurationButton.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configurationButton.Location = new System.Drawing.Point(91, 271);
            this.configurationButton.Name = "configurationButton";
            this.configurationButton.Size = new System.Drawing.Size(142, 64);
            this.configurationButton.TabIndex = 3;
            this.configurationButton.Text = "OK";
            this.configurationButton.UseVisualStyleBackColor = true;
            this.configurationButton.Click += new System.EventHandler(this.configurationButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(301, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 47);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(301, 85);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(239, 47);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // timePeriodLabel
            // 
            this.timePeriodLabel.AutoSize = true;
            this.timePeriodLabel.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timePeriodLabel.Location = new System.Drawing.Point(66, 193);
            this.timePeriodLabel.Name = "timePeriodLabel";
            this.timePeriodLabel.Size = new System.Drawing.Size(166, 28);
            this.timePeriodLabel.TabIndex = 6;
            this.timePeriodLabel.Text = "Time Period";
            this.timePeriodLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(577, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "病历号:";
            // 
            // caseNumberLabel
            // 
            this.caseNumberLabel.AutoSize = true;
            this.caseNumberLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.caseNumberLabel.Location = new System.Drawing.Point(677, 45);
            this.caseNumberLabel.Name = "caseNumberLabel";
            this.caseNumberLabel.Size = new System.Drawing.Size(58, 24);
            this.caseNumberLabel.TabIndex = 8;
            this.caseNumberLabel.Text = "XXXX";
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.Firebrick;
            this.goBackButton.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.goBackButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.goBackButton.Location = new System.Drawing.Point(10, 314);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(109, 47);
            this.goBackButton.TabIndex = 9;
            this.goBackButton.Text = "Back";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.checkButton);
            this.panel1.Controls.Add(this.chooseSectionOfficeLabel);
            this.panel1.Controls.Add(this.chooseDocterLabel);
            this.panel1.Location = new System.Drawing.Point(39, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 158);
            this.panel1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.dateLabel);
            this.panel3.Controls.Add(this.timePeriodLabel);
            this.panel3.Controls.Add(this.appointmentTimeLabel);
            this.panel3.Controls.Add(this.configurationButton);
            this.panel3.Location = new System.Drawing.Point(445, 262);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(338, 372);
            this.panel3.TabIndex = 12;
            // 
            // selectButton
            // 
            this.selectButton.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectButton.Location = new System.Drawing.Point(125, 314);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(254, 47);
            this.selectButton.TabIndex = 3;
            this.selectButton.Text = "Choose";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameLabel.Location = new System.Drawing.Point(484, 45);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(82, 24);
            this.nameLabel.TabIndex = 13;
            this.nameLabel.Text = "张小三";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.goBackButton);
            this.panel2.Controls.Add(this.selectButton);
            this.panel2.Controls.Add(this.doctorTimeLabel);
            this.panel2.Location = new System.Drawing.Point(39, 262);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 372);
            this.panel2.TabIndex = 14;
            // 
            // registrationPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 672);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.caseNumberLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registrationPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registration";
            this.Load += new System.EventHandler(this.registration_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.registrationPatient_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.registrationPatient_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.registrationPatient_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.Label chooseSectionOfficeLabel;
        private System.Windows.Forms.Label chooseDocterLabel;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label doctorTimeLabel;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label appointmentTimeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button configurationButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label timePeriodLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label caseNumberLabel;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel panel2;
    }
}