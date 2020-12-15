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
    public partial class AssignSubjectToProfessorControl : UserControl
    {
        private UsersRepository usersData = new UsersRepository();
        private NonUsersRepository otherData = new NonUsersRepository();
        public AssignSubjectToProfessorControl()
        {
            InitializeComponent();

            List<Professor> professorsList = usersData.GetAllProfessors();
            foreach (Professor professor in professorsList)
            {
                professorsBox.Items.Add(professor.degree + " " + professor.Name + " " + professor.Surname);
            }

            List<Subject> subjectsList = otherData.GetAllUnassignedSubjects();
            foreach (Subject subject in subjectsList)
            {
                subjectsListBox.Items.Add(subject.Title);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                string professor = professorsBox.Text;
                List<string> checkedSubjects = new List<string>();

                if (professor == "")
                    throw new Exception("Jūs turite pasirinkti kažkurį dėstytoją prieš priskirdami dėstomus dalykus");

                if (subjectsListBox.CheckedItems.Count == 0)
                    throw new Exception("Jūs nepasirinkote dėstomų dalykų");

                string degree = professor.Substring(0, professor.IndexOf(' '));
                string fullname = professor.Substring(professor.IndexOf(' ') + 1);
                string name = fullname.Substring(0, fullname.IndexOf(' '));
                string surname = fullname.Substring(fullname.IndexOf(' ') + 1);

                foreach (string item in subjectsListBox.CheckedItems)
                {
                    checkedSubjects.Add(item);
                }

                foreach (String item in checkedSubjects)
                {
                    subjectsListBox.Items.Remove(item);
                    otherData.AssignSubjectsToProfessor(item, usersData.FindProfessorId(name, surname));
                }
                MessageBox.Show("Sėkmingai priskyrėte dėstomą/us dalyką/us prie dėstytojo");

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
