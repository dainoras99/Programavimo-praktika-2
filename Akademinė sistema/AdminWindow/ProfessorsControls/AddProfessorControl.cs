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
    public partial class AddProfessorControl : UserControl
    {
        private UsersRepository data = new UsersRepository();
        public AddProfessorControl()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                string degree = degreeBox.Text;
                string name = nameBox.Text;
                string surname = surnameBox.Text;
                DateTime birthdate = dateTimePicker1.Value;
                string username = data.FirstLetterToLowerCase(nameBox.Text);
                string password = data.FirstLetterToLowerCase(surnameBox.Text);

                List<Professor> professorsList = data.GetAllProfessors();
                foreach (Professor professors in professorsList)
                {
                    if (professors.Name == nameBox.Text && professors.Surname == surnameBox.Text)
                        throw new Exception("Jau egzistuoja dėstytojas su tokiu vardu ir pavarde");
                }

                if (degree != "Asist." && degree != "Doc." && degree != "Lekt.")
                {
                    throw new Exception("Pasirinkite dėstytojo kvalifikaciją");
                }

                Professor professor = new Professor(0, degree, name, surname, birthdate, username, password);

                data.AddNewProfessor(professor);

                MessageBox.Show("Sėkmingai pridėjote naują dėstytoją");

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
