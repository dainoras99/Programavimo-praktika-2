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
    public partial class UnassignSubjectsFromGroupControl : UserControl
    {
        private NonUsersRepository otherData = new NonUsersRepository();
        public UnassignSubjectsFromGroupControl()
        {
            InitializeComponent();

            List<Group> groupsList = otherData.GetAllGroups();
            foreach (Group group in groupsList)
            {
                groupsBox.Items.Add(group.Name);
            }

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                string group = groupsBox.Text;
                List<string> checkedSubjects = new List<string>();

                if (group == "")
                    throw new Exception("Jūs turite pasirinkti kažkurią grupę prieš atskirdami dėstomus dalykus");

                if (subjectsListBox.CheckedItems.Count == 0)
                    throw new Exception("Jūs nepasirinkote dėstomų dalykų");

                foreach (string item in subjectsListBox.CheckedItems)
                {
                    checkedSubjects.Add(item);
                }

                foreach (String item in checkedSubjects)
                {
                    subjectsListBox.Items.Remove(item);
                    string title = item;
                    otherData.UnAssignSubjectsToGroup(otherData.FindGroupsId(group), otherData.FindSubjectsId(title));
                }
                MessageBox.Show("Sėkmingai atskyrėte dėstomus dalykus nuo grupės");
                foreach (int checkedItemIndex in subjectsListBox.CheckedIndices)
                {
                    subjectsListBox.SetItemChecked(checkedItemIndex, false);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void groupsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Subject_Group> subjectsGroupsList = otherData.GetAllSubject_Group();
            List<Group> groupsList = otherData.GetAllGroups();
            List<Subject> subjectsList = otherData.GetAllSubjects();

            foreach (Subject subject in subjectsList)
            {
                subjectsListBox.Items.Remove(subject.Title);
            }

            foreach (Group group in groupsList)
            {
                if (groupsBox.Text == group.Name)
                {
                    foreach (Subject subject in subjectsList)
                    {
                        subjectsListBox.Items.Remove(subject.Title);
                        foreach (Subject_Group subject_Group in subjectsGroupsList)
                        {
                            if (subject_Group.Subject_id == subject.Id && subject_Group.Group_id == group.Id)
                            {
                                subjectsListBox.Items.Add(subject.Title);
                            }
                        }
                    }

                }
            }
        }
    }
}
