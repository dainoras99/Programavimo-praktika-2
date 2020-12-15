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
    public partial class AddStudentControl : UserControl
    {
        private UsersRepository data = new UsersRepository();
        public AddStudentControl()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameBox.Text;
                string surname = surnameBox.Text;
                DateTime birthdate = dateTimePicker1.Value;
                string username = data.FirstLetterToLowerCase(nameBox.Text);
                string password = data.FirstLetterToLowerCase(surnameBox.Text);

                List<Student> studentsList = data.GetAllStudents();
                foreach (Student students in studentsList)
                {
                    if (students.Name == nameBox.Text && students.Surname == surnameBox.Text)
                        throw new Exception("Jau egzistuoja studentas su tokiu vardu ir pavarde");
                }

                Student student = new Student(0, name, surname, birthdate, username, password);

                data.AddNewStudent(student);

                MessageBox.Show("Sėkmingai pridėjote naują studentą");

                nameBox.Clear();
                surnameBox.Clear();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
