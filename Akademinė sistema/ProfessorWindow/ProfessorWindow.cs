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
    public partial class ProfessorWindow : Form
    {
        private Professor professor = LoginWindow.LoggedInProfessor;
        private UsersRepository data = new UsersRepository();
        private NonUsersRepository otherData = new NonUsersRepository();
        private List<Subject> currentSubjectsList = new List<Subject>();
        private List<Group> currentGroupsList = new List<Group>();
        private List<Student> currentStudentList = new List<Student>();
        private Student selectedStudent;
        private Subject selectedSubject;
        public ProfessorWindow()
        {
            InitializeComponent();
            userLabel.Text += professor.degree + " " + professor.Name + " " + professor.Surname;

            List<Subject> subjectsList = otherData.GetAllAssignedSubjects();
            foreach (Subject subject in subjectsList)
            {
                if (professor.Id == otherData.FindSubjectProfessorId(subject.Title))
                {
                    subjectsBox.Items.Add(subject.Title);
                    currentSubjectsList.Add(subject);
                }
            }
            if (subjectsBox.Items.Count == 0)
            {
                groupsBox.Visible = false;
                GradeStudentLabelsAndButtonFalse();
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void subjectsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSubject = null;
            foreach (Subject subject in currentSubjectsList)
            {
                if (subject.Title == subjectsBox.Text)
                {
                    selectedSubject = subject;
                }
            }
            groupsBox.SelectedIndex = -1;
            studentsBox.SelectedIndex = -1;
            groupsBox.Items.Clear();
            studentsBox.Items.Clear();
            currentGroupsList.Clear();
            List<Group> groupsList = otherData.GetAllGroups();
            List<Subject_Group> subject_groupList = otherData.GetAllSubject_Group();
            foreach (Subject subject in currentSubjectsList)
            {
                if (subject.Title == subjectsBox.Text)
                {
                    foreach (Subject_Group subject_Group in subject_groupList)
                    {
                        if (subject_Group.Subject_id == subject.Id)
                        {
                            groupsBox.Items.Add(otherData.FindGroupNameById(subject_Group.Group_id));
                            Group group = new Group(subject_Group.Group_id, otherData.FindGroupNameById(subject_Group.Group_id));
                            currentGroupsList.Add(group);
                            groupsBox.Visible = true;
                            groupsLabel.Visible = true;
                            groupsLabel.Text = "PASIRINKITE STUDENTŲ GRUPĘ:";
                            studentsLabel.Visible = false;
                            GradeStudentLabelsAndButtonFalse();
                        }
                    }
                }
            }
            if (groupsBox.Items.Count == 0)
            {
                groupsBox.Visible = false;
                groupsLabel.Visible = true;
                groupsLabel.Text = "ŠIS DĖSTOMAS DALYKAS NETURI PRISKIRTŲ GRUPIŲ";
                studentsLabel.Visible = false;
                studentsBox.Visible = false;
                GradeStudentLabelsAndButtonFalse();
            }
        }

        private void groupsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentsBox.SelectedIndex = -1;
            studentsBox.Items.Clear();

            List<Student> studentsList = data.GetAllAssignedStudents();
            foreach(Group group in currentGroupsList)
            {
                if(group.Name == groupsBox.Text)
                {
                    foreach(Student student in studentsList)
                    {
                        if (group.Id == data.FindStudentsGroupId(student.Name, student.Surname))
                        {
                            studentsBox.Items.Add(student.Name + " " + student.Surname);
                            currentStudentList.Add(student);
                            studentsBox.Visible = true;
                            studentsLabel.Visible = true;
                            studentsLabel.Text = "PASIRINKITE STUDENTĄ VERTINIMUI:";
                            GradeStudentLabelsAndButtonFalse();
                        }
                    }
                }
            }
            if (studentsBox.Items.Count == 0)
            {
                studentsBox.Visible = false;
                studentsLabel.Visible = true;
                studentsLabel.Text = "ŠI GRUPĖ NETURI PRISKIRTŲ STUDENTŲ";
                GradeStudentLabelsAndButtonFalse();
            }
        }

        private void studentsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Grade> gradesList = otherData.GetAllGrades();
            
            markLabel.Visible = true;
            oldMarkLabel.Visible = true;
            oldMarkLabel.Text = "ĮVERTINKITE STUDENTĄ";
            okButton.Visible = true;
            gradeBox.Visible = true;

            selectedStudent = null;
            if (studentsBox.Text != "")
            {
                string name = studentsBox.Text.Substring(0, studentsBox.Text.IndexOf(' '));
                string surname = studentsBox.Text.Substring(studentsBox.Text.IndexOf(' ') + 1);
                foreach (Student student in currentStudentList)
                {
                    if (student.Name == name && student.Surname == surname)
                    {
                        selectedStudent = student;
                       
                    }
                }
            }
            if (selectedStudent != null)
            {
                foreach (Grade grade in gradesList)
                {
                    if (grade.Studentid == selectedStudent.Id)
                    {
                        oldMarkLabel.Text = "Šį studentą įvertinote pažymiu: " + grade.grade + " Keisti pažymį: ";
                    }
                }
            }
        }
        private void GradeStudentLabelsAndButtonFalse()
        {
            markLabel.Visible = false;
            oldMarkLabel.Visible = false;
            okButton.Visible = false;
            gradeBox.Visible = false;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Grade> gradesList = otherData.GetAllGrades();

                if (selectedStudent != null)
                {
                    foreach (Grade grade in gradesList)
                    {
                        if (grade.Studentid == selectedStudent.Id)
                        {
                            data.RemovePreviousGrade(selectedStudent.Id);
                        }
                    }
                }

                int thisGrade = int.Parse(gradeBox.Text.ToString());
                if (thisGrade < 1 || thisGrade > 10)
                    throw new Exception("Įvertinimas turi būti tarp 1 ir 10");
                otherData.AddNewGrade(thisGrade, selectedStudent.Id, selectedSubject.Id);
                MessageBox.Show("Sėkmingai įvertinote studentą!");
                GradeStudentLabelsAndButtonFalse();
                studentsBox.Visible = false;
                studentsLabel.Visible = false;
                groupsBox.Visible = false;
                groupsLabel.Visible = false;
                gradeBox.SelectedIndex = -1;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
