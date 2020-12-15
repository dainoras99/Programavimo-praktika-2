namespace Akademinė_sistema
{
    partial class ProfessorWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfessorWindow));
            this.logoutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.subjectsBox = new System.Windows.Forms.ComboBox();
            this.groupsBox = new System.Windows.Forms.ComboBox();
            this.studentsBox = new System.Windows.Forms.ComboBox();
            this.subjectsLabel = new System.Windows.Forms.Label();
            this.groupsLabel = new System.Windows.Forms.Label();
            this.studentsLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.gradeBox = new System.Windows.Forms.ComboBox();
            this.markLabel = new System.Windows.Forms.Label();
            this.oldMarkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.logoutButton.Location = new System.Drawing.Point(795, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(131, 23);
            this.logoutButton.TabIndex = 33;
            this.logoutButton.Text = "ATSIJUNGTI";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(577, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "DĖSTYTOJO VALDYMO PANELĖ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(641, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(283, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "---------------------------------------------------------------------------------" +
    "-----------";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(283, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "---------------------------------------------------------------------------------" +
    "-----------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(283, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "---------------------------------------------------------------------------------" +
    "-----------";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(389, 109);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // subjectsBox
            // 
            this.subjectsBox.FormattingEnabled = true;
            this.subjectsBox.Location = new System.Drawing.Point(309, 240);
            this.subjectsBox.Name = "subjectsBox";
            this.subjectsBox.Size = new System.Drawing.Size(254, 21);
            this.subjectsBox.TabIndex = 55;
            this.subjectsBox.SelectedIndexChanged += new System.EventHandler(this.subjectsBox_SelectedIndexChanged);
            // 
            // groupsBox
            // 
            this.groupsBox.FormattingEnabled = true;
            this.groupsBox.Location = new System.Drawing.Point(309, 338);
            this.groupsBox.Name = "groupsBox";
            this.groupsBox.Size = new System.Drawing.Size(121, 21);
            this.groupsBox.TabIndex = 56;
            this.groupsBox.Visible = false;
            this.groupsBox.SelectedIndexChanged += new System.EventHandler(this.groupsBox_SelectedIndexChanged);
            // 
            // studentsBox
            // 
            this.studentsBox.FormattingEnabled = true;
            this.studentsBox.Location = new System.Drawing.Point(309, 447);
            this.studentsBox.Name = "studentsBox";
            this.studentsBox.Size = new System.Drawing.Size(254, 21);
            this.studentsBox.TabIndex = 57;
            this.studentsBox.Visible = false;
            this.studentsBox.SelectedIndexChanged += new System.EventHandler(this.studentsBox_SelectedIndexChanged);
            // 
            // subjectsLabel
            // 
            this.subjectsLabel.AutoSize = true;
            this.subjectsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectsLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.subjectsLabel.Location = new System.Drawing.Point(12, 243);
            this.subjectsLabel.Name = "subjectsLabel";
            this.subjectsLabel.Size = new System.Drawing.Size(291, 16);
            this.subjectsLabel.TabIndex = 58;
            this.subjectsLabel.Text = "PASIRINKITE SAVO DĖSTOMĄ DALYKĄ:";
            // 
            // groupsLabel
            // 
            this.groupsLabel.AutoSize = true;
            this.groupsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupsLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupsLabel.Location = new System.Drawing.Point(52, 340);
            this.groupsLabel.Name = "groupsLabel";
            this.groupsLabel.Size = new System.Drawing.Size(251, 16);
            this.groupsLabel.TabIndex = 59;
            this.groupsLabel.Text = "PASIRINKITE STUDENTŲ GRUPĘ:";
            this.groupsLabel.Visible = false;
            // 
            // studentsLabel
            // 
            this.studentsLabel.AutoSize = true;
            this.studentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.studentsLabel.Location = new System.Drawing.Point(20, 450);
            this.studentsLabel.Name = "studentsLabel";
            this.studentsLabel.Size = new System.Drawing.Size(283, 16);
            this.studentsLabel.TabIndex = 60;
            this.studentsLabel.Text = "PASIRINKITE STUDENTĄ VERTINIMUI:";
            this.studentsLabel.Visible = false;
            // 
            // userLabel
            // 
            this.userLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.userLabel.Location = new System.Drawing.Point(466, 13);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(323, 22);
            this.userLabel.TabIndex = 62;
            this.userLabel.Text = "Esate prisijungęs: ";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(714, 410);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 64;
            this.okButton.Text = "VERTINTI";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Visible = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // gradeBox
            // 
            this.gradeBox.FormattingEnabled = true;
            this.gradeBox.Items.AddRange(new object[] {
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.gradeBox.Location = new System.Drawing.Point(738, 361);
            this.gradeBox.Name = "gradeBox";
            this.gradeBox.Size = new System.Drawing.Size(121, 21);
            this.gradeBox.TabIndex = 65;
            this.gradeBox.Visible = false;
            // 
            // markLabel
            // 
            this.markLabel.AutoSize = true;
            this.markLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.markLabel.Location = new System.Drawing.Point(657, 361);
            this.markLabel.Name = "markLabel";
            this.markLabel.Size = new System.Drawing.Size(75, 16);
            this.markLabel.TabIndex = 66;
            this.markLabel.Text = "Pažymys:";
            this.markLabel.Visible = false;
            // 
            // oldMarkLabel
            // 
            this.oldMarkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldMarkLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.oldMarkLabel.Location = new System.Drawing.Point(668, 309);
            this.oldMarkLabel.Name = "oldMarkLabel";
            this.oldMarkLabel.Size = new System.Drawing.Size(265, 52);
            this.oldMarkLabel.TabIndex = 70;
            this.oldMarkLabel.Text = "ĮVERTINKITE STUDENTĄ";
            this.oldMarkLabel.Visible = false;
            // 
            // ProfessorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(938, 648);
            this.Controls.Add(this.oldMarkLabel);
            this.Controls.Add(this.markLabel);
            this.Controls.Add(this.gradeBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.studentsLabel);
            this.Controls.Add(this.groupsLabel);
            this.Controls.Add(this.subjectsLabel);
            this.Controls.Add(this.studentsBox);
            this.Controls.Add(this.groupsBox);
            this.Controls.Add(this.subjectsBox);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ProfessorWindow";
            this.Text = "ProfessorWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox subjectsBox;
        private System.Windows.Forms.ComboBox groupsBox;
        private System.Windows.Forms.ComboBox studentsBox;
        private System.Windows.Forms.Label subjectsLabel;
        private System.Windows.Forms.Label groupsLabel;
        private System.Windows.Forms.Label studentsLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ComboBox gradeBox;
        private System.Windows.Forms.Label markLabel;
        private System.Windows.Forms.Label oldMarkLabel;
    }
}