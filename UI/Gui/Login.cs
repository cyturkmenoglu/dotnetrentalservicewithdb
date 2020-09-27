using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using UI.Classes;

namespace UI
{
    public partial class Login : Form
    {
        LoginClass log = new LoginClass();
        RentAVehicleClass rav = new RentAVehicleClass();

        public Login()
        {
            InitializeComponent();
            log.getVehicles(VehicleNameBox);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (log.checkLogin(EmailBox,PassBox) == 1)
            {
                RentAVehicle r = new RentAVehicle();
                r.Show();
                this.Hide();
                if (LoginClass.Urole == "Personel" || LoginClass.Urole == "Client")
                {
                    r.AdminButton.Enabled = false;
                }
            }
        }

        private void ForgotButton_Click(object sender, EventArgs e)
        {
            Forgot f = new Forgot();
            f.Show();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            SignUp su = new SignUp();
            su.Show();
        }

        private void VehicleNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {            
            log.changeVehicleLabels(VehicleNameBox, VehicleNameLabel, VehicleYearLabel, VehicleMileageLabel, VehicleColorLabel, VehicleTypeLabel, VehicleAvailabilityLabel, VehicleRatingLabel);
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            rav.search(VehicleNameBox, SearchBox);
        }
    }
}
