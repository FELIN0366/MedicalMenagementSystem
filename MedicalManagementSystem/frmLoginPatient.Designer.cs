namespace MedicalMenagementSystem
{
    partial class frmLoginPatient
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AccountBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.AccountLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LogInButton = new System.Windows.Forms.Button();
            this.welcomLabel = new System.Windows.Forms.Label();
            this.CreateAccountButton = new System.Windows.Forms.Button();
            this.explainationLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.faceRecognitionLogin_button = new System.Windows.Forms.Button();
            this.cameraStop_button = new System.Windows.Forms.Button();
            this.cameraStart_button = new System.Windows.Forms.Button();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.changeCamera_button = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // AccountBox
            // 
            this.AccountBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountBox.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.AccountBox.Location = new System.Drawing.Point(123, 177);
            this.AccountBox.Margin = new System.Windows.Forms.Padding(4);
            this.AccountBox.Name = "AccountBox";
            this.AccountBox.Size = new System.Drawing.Size(590, 54);
            this.AccountBox.TabIndex = 0;
            this.AccountBox.TextChanged += new System.EventHandler(this.AccountBox_TextChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordBox.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.PasswordBox.Location = new System.Drawing.Point(39, 64);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PasswordBox.Size = new System.Drawing.Size(590, 54);
            this.PasswordBox.TabIndex = 1;
            // 
            // AccountLabel
            // 
            this.AccountLabel.AutoSize = true;
            this.AccountLabel.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountLabel.Location = new System.Drawing.Point(131, 119);
            this.AccountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(177, 54);
            this.AccountLabel.TabIndex = 2;
            this.AccountLabel.Text = "Account";
            this.AccountLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(47, 6);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(201, 54);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // LogInButton
            // 
            this.LogInButton.Font = new System.Drawing.Font("MS UI Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInButton.Location = new System.Drawing.Point(231, 145);
            this.LogInButton.Margin = new System.Windows.Forms.Padding(4);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(398, 95);
            this.LogInButton.TabIndex = 3;
            this.LogInButton.Text = "LOG IN";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // welcomLabel
            // 
            this.welcomLabel.AutoSize = true;
            this.welcomLabel.Font = new System.Drawing.Font("MV Boli", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomLabel.Location = new System.Drawing.Point(40, 38);
            this.welcomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomLabel.Name = "welcomLabel";
            this.welcomLabel.Size = new System.Drawing.Size(715, 68);
            this.welcomLabel.TabIndex = 2;
            this.welcomLabel.Text = "Welcom to medical system!";
            this.welcomLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountButton.Location = new System.Drawing.Point(382, 579);
            this.CreateAccountButton.Margin = new System.Windows.Forms.Padding(4);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(268, 51);
            this.CreateAccountButton.TabIndex = 3;
            this.CreateAccountButton.Text = "create account";
            this.CreateAccountButton.UseVisualStyleBackColor = true;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // explainationLabel
            // 
            this.explainationLabel.AutoSize = true;
            this.explainationLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explainationLabel.Location = new System.Drawing.Point(83, 590);
            this.explainationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.explainationLabel.Name = "explainationLabel";
            this.explainationLabel.Size = new System.Drawing.Size(296, 32);
            this.explainationLabel.TabIndex = 2;
            this.explainationLabel.Text = "Do not have an account?";
            this.explainationLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Sitka Banner", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(39, 145);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(185, 94);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(660, 595);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(80, 249);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(675, 307);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.LogInButton);
            this.tabPage1.Controls.Add(this.PasswordBox);
            this.tabPage1.Controls.Add(this.clearButton);
            this.tabPage1.Controls.Add(this.PasswordLabel);
            this.tabPage1.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage1.Size = new System.Drawing.Size(667, 259);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "   Password Login   ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.changeCamera_button);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.videoSourcePlayer1);
            this.tabPage2.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(667, 259);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "   Face Recognition Login   ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.faceRecognitionLogin_button);
            this.panel1.Controls.Add(this.cameraStop_button);
            this.panel1.Controls.Add(this.cameraStart_button);
            this.panel1.Location = new System.Drawing.Point(457, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 172);
            this.panel1.TabIndex = 1;
            // 
            // faceRecognitionLogin_button
            // 
            this.faceRecognitionLogin_button.BackColor = System.Drawing.Color.Orange;
            this.faceRecognitionLogin_button.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faceRecognitionLogin_button.ForeColor = System.Drawing.Color.Black;
            this.faceRecognitionLogin_button.Location = new System.Drawing.Point(17, 115);
            this.faceRecognitionLogin_button.Name = "faceRecognitionLogin_button";
            this.faceRecognitionLogin_button.Size = new System.Drawing.Size(159, 45);
            this.faceRecognitionLogin_button.TabIndex = 7;
            this.faceRecognitionLogin_button.Text = "LOGIN";
            this.faceRecognitionLogin_button.UseVisualStyleBackColor = false;
            this.faceRecognitionLogin_button.Click += new System.EventHandler(this.faceRecognitionLogin_button_Click);
            // 
            // cameraStop_button
            // 
            this.cameraStop_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cameraStop_button.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cameraStop_button.Location = new System.Drawing.Point(17, 64);
            this.cameraStop_button.Name = "cameraStop_button";
            this.cameraStop_button.Size = new System.Drawing.Size(159, 45);
            this.cameraStop_button.TabIndex = 7;
            this.cameraStop_button.Text = "STOP";
            this.cameraStop_button.UseVisualStyleBackColor = false;
            this.cameraStop_button.Click += new System.EventHandler(this.cameraStop_button_Click);
            // 
            // cameraStart_button
            // 
            this.cameraStart_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cameraStart_button.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cameraStart_button.Location = new System.Drawing.Point(17, 13);
            this.cameraStart_button.Name = "cameraStart_button";
            this.cameraStart_button.Size = new System.Drawing.Size(159, 45);
            this.cameraStart_button.TabIndex = 0;
            this.cameraStart_button.Text = "START";
            this.cameraStart_button.UseVisualStyleBackColor = false;
            this.cameraStart_button.Click += new System.EventHandler(this.cameraStart_button_Click);
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.BackColor = System.Drawing.Color.YellowGreen;
            this.videoSourcePlayer1.Location = new System.Drawing.Point(19, 17);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(416, 225);
            this.videoSourcePlayer1.TabIndex = 0;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // changeCamera_button
            // 
            this.changeCamera_button.BackColor = System.Drawing.Color.Firebrick;
            this.changeCamera_button.Font = new System.Drawing.Font("Sitka Text Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeCamera_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeCamera_button.Location = new System.Drawing.Point(457, 17);
            this.changeCamera_button.Name = "changeCamera_button";
            this.changeCamera_button.Size = new System.Drawing.Size(190, 45);
            this.changeCamera_button.TabIndex = 8;
            this.changeCamera_button.Text = "Change Camera";
            this.changeCamera_button.UseVisualStyleBackColor = false;
            this.changeCamera_button.Click += new System.EventHandler(this.changeCamera_button_Click);
            // 
            // frmLoginPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 672);
            this.Controls.Add(this.AccountBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CreateAccountButton);
            this.Controls.Add(this.AccountLabel);
            this.Controls.Add(this.explainationLabel);
            this.Controls.Add(this.welcomLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLoginPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLoginPatient_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLoginPatient_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmLoginPatient_MouseUp);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox AccountBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label AccountLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Label welcomLabel;
        private System.Windows.Forms.Button CreateAccountButton;
        private System.Windows.Forms.Label explainationLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button faceRecognitionLogin_button;
        private System.Windows.Forms.Button cameraStop_button;
        private System.Windows.Forms.Button cameraStart_button;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.Button changeCamera_button;
    }
}

