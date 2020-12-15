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
    public partial class StudentSelectedSubjectControl : UserControl
    {
        private NonUsersRepository otherData = new NonUsersRepository();
        private Subject subject;
        private Student student = LoginWindow.LoggedInStudent;
        private Grade grade;
        public StudentSelectedSubjectControl()
        {
            InitializeComponent();
        }
        public StudentSelectedSubjectControl(Subject subject)
        {
            InitializeComponent();
            this.subject = subject;

            titleLabel.Text = subject.Title;
            descriptionLabel.Text = subject.Description;


            List<Grade> allGrades = otherData.GetAllGrades();

            foreach (Grade grade in allGrades)
            {
                if (subject.Id == grade.Subjectid && student.Id == grade.Studentid)
                {
                    this.grade = grade;
                }
            }

            if (grade == null)
            {
                gradeLabel.Text = "Jūsų dar neįvertino";
                dateLabel.Text = "Nėra";
            }
            else 
            {
                gradeLabel.Text = grade.grade.ToString();
                dateLabel.Text = grade.Date.ToString("yyyy-MM-dd");
            }
        }

    }
}
