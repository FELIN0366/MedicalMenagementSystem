namespace MedicalMenagementSystem
{
    partial class MedicalRecordDetail
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.depLabel = new System.Windows.Forms.Label();
            this.docLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.resultTextbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doctor Name";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(358, 56);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(106, 35);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "timeLabel";
            // 
            // depLabel
            // 
            this.depLabel.AutoSize = true;
            this.depLabel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depLabel.Location = new System.Drawing.Point(358, 97);
            this.depLabel.Name = "depLabel";
            this.depLabel.Size = new System.Drawing.Size(98, 35);
            this.depLabel.TabIndex = 1;
            this.depLabel.Text = "depLabel";
            // 
            // docLabel
            // 
            this.docLabel.AutoSize = true;
            this.docLabel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docLabel.Location = new System.Drawing.Point(358, 141);
            this.docLabel.Name = "docLabel";
            this.docLabel.Size = new System.Drawing.Size(96, 35);
            this.docLabel.TabIndex = 2;
            this.docLabel.Text = "docLabel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(52, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Consultation Result";
            // 
            // resultTextbox
            // 
            this.resultTextbox.Location = new System.Drawing.Point(25, 257);
            this.resultTextbox.Multiline = true;
            this.resultTextbox.Name = "resultTextbox";
            this.resultTextbox.Size = new System.Drawing.Size(517, 122);
            this.resultTextbox.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateLabel);
            this.panel1.Controls.Add(this.timeLabel);
            this.panel1.Controls.Add(this.depLabel);
            this.panel1.Controls.Add(this.docLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(25, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 191);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(25, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(517, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(358, 14);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(103, 35);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "dateLabel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(96, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 35);
            this.label9.TabIndex = 0;
            this.label9.Text = "Date";
            // 
            // MedicalRecordDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultTextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedicalRecordDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicalRecordDetail";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MedicalRecordDetail_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MedicalRecordDetail_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MedicalRecordDetail_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label depLabel;
        private System.Windows.Forms.Label docLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox resultTextbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label dateLabel;
    }
}