namespace Akademinė_sistema
{
    partial class AdminWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminWindow));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studentsButton = new System.Windows.Forms.Button();
            this.professorsButton = new System.Windows.Forms.Button();
            this.groupsButton = new System.Windows.Forms.Button();
            this.subjectsButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.logoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(389, 109);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(641, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(283, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "---------------------------------------------------------------------------------" +
    "-----------";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(283, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "---------------------------------------------------------------------------------" +
    "-----------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(283, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "---------------------------------------------------------------------------------" +
    "-----------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(495, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "ADMINISTRATORIAUS VALDYMO PANELĖ";
            // 
            // studentsButton
            // 
            this.studentsButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.studentsButton.Location = new System.Drawing.Point(42, 161);
            this.studentsButton.Name = "studentsButton";
            this.studentsButton.Size = new System.Drawing.Size(184, 23);
            this.studentsButton.TabIndex = 21;
            this.studentsButton.Text = "STUDENTAI";
            this.studentsButton.UseVisualStyleBackColor = true;
            this.studentsButton.Click += new System.EventHandler(this.studentsButton_Click);
            // 
            // professorsButton
            // 
            this.professorsButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.professorsButton.Location = new System.Drawing.Point(262, 161);
            this.professorsButton.Name = "professorsButton";
            this.professorsButton.Size = new System.Drawing.Size(184, 23);
            this.professorsButton.TabIndex = 22;
            this.professorsButton.Text = "DĖSTYTOJAI";
            this.professorsButton.UseVisualStyleBackColor = true;
            this.professorsButton.Click += new System.EventHandler(this.professorsButton_Click);
            // 
            // groupsButton
            // 
            this.groupsButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupsButton.Location = new System.Drawing.Point(476, 161);
            this.groupsButton.Name = "groupsButton";
            this.groupsButton.Size = new System.Drawing.Size(184, 23);
            this.groupsButton.TabIndex = 23;
            this.groupsButton.Text = "GRUPĖS";
            this.groupsButton.UseVisualStyleBackColor = true;
            this.groupsButton.Click += new System.EventHandler(this.groupsButton_Click);
            // 
            // subjectsButton
            // 
            this.subjectsButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.subjectsButton.Location = new System.Drawing.Point(698, 161);
            this.subjectsButton.Name = "subjectsButton";
            this.subjectsButton.Size = new System.Drawing.Size(184, 23);
            this.subjectsButton.TabIndex = 24;
            this.subjectsButton.Text = "DĖSTOMI DALYKAI";
            this.subjectsButton.UseVisualStyleBackColor = true;
            this.subjectsButton.Click += new System.EventHandler(this.subjectsButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(442, 202);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(440, 434);
            this.flowLayoutPanel2.TabIndex = 25;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(42, 305);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(253, 300);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // logoutButton
            // 
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.logoutButton.Location = new System.Drawing.Point(795, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(131, 23);
            this.logoutButton.TabIndex = 27;
            this.logoutButton.Text = "ATSIJUNGTI";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(938, 648);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.studentsButton);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.subjectsButton);
            this.Controls.Add(this.groupsButton);
            this.Controls.Add(this.professorsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AdminWindow";
            this.Text = "AdminWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button studentsButton;
        private System.Windows.Forms.Button professorsButton;
        private System.Windows.Forms.Button groupsButton;
        private System.Windows.Forms.Button subjectsButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button logoutButton;
    }
}