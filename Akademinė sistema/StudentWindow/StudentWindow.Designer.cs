namespace Akademinė_sistema
{
    partial class StudentWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentWindow));
            this.logoutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SubjectsLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SelectedSubjectLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.userLabel = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(521, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "STUDENTO AKADEMINĖ INFORMACIJA";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(90, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "JŪSŲ DALYKAI";
            // 
            // SubjectsLayoutPanel
            // 
            this.SubjectsLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SubjectsLayoutPanel.Location = new System.Drawing.Point(49, 215);
            this.SubjectsLayoutPanel.Name = "SubjectsLayoutPanel";
            this.SubjectsLayoutPanel.Size = new System.Drawing.Size(246, 421);
            this.SubjectsLayoutPanel.TabIndex = 0;
            // 
            // SelectedSubjectLayoutPanel
            // 
            this.SelectedSubjectLayoutPanel.Location = new System.Drawing.Point(374, 158);
            this.SelectedSubjectLayoutPanel.Name = "SelectedSubjectLayoutPanel";
            this.SelectedSubjectLayoutPanel.Size = new System.Drawing.Size(537, 478);
            this.SelectedSubjectLayoutPanel.TabIndex = 1;
            // 
            // userLabel
            // 
            this.userLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.userLabel.Location = new System.Drawing.Point(466, 13);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(323, 22);
            this.userLabel.TabIndex = 63;
            this.userLabel.Text = "Esate prisijungęs: ";
            // 
            // StudentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(938, 648);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.SelectedSubjectLayoutPanel);
            this.Controls.Add(this.SubjectsLayoutPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StudentWindow";
            this.Text = "StudentWindow";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel SubjectsLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel SelectedSubjectLayoutPanel;
        private System.Windows.Forms.Label userLabel;
    }
}