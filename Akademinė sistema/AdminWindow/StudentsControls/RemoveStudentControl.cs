using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Akademinė_sistema;

namespace Akademinė_sistema
{
    public partial class RemoveStudentControl : UserControl
    {
        private UsersRepository data = new UsersRepository();
        private Student student;

        

        public RemoveStudentControl()
        {
            InitializeComponent();

        }
        public RemoveStudentControl(Student student)
        {
            InitializeComponent();
            this.student = student;
            nameLabel.Text = student.Name;
            surnameLabel.Text = student.Surname;
            birthdateLabel.Text = student.BirthDate.ToString("yyyy-MM-dd");

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                data.RemoveStudent(student.Id);
                MessageBox.Show("Studentas pašalintas iš sistemos");
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
