using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_DataAccess
{
    public partial class ChallengeForn : Form
    {
        BindingList<UserModel> users = new BindingList<UserModel>();
        public ChallengeForn()
        {
            InitializeComponent();
        }

        private void loadListFromFile()
        {
            //
        }

        private void WireUpDropDown()
        {
            usersListBox.DataSource = users;
            usersListBox.Displaymember = nameof(UserModel.Displaytext);
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {

        }
    }
}
