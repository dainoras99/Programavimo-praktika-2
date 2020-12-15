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
    public partial class AssignStudentsToGroupControl : UserControl
    {
        private UsersRepository usersData = new UsersRepository();
        private NonUsersRepository otherData = new NonUsersRepository();
        public AssignStudentsToGroupControl()
        {
            InitializeComponent();


            List<Group> groupsList = otherData.GetAllGroups();
            foreach (Group group in groupsList)
            {
                groupsBox.Items.Add(group.Name);
            }

            List<Student> studentsList = usersData.GetAllUnassignedStudents();
            foreach (Student student in studentsList)
            {
                groupsListBox.Items.Add(student.Name + " " + student.Surname);
            }

            if (groupsListBox.Items.Count == 0)
            {
                groupsListBox.Visible = false;
                noStudentsLabel.Visible = true;
                groupsBox.Visible = false;
                label1.Visible = false;
                addButton.Visible = false;
            }
            else
            {
                groupsListBox.Visible = true;
                noStudentsLabel.Visible = false;
                groupsBox.Visible = true;
                label1.Visible = true;
                addButton.Visible = true;
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                string group = groupsBox.Text;
                List<string> checkedStudents = new List<string>();

                if (group == "")
                    throw new Exception("Jūs turite pasirinkti kažkurią grupę prieš priskirdami studentus");

                if (groupsListBox.CheckedItems.Count == 0)
                    throw new Exception("Jūs nepasirinkote studentų");
                
                foreach (string item in groupsListBox.CheckedItems)
                {
                    checkedStudents.Add(item);
                }

                foreach (String item in checkedStudents)
                {
                    groupsListBox.Items.Remove(item);
                    string name = item.Substring(0, item.IndexOf(' '));
                    string surname = item.Substring(item.IndexOf(' ') + 1);
                    usersData.AssignStudentsToGroup(otherData.FindGroupsId(group), usersData.FindStudentsId(name, surname));
                }
                MessageBox.Show("Sėkmingai priskyrėte studentus prie grupės");

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
    }
}
