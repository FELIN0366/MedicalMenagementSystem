namespace MedicalMenagementSystem
{
    partial class frmLoginDoctor
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
            this.LogInButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.welcomLabel = new System.Windows.Forms.Label();
            this.AccountLabel = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.AccountBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogInButton
            // 
            this.LogInButton.Font = new System.Drawing.Font("MS UI Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInButton.Location = new System.Drawing.Point(267, 489);
            this.LogInButton.Margin = new System.Windows.Forms.Padding(4);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(290, 95);
            this.LogInButton.TabIndex = 9;
            this.LogInButton.Text = "LOG IN";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(131, 318);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(201, 54);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "Password";
            // 
            // welcomLabel
            // 
            this.welcomLabel.AutoSize = true;
            this.welcomLabel.Font = new System.Drawing.Font("MV Boli", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomLabel.Location = new System.Drawing.Point(223, 69);
            this.welcomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomLabel.Name = "welcomLabel";
            this.welcomLabel.Size = new System.Drawing.Size(349, 68);
            this.welcomLabel.TabIndex = 7;
            this.welcomLabel.Text = "Doctor Login";
            // 
            // AccountLabel
            // 
            this.AccountLabel.AutoSize = true;
            this.AccountLabel.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountLabel.Location = new System.Drawing.Point(131, 176);
            this.AccountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(177, 54);
            this.AccountLabel.TabIndex = 8;
            this.AccountLabel.Text = "Account";
            // 
            // PasswordBox
            // 
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordBox.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.PasswordBox.Location = new System.Drawing.Point(123, 376);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(572, 54);
            this.PasswordBox.TabIndex = 5;
            // 
            // AccountBox
            // 
            this.AccountBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountBox.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.AccountBox.Location = new System.Drawing.Point(123, 234);
            this.AccountBox.Margin = new System.Windows.Forms.Padding(4);
            this.AccountBox.Name = "AccountBox";
            this.AccountBox.Size = new System.Drawing.Size(572, 54);
            this.AccountBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(689, 625);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmLoginDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 672);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.welcomLabel);
            this.Controls.Add(this.AccountLabel);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.AccountBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoginDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoginDoctor";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLoginDoctor_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLoginDoctor_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmLoginDoctor_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label welcomLabel;
        private System.Windows.Forms.Label AccountLabel;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox AccountBox;
        private System.Windows.Forms.Button button1;
    }
}