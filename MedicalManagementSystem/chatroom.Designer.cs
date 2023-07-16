namespace MedicalMenagementSystem
{
    partial class chatroom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chatroom));
            this.sendButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.editTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.choseLabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chatTranscriptTxtBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Location = new System.Drawing.Point(647, 535);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(121, 43);
            this.sendButton.TabIndex = 26;
            this.sendButton.Text = "SEND";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(509, 535);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(116, 43);
            this.resetButton.TabIndex = 25;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // editTextBox
            // 
            this.editTextBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.editTextBox.Location = new System.Drawing.Point(286, 385);
            this.editTextBox.Multiline = true;
            this.editTextBox.Name = "editTextBox";
            this.editTextBox.Size = new System.Drawing.Size(482, 140);
            this.editTextBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "chat";
            // 
            // choseLabel
            // 
            this.choseLabel.AutoSize = true;
            this.choseLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choseLabel.Location = new System.Drawing.Point(39, 115);
            this.choseLabel.Name = "choseLabel";
            this.choseLabel.Size = new System.Drawing.Size(53, 21);
            this.choseLabel.TabIndex = 22;
            this.choseLabel.Text = "User";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(34, 139);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(230, 439);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 177;
            // 
            // chatTranscriptTxtBox
            // 
            this.chatTranscriptTxtBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatTranscriptTxtBox.Location = new System.Drawing.Point(286, 140);
            this.chatTranscriptTxtBox.Multiline = true;
            this.chatTranscriptTxtBox.Name = "chatTranscriptTxtBox";
            this.chatTranscriptTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.chatTranscriptTxtBox.Size = new System.Drawing.Size(482, 209);
            this.chatTranscriptTxtBox.TabIndex = 20;
            this.chatTranscriptTxtBox.TextChanged += new System.EventHandler(this.chatTranscriptTxtBox_TextChanged);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Firebrick;
            this.closeButton.Font = new System.Drawing.Font("Perpetua Titling MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeButton.Location = new System.Drawing.Point(753, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(52, 47);
            this.closeButton.TabIndex = 27;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 87);
            this.panel1.TabIndex = 28;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Perpetua", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(49, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chat Room";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 602);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 37);
            this.panel2.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "text";
            // 
            // chatroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 639);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.editTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.choseLabel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.chatTranscriptTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "chatroom";
            this.Text = "chatroom";
            this.Load += new System.EventHandler(this.chatroom_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chatroom_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chatroom_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chatroom_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox editTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label choseLabel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox chatTranscriptTxtBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}