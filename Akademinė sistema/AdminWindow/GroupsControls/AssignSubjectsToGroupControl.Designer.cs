namespace Akademinė_sistema
{
    partial class AssignSubjectsToGroupControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.subjectsListBox = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.groupsBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // subjectsListBox
            // 
            this.subjectsListBox.FormattingEnabled = true;
            this.subjectsListBox.HorizontalScrollbar = true;
            this.subjectsListBox.Location = new System.Drawing.Point(72, 146);
            this.subjectsListBox.Name = "subjectsListBox";
            this.subjectsListBox.Size = new System.Drawing.Size(295, 94);
            this.subjectsListBox.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 15);
            this.label4.TabIndex = 51;
            this.label4.Text = "Priskirti dėstomus dalykus prie grupės";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(17, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "DĖSTOMŲ DALYKŲ PRISKIRIMAS PRIE GRUPĖS";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(117, 63);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(50, 15);
            this.nameLabel.TabIndex = 52;
            this.nameLabel.Text = "Grupė:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(164, 273);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 55;
            this.addButton.Text = "PRIDĖTI";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // groupsBox
            // 
            this.groupsBox.FormattingEnabled = true;
            this.groupsBox.Location = new System.Drawing.Point(173, 62);
            this.groupsBox.Name = "groupsBox";
            this.groupsBox.Size = new System.Drawing.Size(121, 21);
            this.groupsBox.TabIndex = 54;
            this.groupsBox.SelectedIndexChanged += new System.EventHandler(this.groupsBox_SelectedIndexChanged);
            // 
            // AssignSubjectsToGroupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupsBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.subjectsListBox);
            this.Name = "AssignSubjectsToGroupControl";
            this.Size = new System.Drawing.Size(418, 317);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox subjectsListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox groupsBox;
    }
}
