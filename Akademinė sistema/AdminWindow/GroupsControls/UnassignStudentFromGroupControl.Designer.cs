namespace Akademinė_sistema
{
    partial class UnassignStudentFromGroupControl
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
            this.studentsListBox = new System.Windows.Forms.CheckedListBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentsListBox
            // 
            this.studentsListBox.FormattingEnabled = true;
            this.studentsListBox.HorizontalScrollbar = true;
            this.studentsListBox.Location = new System.Drawing.Point(74, 116);
            this.studentsListBox.Name = "studentsListBox";
            this.studentsListBox.Size = new System.Drawing.Size(295, 94);
            this.studentsListBox.TabIndex = 56;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(166, 243);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 55;
            this.removeButton.Text = "ATSKIRTI";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 15);
            this.label1.TabIndex = 54;
            this.label1.Text = "Atskirti studentus nuo grupės";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(47, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "STUDENTŲ ATSKIRIMAS NUO GRUPĖS";
            // 
            // UnassignStudentFromGroupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.studentsListBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "UnassignStudentFromGroupControl";
            this.Size = new System.Drawing.Size(418, 294);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox studentsListBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
