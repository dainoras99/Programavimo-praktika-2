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
    public partial class AdminWindow : Form
    {
        private UsersRepository data;
        private NonUsersRepository otherData;
        public AdminWindow()
        {
            InitializeComponent();
            data = new UsersRepository();
            otherData = new NonUsersRepository();
            int width = flowLayoutPanel1.Width - 7;
        }

        private void studentsButton_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();

            Button addNewStudent = new Button();
            addNewStudent.UseVisualStyleBackColor = true;
            addNewStudent.Text = "PRIDĖTI NAUJĄ STUDENTĄ";
            addNewStudent.Width = 245;
            addNewStudent.Click += AddNewStudent_Click;
            flowLayoutPanel1.Controls.Add(addNewStudent);

            Button removeStudent = new Button();
            removeStudent.UseVisualStyleBackColor = true;
            removeStudent.Text = "ŠALINTI STUDENTĄ";
            removeStudent.Width = 245;

            removeStudent.Click += RemoveStudent_Click;
            flowLayoutPanel1.Controls.Add(removeStudent);
        }

        private void RemoveStudent_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            List<Student> studentsList = data.GetAllStudents();
            foreach (Student student in studentsList)
            {
                RemoveStudentControl iac = new RemoveStudentControl(student);
                flowLayoutPanel2.Controls.Add(iac);
            }
        }

        private void AddNewStudent_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            AddStudentControl iac = new AddStudentControl();
            flowLayoutPanel2.Controls.Add(iac);

        }

        private void professorsButton_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();

            Button addNewProfessor = new Button();
            addNewProfessor.UseVisualStyleBackColor = true;
            addNewProfessor.Text = "PRIDĖTI NAUJĄ DĖSTYTOJĄ";
            addNewProfessor.Width = 245;
            addNewProfessor.Click += AddNewProfessor_Click;
            flowLayoutPanel1.Controls.Add(addNewProfessor);

            Button removeProfessor = new Button();
            removeProfessor.UseVisualStyleBackColor = true;
            removeProfessor.Text = "ŠALINTI DĖSTYTOJĄ";
            removeProfessor.Width = 245;
            removeProfessor.Click += RemoveProfessor_Click;
            flowLayoutPanel1.Controls.Add(removeProfessor);
        }

        private void RemoveProfessor_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            List<Professor> professorsList = data.GetAllProfessors();
            foreach (Professor professor in professorsList)
            {
                RemoveProfessorControl iuc = new RemoveProfessorControl(professor);
                flowLayoutPanel2.Controls.Add(iuc);
            }
        }

        private void AddNewProfessor_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            AddProfessorControl iac = new AddProfessorControl();
            flowLayoutPanel2.Controls.Add(iac);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupsButton_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();

            Button addNewGroup = new Button();
            addNewGroup.UseVisualStyleBackColor = true;
            addNewGroup.Text = "PRIDĖTI NAUJĄ GRUPĘ";
            addNewGroup.Width = 245;
            addNewGroup.Click += AddNewGroup_Click;
            flowLayoutPanel1.Controls.Add(addNewGroup);

            Button removeGroup = new Button();
            removeGroup.UseVisualStyleBackColor = true;
            removeGroup.Text = "ŠALINTI GRUPĘ";
            removeGroup.Width = 245;
            removeGroup.Click += RemoveGroup_Click;
            flowLayoutPanel1.Controls.Add(removeGroup);

            Button assignStudentsToGroup = new Button();
            assignStudentsToGroup.UseVisualStyleBackColor = true;
            assignStudentsToGroup.Text = "PRISKIRTI STUDENTUS Į ATITINKAMĄ GRUPĘ";
            assignStudentsToGroup.Width = 245;
            assignStudentsToGroup.Height = 40;
            assignStudentsToGroup.Click += AssignStudentsToGroup_Click;
            flowLayoutPanel1.Controls.Add(assignStudentsToGroup);

            Button assignSubjectsToGroup = new Button();
            assignSubjectsToGroup.UseVisualStyleBackColor = true;
            assignSubjectsToGroup.Text = "PRISKIRTI DĖSTOMUS DALYKUS Į ATITINKAMĄ GRUPĘ";
            assignSubjectsToGroup.Width = 245;
            assignSubjectsToGroup.Height = 40;
            assignSubjectsToGroup.Click += AssignSubjectsToGroup_Click;
            flowLayoutPanel1.Controls.Add(assignSubjectsToGroup);

            Button unassignStudentsToGroup = new Button();
            unassignStudentsToGroup.UseVisualStyleBackColor = true;
            unassignStudentsToGroup.Text = "ATSKIRTI STUDENTUS IŠ GRUPIŲ";
            unassignStudentsToGroup.Width = 245;
            unassignStudentsToGroup.Height = 40;
            unassignStudentsToGroup.Click += UnassignStudentsToGroup_Click;
            flowLayoutPanel1.Controls.Add(unassignStudentsToGroup);

            Button unassignSubjectsToGroup = new Button();
            unassignSubjectsToGroup.UseVisualStyleBackColor = true;
            unassignSubjectsToGroup.Text = "ATSKIRTI DĖSTOMUS DALYKUS IŠ ATITINKAMOS GRUPĖS";
            unassignSubjectsToGroup.Width = 245;
            unassignSubjectsToGroup.Height = 40;
            unassignSubjectsToGroup.Click += UnassignSubjectsToGroup_Click;
            flowLayoutPanel1.Controls.Add(unassignSubjectsToGroup);


        }

        private void UnassignSubjectsToGroup_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            UnassignSubjectsFromGroupControl iac = new UnassignSubjectsFromGroupControl();
            flowLayoutPanel2.Controls.Add(iac);
        }

        private void UnassignStudentsToGroup_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            UnassignStudentFromGroupControl iac = new UnassignStudentFromGroupControl();
            flowLayoutPanel2.Controls.Add(iac);
        }

        private void AssignSubjectsToGroup_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            AssignSubjectsToGroupControl iac = new AssignSubjectsToGroupControl();
            flowLayoutPanel2.Controls.Add(iac);
        }

        private void AssignStudentsToGroup_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            AssignStudentsToGroupControl iac = new AssignStudentsToGroupControl();
            flowLayoutPanel2.Controls.Add(iac);
        }

        private void RemoveGroup_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            List<Group> groupsList = otherData.GetAllGroups();
            foreach (Group group in groupsList)
            {
                RemoveGroup iac = new RemoveGroup(group);
                flowLayoutPanel2.Controls.Add(iac);
            }
        }

        private void AddNewGroup_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            AddNewGroup iac = new AddNewGroup();
            flowLayoutPanel2.Controls.Add(iac);
        }

        private void subjectsButton_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();

            Button addNewSubject = new Button();
            addNewSubject.UseVisualStyleBackColor = true;
            addNewSubject.Text = "PRIDĖTI NAUJĄ DĖSTOMĄ DALYKĄ";
            addNewSubject.Width = 245;
            addNewSubject.Click += AddNewSubject_Click;
            flowLayoutPanel1.Controls.Add(addNewSubject);

            Button removeSubject = new Button();
            removeSubject.UseVisualStyleBackColor = true;
            removeSubject.Text = "ŠALINTI DĖSTOMĄ DALYKĄ";
            removeSubject.Width = 245;
            removeSubject.Click += RemoveSubject_Click;
            flowLayoutPanel1.Controls.Add(removeSubject);

            Button assignSubjectToProfessor = new Button();
            assignSubjectToProfessor.UseVisualStyleBackColor = true;
            assignSubjectToProfessor.Text = "PRISKIRTI DĖSTYTOJĄ DĖSTOMAM DALYKUI";
            assignSubjectToProfessor.Width = 245;
            assignSubjectToProfessor.Height = 40;
            assignSubjectToProfessor.Click += AssignSubjectToProfessor_Click;
            flowLayoutPanel1.Controls.Add(assignSubjectToProfessor);


            Button unassignSubjectFromProfessor = new Button();
            unassignSubjectFromProfessor.UseVisualStyleBackColor = true;
            unassignSubjectFromProfessor.Text = "ATSKIRTI DĖSTOMĄ DALYKĄ NUO DĖSTYTOJO";
            unassignSubjectFromProfessor.Width = 245;
            unassignSubjectFromProfessor.Height = 40;
            unassignSubjectFromProfessor.Click += UnassignSubjectFromProfessor_Click;
            flowLayoutPanel1.Controls.Add(unassignSubjectFromProfessor);
        }

        private void AssignSubjectToProfessor_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            AssignSubjectToProfessorControl iac = new AssignSubjectToProfessorControl();
            flowLayoutPanel2.Controls.Add(iac);
        }

        private void UnassignSubjectFromProfessor_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            UnassignSubjectFromProfessorControl iac = new UnassignSubjectFromProfessorControl();
            flowLayoutPanel2.Controls.Add(iac);
        }


        private void RemoveSubject_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            List<Subject> subjectsList = otherData.GetAllSubjects();
            foreach (Subject subject in subjectsList)
            {
                RemoveSubject iac = new RemoveSubject(subject);
                flowLayoutPanel2.Controls.Add(iac);
            }
        }

        private void AddNewSubject_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            AddSubjectControl iac = new AddSubjectControl();
            flowLayoutPanel2.Controls.Add(iac);
        }
    }
}
