namespace Akademinė_sistema
{
    partial class AssignSubjectToProfessorControl
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
            this.professorsBox = new System.Windows.Forms.ComboBox();
            this.subjectsListBox = new System.Windows.Forms.CheckedListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // professorsBox
            // 
            this.professorsBox.FormattingEnabled = true;
            this.professorsBox.Location = new System.Drawing.Point(166, 62);
            this.professorsBox.Name = "professorsBox";
            this.professorsBox.Size = new System.Drawing.Size(195, 21);
            this.professorsBox.TabIndex = 55;
            // 
            // subjectsListBox
            // 
            this.subjectsListBox.FormattingEnabled = true;
            this.subjectsListBox.HorizontalScrollbar = true;
            this.subjectsListBox.Location = new System.Drawing.Point(74, 148);
            this.subjectsListBox.Name = "subjectsListBox";
            this.subjectsListBox.Size = new System.Drawing.Size(295, 94);
            this.subjectsListBox.TabIndex = 54;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(166, 275);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 53;
            this.addButton.Text = "PRIDĖTI";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 15);
            this.label1.TabIndex = 52;
            this.label1.Text = "Priskirti dėstytoją prie dėstomų dalykų";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(7, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "DĖSTYTOJŲ PRISKIRIMAS PRIE DĖSTOMO DALYKO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 57;
            this.label4.Text = "DĖSTYTOJAS:";
            // 
            // AssignSubjectToProfessorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.professorsBox);
            this.Controls.Add(this.subjectsListBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "AssignSubjectToProfessorControl";
            this.Size = new System.Drawing.Size(418, 317);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox professorsBox;
        private System.Windows.Forms.CheckedListBox subjectsListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}
