using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akademinė_sistema
{
    public partial class StudentWindow : Form
    {
        private Student student = LoginWindow.LoggedInStudent;
        private NonUsersRepository otherData = new NonUsersRepository();
        private UsersRepository data = new UsersRepository();
        public StudentWindow()
        {
            InitializeComponent();
            int groupId = otherData.GetStudentsGroup(student.Name, student.Surname);
            userLabel.Text += student.Name + " " + student.Surname;

            List<Subject_Group> allSubjectsAndGroups = otherData.GetAllSubject_Group();
            List<Subject> allAssignedsubjectsList = otherData.GetAllAssignedSubjects();
            List<Subject_Group> studentsSubjectsAndGroupIds = new List<Subject_Group>();
            List<Subject> studentSubjects = new List<Subject>();

            foreach(Subject_Group subject_Group in allSubjectsAndGroups)
            {
                if (subject_Group.Group_id == groupId)
                {
                    studentsSubjectsAndGroupIds.Add(subject_Group); // Pridedami į listą visi studento subjectsid
                }
            }

            foreach (Subject subject in allAssignedsubjectsList)
            {
                foreach (Subject_Group subject_Group in studentsSubjectsAndGroupIds)
                {
                    if (subject_Group.Subject_id == subject.Id)
                    {
                        studentSubjects.Add(subject); // Pridedami į listą visi studento subjects
                    }
                }
            }

            int width = SubjectsLayoutPanel.Width - 7;
            foreach (Subject subject in studentSubjects)
            {
                Button subjectButton = new Button();
                subjectButton.Text = subject.Title;
                subjectButton.Width = width;
                subjectButton.UseVisualStyleBackColor = true;
                subjectButton.Tag = subject;
                subjectButton.Click += SubjectButton_Click;
                SubjectsLayoutPanel.Controls.Add(subjectButton);
            }

        }

        private void SubjectButton_Click(object sender, EventArgs e)
        {
            SelectedSubjectLayoutPanel.Controls.Clear();
            Button button = (Button)sender;
            Subject subject = (Subject)button.Tag;

            StudentSelectedSubjectControl iac = new StudentSelectedSubjectControl(subject);
            SelectedSubjectLayoutPanel.Controls.Add(iac);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
