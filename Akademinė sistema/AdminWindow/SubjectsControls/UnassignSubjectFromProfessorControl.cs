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
    public partial class UnassignSubjectFromProfessorControl : UserControl
    {
        private UsersRepository usersData = new UsersRepository();
        private NonUsersRepository otherData = new NonUsersRepository();
        public UnassignSubjectFromProfessorControl()
        {
            InitializeComponent();
            List<Subject> subjectsList = otherData.GetAllAssignedSubjects();
            foreach (Subject subject in subjectsList)
            {
                subjectsListBox.Items.Add(subject.Title);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> checkedSubjects = new List<string>();

                foreach (string item in subjectsListBox.CheckedItems)
                {
                    checkedSubjects.Add(item);
                }
                if (subjectsListBox.CheckedItems.Count == 0)
                    throw new Exception("Jūs nepasirinkote Dėstomų dalykų");

                foreach (String item in checkedSubjects)
                {
                    subjectsListBox.Items.Remove(item);
                    otherData.UnassignSubjectsToProfessor(item);
                }
                MessageBox.Show("Sėkmingai atskyrėte dėstomą/us dalyką/us");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
