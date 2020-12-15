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
    public partial class UnassignStudentFromGroupControl : UserControl
    {
        private UsersRepository usersData = new UsersRepository();
        private NonUsersRepository otherData = new NonUsersRepository();
        public UnassignStudentFromGroupControl()
        {
            InitializeComponent();
            List<Student> studentsList = usersData.GetAllAssignedStudents();
            foreach (Student student in studentsList)
            {
                studentsListBox.Items.Add(student.Name + " " + student.Surname);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> checkedStudents = new List<string>();

                foreach (string item in studentsListBox.CheckedItems)
                {
                    checkedStudents.Add(item);
                }
                if (studentsListBox.CheckedItems.Count == 0)
                    throw new Exception("Jūs nepasirinkote studentų");

                foreach (String item in checkedStudents)
                {
                    studentsListBox.Items.Remove(item);
                    string name = item.Substring(0, item.IndexOf(' '));
                    string surname = item.Substring(item.IndexOf(' ') + 1);
                    usersData.UnassignStudentsFromGroupByStudentId(usersData.FindStudentsId(name, surname));
                }
                MessageBox.Show("Sėkmingai atskyrėte studentą/us nuo grupės");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
