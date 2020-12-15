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
    public partial class AddSubjectControl : UserControl
    {
        private NonUsersRepository otherData = new NonUsersRepository();
        public AddSubjectControl()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (titleBox.Text.Trim(' ').Equals(""))
                    throw new Exception("Dėstomo dalyko pavadinimas negali būti tusčias");

                List<Subject> subjectsList = otherData.GetAllSubjects();
                foreach (Subject subject in subjectsList)
                {
                    if (subject.Title == titleBox.Text)
                    throw new Exception("Jau egzistuoja toks dėstomas dalykas");
                }
                otherData.AddNewSubject(titleBox.Text, descriptionBox.Text);
                MessageBox.Show("Sėkmingai pridėjote naują dėstomą dalyką");

                titleBox.Clear();
                descriptionBox.Clear();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
