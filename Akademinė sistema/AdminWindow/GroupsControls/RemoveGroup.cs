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
    public partial class RemoveGroup : UserControl
    {
        private NonUsersRepository data = new NonUsersRepository();
        private Group group;
        public RemoveGroup()
        {
            InitializeComponent();
        }
        public RemoveGroup(Group group)
        {
            InitializeComponent();
            this.group = group;
            nameLabel.Text = group.Name;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                data.RemoveGroup(group.Id);
                MessageBox.Show("Grupė pašalinta iš sistemos");
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
