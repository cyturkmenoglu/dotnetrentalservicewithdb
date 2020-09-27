using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Classes;

namespace UI
{
    public partial class Users : Form
    {
        UsersClass uc = new UsersClass();
        public Users()
        {
            InitializeComponent();
            uc.getUsers(TypeBox);
        }

        private void RemoveButton_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want To Remove This User", "Remove User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                uc.deleteUser(TypeBox);
                TypeBox.Items.Clear();
                TypeBox.Text = "--Choose--";
                NameLabel.Text = "Name";
                LastnameLabel.Text = "Lastname";
                EmailLabel.Text = "Email";
                PhoneNumberLabel.Text = "Phone Number";
                uc.getUsers(TypeBox);
            }
        }

        private void TypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            uc.changeUserLabels(TypeBox,NameLabel, LastnameLabel, EmailLabel, PhoneNumberLabel,RentedVehicleLabel);
        }
    }
}
