namespace MedicalMenagementSystem
{
    partial class faceRecognitionRegistration
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
            this.cameraStop_button = new System.Windows.Forms.Button();
            this.changeCamera_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cameraStart_button = new System.Windows.Forms.Button();
            this.faceRecognitionLogin_button = new System.Windows.Forms.Button();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.xbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deviceNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cameraStop_button
            // 
            this.cameraStop_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cameraStop_button.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cameraStop_button.Location = new System.Drawing.Point(15, 69);
            this.cameraStop_button.Name = "cameraStop_button";
            this.cameraStop_button.Size = new System.Drawing.Size(159, 45);
            this.cameraStop_button.TabIndex = 7;
            this.cameraStop_button.Text = "STOP";
            this.cameraStop_button.UseVisualStyleBackColor = false;
            this.cameraStop_button.Click += new System.EventHandler(this.cameraStop_button_Click);
            // 
            // changeCamera_button
            // 
            this.changeCamera_button.BackColor = System.Drawing.Color.Firebrick;
            this.changeCamera_button.Font = new System.Drawing.Font("Sitka Text Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeCamera_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeCamera_button.Location = new System.Drawing.Point(491, 9);
            this.changeCamera_button.Name = "changeCamera_button";
            this.changeCamera_button.Size = new System.Drawing.Size(190, 45);
            this.changeCamera_button.TabIndex = 14;
            this.changeCamera_button.Text = "Change Camera";
            this.changeCamera_button.UseVisualStyleBackColor = false;
            this.changeCamera_button.Click += new System.EventHandler(this.changeCamera_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.cameraStop_button);
            this.panel1.Controls.Add(this.cameraStart_button);
            this.panel1.Location = new System.Drawing.Point(490, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 128);
            this.panel1.TabIndex = 13;
            // 
            // cameraStart_button
            // 
            this.cameraStart_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cameraStart_button.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cameraStart_button.Location = new System.Drawing.Point(15, 13);
            this.cameraStart_button.Name = "cameraStart_button";
            this.cameraStart_button.Size = new System.Drawing.Size(159, 45);
            this.cameraStart_button.TabIndex = 0;
            this.cameraStart_button.Text = "START";
            this.cameraStart_button.UseVisualStyleBackColor = false;
            this.cameraStart_button.Click += new System.EventHandler(this.cameraStart_button_Click);
            // 
            // faceRecognitionLogin_button
            // 
            this.faceRecognitionLogin_button.BackColor = System.Drawing.Color.Orange;
            this.faceRecognitionLogin_button.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faceRecognitionLogin_button.ForeColor = System.Drawing.Color.Black;
            this.faceRecognitionLogin_button.Location = new System.Drawing.Point(490, 314);
            this.faceRecognitionLogin_button.Name = "faceRecognitionLogin_button";
            this.faceRecognitionLogin_button.Size = new System.Drawing.Size(190, 100);
            this.faceRecognitionLogin_button.TabIndex = 7;
            this.faceRecognitionLogin_button.Text = "REGISTRATION";
            this.faceRecognitionLogin_button.UseVisualStyleBackColor = false;
            this.faceRecognitionLogin_button.Click += new System.EventHandler(this.faceRecognitionLogin_button_Click);
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.BackColor = System.Drawing.Color.YellowGreen;
            this.videoSourcePlayer1.Location = new System.Drawing.Point(22, 172);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(416, 225);
            this.videoSourcePlayer1.TabIndex = 12;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // xbutton
            // 
            this.xbutton.BackColor = System.Drawing.Color.Firebrick;
            this.xbutton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.xbutton.Location = new System.Drawing.Point(644, 12);
            this.xbutton.Name = "xbutton";
            this.xbutton.Size = new System.Drawing.Size(38, 38);
            this.xbutton.TabIndex = 15;
            this.xbutton.Text = "X";
            this.xbutton.UseVisualStyleBackColor = false;
            this.xbutton.Click += new System.EventHandler(this.xbutton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.deviceNameLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.changeCamera_button);
            this.panel2.Location = new System.Drawing.Point(-1, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(695, 61);
            this.panel2.TabIndex = 16;
            // 
            // deviceNameLabel
            // 
            this.deviceNameLabel.AutoSize = true;
            this.deviceNameLabel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceNameLabel.Location = new System.Drawing.Point(267, 14);
            this.deviceNameLabel.Name = "deviceNameLabel";
            this.deviceNameLabel.Size = new System.Drawing.Size(134, 35);
            this.deviceNameLabel.TabIndex = 16;
            this.deviceNameLabel.Text = "Device Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 35);
            this.label1.TabIndex = 15;
            this.label1.Text = "The Camera To Be Used:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Location = new System.Drawing.Point(462, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 306);
            this.panel3.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Location = new System.Drawing.Point(468, 289);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(226, 10);
            this.panel4.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(571, 40);
            this.label2.TabIndex = 19;
            this.label2.Text = "<<< Face Recognition Registration >>>";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Location = new System.Drawing.Point(-1, 430);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(695, 23);
            this.panel5.TabIndex = 20;
            // 
            // faceRecognitionRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(694, 451);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.xbutton);
            this.Controls.Add(this.faceRecognitionLogin_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "faceRecognitionRegistration";
            this.Text = "faceRecognitionRegistration";
            this.Load += new System.EventHandler(this.faceRecognitionRegistration_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.faceRecognitionRegistration_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.faceRecognitionRegistration_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.faceRecognitionRegistration_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cameraStop_button;
        private System.Windows.Forms.Button changeCamera_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cameraStart_button;
        private System.Windows.Forms.Button faceRecognitionLogin_button;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.Button xbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label deviceNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
    }
}