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
    public partial class AddNewGroup : UserControl
    {
        private NonUsersRepository otherData = new NonUsersRepository();
        public AddNewGroup()
        {
            InitializeComponent();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (groupBox.Text.Trim(' ').Equals(""))
                    throw new Exception("Grupės pavadinimas negali būti tusčias");

                List<Group> groupsList = otherData.GetAllGroups();
                foreach (Group group in groupsList)
                {
                    if (group.Name == groupBox.Text)
                        throw new Exception("Jau egzistuoja tokia grupe");
                }
                otherData.AddNewGroup(groupBox.Text);
                MessageBox.Show("Sėkmingai pridėjote naują grupę");

                groupBox.Clear();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
