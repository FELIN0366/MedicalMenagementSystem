namespace MedicalMenagementSystem
{
    partial class doctorVisitPatient
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
            this.resultTxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.nameContentLabel = new System.Windows.Forms.Label();
            this.caseNumberLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.doctorNameLabel = new System.Windows.Forms.Label();
            this.timePLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.finishButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultTxtbox
            // 
            this.resultTxtbox.Location = new System.Drawing.Point(32, 206);
            this.resultTxtbox.Multiline = true;
            this.resultTxtbox.Name = "resultTxtbox";
            this.resultTxtbox.Size = new System.Drawing.Size(479, 162);
            this.resultTxtbox.TabIndex = 0;
            this.resultTxtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.resultTxtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Result of the consultation";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(402, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nameContentLabel
            // 
            this.nameContentLabel.AutoSize = true;
            this.nameContentLabel.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameContentLabel.Location = new System.Drawing.Point(16, 19);
            this.nameContentLabel.Name = "nameContentLabel";
            this.nameContentLabel.Size = new System.Drawing.Size(54, 22);
            this.nameContentLabel.TabIndex = 3;
            this.nameContentLabel.Text = "姓名";
            // 
            // caseNumberLabel
            // 
            this.caseNumberLabel.AutoSize = true;
            this.caseNumberLabel.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.caseNumberLabel.Location = new System.Drawing.Point(16, 66);
            this.caseNumberLabel.Name = "caseNumberLabel";
            this.caseNumberLabel.Size = new System.Drawing.Size(76, 22);
            this.caseNumberLabel.TabIndex = 3;
            this.caseNumberLabel.Text = "病历号";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ageLabel.Location = new System.Drawing.Point(126, 66);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(54, 22);
            this.ageLabel.TabIndex = 3;
            this.ageLabel.Text = "年龄";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sexLabel.Location = new System.Drawing.Point(118, 19);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(54, 22);
            this.sexLabel.TabIndex = 3;
            this.sexLabel.Text = "性别";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.sexLabel);
            this.panel1.Controls.Add(this.nameContentLabel);
            this.panel1.Controls.Add(this.ageLabel);
            this.panel1.Controls.Add(this.caseNumberLabel);
            this.panel1.Location = new System.Drawing.Point(32, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 108);
            this.panel1.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 35);
            this.label7.TabIndex = 3;
            this.label7.Text = "Patient\'s info";
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(32, 386);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(113, 37);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.departmentLabel);
            this.panel2.Controls.Add(this.doctorNameLabel);
            this.panel2.Controls.Add(this.timePLabel);
            this.panel2.Controls.Add(this.dateLabel);
            this.panel2.Location = new System.Drawing.Point(240, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 108);
            this.panel2.TabIndex = 6;
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.departmentLabel.Location = new System.Drawing.Point(24, 19);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(76, 22);
            this.departmentLabel.TabIndex = 3;
            this.departmentLabel.Text = "科室名";
            // 
            // doctorNameLabel
            // 
            this.doctorNameLabel.AutoSize = true;
            this.doctorNameLabel.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.doctorNameLabel.Location = new System.Drawing.Point(158, 19);
            this.doctorNameLabel.Name = "doctorNameLabel";
            this.doctorNameLabel.Size = new System.Drawing.Size(76, 22);
            this.doctorNameLabel.TabIndex = 3;
            this.doctorNameLabel.Text = "医生名";
            // 
            // timePLabel
            // 
            this.timePLabel.AutoSize = true;
            this.timePLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePLabel.Location = new System.Drawing.Point(143, 65);
            this.timePLabel.Name = "timePLabel";
            this.timePLabel.Size = new System.Drawing.Size(109, 25);
            this.timePLabel.TabIndex = 0;
            this.timePLabel.Text = "00:00-00:00";
            this.timePLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(23, 65);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(108, 25);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "0000/00/00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Appointment Detials";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // finishButton
            // 
            this.finishButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishButton.Location = new System.Drawing.Point(151, 386);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(245, 37);
            this.finishButton.TabIndex = 7;
            this.finishButton.Text = "Finsh The Consultation";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // doctorVisitPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 435);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.resultTxtbox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "doctorVisitPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "doctorVisitPatient";
            this.Load += new System.EventHandler(this.doctorVisitPatient_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.doctorVisitPatient_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.doctorVisitPatient_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.doctorVisitPatient_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultTxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label nameContentLabel;
        private System.Windows.Forms.Label caseNumberLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timePLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.Label doctorNameLabel;
    }
}