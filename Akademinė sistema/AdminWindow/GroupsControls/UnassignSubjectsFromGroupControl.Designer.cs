namespace Akademinė_sistema
{
    partial class UnassignSubjectsFromGroupControl
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
            this.removeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupsBox = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // subjectsListBox
            // 
            this.subjectsListBox.FormattingEnabled = true;
            this.subjectsListBox.HorizontalScrollbar = true;
            this.subjectsListBox.Location = new System.Drawing.Point(72, 146);
            this.subjectsListBox.Name = "subjectsListBox";
            this.subjectsListBox.Size = new System.Drawing.Size(295, 94);
            this.subjectsListBox.TabIndex = 60;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(164, 273);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 59;
            this.removeButton.Text = "ATSKIRTI";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 15);
            this.label1.TabIndex = 58;
            this.label1.Text = "Atskirti dėstomus dalykus iš atitinkamos grupės";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(25, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "DĖSTOMŲ DALYKŲ ATSKIRIMAS NUO GRUPĖS";
            // 
            // groupsBox
            // 
            this.groupsBox.FormattingEnabled = true;
            this.groupsBox.Location = new System.Drawing.Point(173, 62);
            this.groupsBox.Name = "groupsBox";
            this.groupsBox.Size = new System.Drawing.Size(121, 21);
            this.groupsBox.TabIndex = 62;
            this.groupsBox.SelectedIndexChanged += new System.EventHandler(this.groupsBox_SelectedIndexChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(117, 63);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(50, 15);
            this.nameLabel.TabIndex = 61;
            this.nameLabel.Text = "Grupė:";
            // 
            // UnassignSubjectsFromGroupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupsBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.subjectsListBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "UnassignSubjectsFromGroupControl";
            this.Size = new System.Drawing.Size(418, 317);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox subjectsListBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox groupsBox;
        private System.Windows.Forms.Label nameLabel;
    }
}
