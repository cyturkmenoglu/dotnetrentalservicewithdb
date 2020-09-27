using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void ViewUsersButton_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            u.Show();

        }

        private void VehiclesButton_Click(object sender, EventArgs e)
        {
            Vehicles v = new Vehicles();
            v.Show();
        }
    }
}
