using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akademinė_sistema
{
    public partial class RemoveProfessorControl : UserControl
    {
        private UsersRepository data = new UsersRepository();
        private Professor professor;
        public RemoveProfessorControl()
        {
            InitializeComponent();

        }
        public RemoveProfessorControl(Professor professor)
        {
            InitializeComponent();
            this.professor = professor;
            nameLabel.Text = professor.degree + " " + professor.Name + " " + professor.Surname;
            birthdateLabel.Text = professor.BirthDate.ToString("yyyy-MM-dd");
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                data.RemoveProfessor(professor.Id);
                MessageBox.Show("Dėstytojas pašalintas iš sistemos");
                foreach (Label l in this.Controls.OfType<Label>())
                {
                    l.Visible = false;
                }
                removeButton.Visible = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
