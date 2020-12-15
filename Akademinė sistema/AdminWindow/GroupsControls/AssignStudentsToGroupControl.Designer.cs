namespace Akademinė_sistema
{
    partial class AssignStudentsToGroupControl
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
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.groupsListBox = new System.Windows.Forms.CheckedListBox();
            this.groupsBox = new System.Windows.Forms.ComboBox();
            this.noStudentsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(164, 273);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 44;
            this.addButton.Text = "PRIDĖTI";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "Priskirti studentus prie naujos grupės";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(47, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "STUDENTŲ PRISKIRIMAS PRIE GRUPĖS";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(117, 63);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(50, 15);
            this.nameLabel.TabIndex = 37;
            this.nameLabel.Text = "Grupė:";
            // 
            // groupsListBox
            // 
            this.groupsListBox.FormattingEnabled = true;
            this.groupsListBox.HorizontalScrollbar = true;
            this.groupsListBox.Location = new System.Drawing.Point(72, 146);
            this.groupsListBox.Name = "groupsListBox";
            this.groupsListBox.Size = new System.Drawing.Size(295, 94);
            this.groupsListBox.TabIndex = 48;
            // 
            // groupsBox
            // 
            this.groupsBox.FormattingEnabled = true;
            this.groupsBox.Location = new System.Drawing.Point(173, 62);
            this.groupsBox.Name = "groupsBox";
            this.groupsBox.Size = new System.Drawing.Size(121, 21);
            this.groupsBox.TabIndex = 50;
            // 
            // noStudentsLabel
            // 
            this.noStudentsLabel.AutoSize = true;
            this.noStudentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noStudentsLabel.Location = new System.Drawing.Point(56, 63);
            this.noStudentsLabel.Name = "noStudentsLabel";
            this.noStudentsLabel.Size = new System.Drawing.Size(311, 15);
            this.noStudentsLabel.TabIndex = 65;
            this.noStudentsLabel.Text = "Nėra studentų nepriskirtų prie kažkurios grupės";
            this.noStudentsLabel.Visible = false;
            // 
            // AssignStudentsToGroupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.noStudentsLabel);
            this.Controls.Add(this.groupsBox);
            this.Controls.Add(this.groupsListBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameLabel);
            this.Name = "AssignStudentsToGroupControl";
            this.Size = new System.Drawing.Size(418, 317);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.CheckedListBox groupsListBox;
        private System.Windows.Forms.ComboBox groupsBox;
        private System.Windows.Forms.Label noStudentsLabel;
    }
}
