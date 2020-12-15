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
    public partial class RemoveSubject : UserControl
    {
        private NonUsersRepository data = new NonUsersRepository();
        private Subject subject;
        public RemoveSubject()
        {
            InitializeComponent();
        }
        public RemoveSubject(Subject subject)
        {
            InitializeComponent();
            this.subject = subject;
            titleLabel.Text = subject.Title;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                data.RemoveSubject(subject.Id);
                MessageBox.Show("Dėstomas dalykas pašalintas iš sistemos");
                foreach (Label l in this.Controls.OfType<Label>())
                {
                    l.Visible = false;
                }
                removeButton.Visible = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
