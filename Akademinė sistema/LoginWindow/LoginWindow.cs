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
    public partial class LoginWindow : Form
    {
        private UsersRepository repository = new UsersRepository();
        public static Student LoggedInStudent;
        public static Professor LoggedInProfessor;
        public static Admin LoggedInAdmin;
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (repository.StudentLogin(usernameBox.Text, passwordBox.Text) != null)
                {
                    LoggedInStudent = repository.StudentLogin(usernameBox.Text, passwordBox.Text);
                    StudentWindow s = new StudentWindow();
                    s.ShowDialog();
                }
                else if (repository.ProfessorLogin(usernameBox.Text, passwordBox.Text) != null)
                {
                    LoggedInProfessor = repository.ProfessorLogin(usernameBox.Text, passwordBox.Text);
                    ProfessorWindow p = new ProfessorWindow();
                    p.ShowDialog();
                }
                else if (repository.AdminLogin(usernameBox.Text, passwordBox.Text) != null)
                {
                    LoggedInAdmin = repository.AdminLogin(usernameBox.Text, passwordBox.Text);
                    AdminWindow a = new AdminWindow();
                    a.ShowDialog();
                }
                else
                    throw new Exception("Toks naudotojas nerastas");
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
