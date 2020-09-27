using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Classes;

namespace UI
{
    public partial class RentAVehicle : Form
    {
        LoginClass log = new LoginClass();
        RentAVehicleClass rav = new RentAVehicleClass();

        SqlConnection conn = new SqlConnection(Connection.conn);
        SqlCommand cmd;
        public RentAVehicle()
        {
            InitializeComponent();
            log.getVehicles(VehicleNameBox);
            rav.getTypes(TypeBox);
        }

        private void RentAVehicle_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VehicleNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            log.changeVehicleLabels(VehicleNameBox,VehicleNameLabel,VehicleYearLabel,VehicleMileageLabel,VehicleColorLabel,VehicleTypeLabel, VehicleAvailabilityLabel,VehicleRatingLabel);
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            ap.Show();
        }

        private void DeleteAccountButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do You Want To Remove This Account", "Remove Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (rav.deleteAccount() == 1)
                {
                    Login l = new Login();
                    l.Show();
                    List<Form> openForms = new List<Form>();

                    foreach (Form f in Application.OpenForms)
                        openForms.Add(f);

                    for (int i = 0; i < openForms.Count; i++)
                    {
                        if (openForms[i].Name != "Login")
                            openForms[i].Dispose();
                    }
                }
            }
        }

        private void DismissVehicleButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do You Want To Dismiss Your Vehicle", "Dismiss Vehicle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                if (LoginClass.Urole == "Client")
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmdcheck = new SqlCommand("SELECT takenid FROM Users WHERE email = '" + LoginClass.Uemail + "'", conn);
                        if (cmdcheck.ExecuteScalar().ToString() == "")
                        {
                            throw new Exception();
                        }
                        cmd = new SqlCommand("UPDATE Users SET takenid = NULL WHERE email = '" + LoginClass.Uemail + "'", conn);
                        SqlCommand cmdinc = new SqlCommand("UPDATE Vehicles SET takenamount = takenamount + 1,taken = 0 WHERE VID = (SELECT takenid FROM Users WHERE email ='" + LoginClass.Uemail + "')", conn);
                        cmdinc.ExecuteReader();
                        conn.Close();

                        conn.Open();
                        cmd.ExecuteReader();
                        conn.Close();

                        VehicleAvailabilityLabel.Text = "Available";
                        MessageBox.Show("Dismissed", "Dismiss A Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        String rating = Interaction.InputBox("Rate THe Vehicle", "Dismiss A Vehicle", "", 100, 100);
                        if(rating != "")
                        {
                            conn.Open();
                            conn.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Invalid", "Dismiss A Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {
                    String email = Interaction.InputBox("Enter Client Email Adress", "Dismiss A Vehicle", "", this.Left + (this.Width / 2) - 185, this.Top + (this.Height / 2) - 110);
                    if (email != "")
                    {
                        try
                        {
                            conn.Open();
                            SqlCommand cmdcheck = new SqlCommand("SELECT takenid FROM Users WHERE email = '" + email + "'", conn);
                            if (cmdcheck.ExecuteScalar().ToString() == "")
                            {
                                throw new Exception();
                            }
                            cmd = new SqlCommand("UPDATE Users SET takenid = NULL WHERE email = '" + email + "'", conn);
                            SqlCommand cmdinc = new SqlCommand("UPDATE Vehicles SET takenamount = takenamount + 1,taken = 0 WHERE VID = (SELECT takenid FROM Users WHERE email ='" + email + "')", conn);
                            SqlCommand cmdid = new SqlCommand("SELECT takenid FROM Users WHERE email = '" + email + "'", conn);
                            conn.Close();

                            conn.Open();
                            String ids = cmdid.ExecuteScalar().ToString();
                            int id = int.Parse(ids);
                            conn.Close();

                            conn.Open();
                            cmdinc.ExecuteReader();
                            conn.Close();

                            conn.Open();
                            cmd.ExecuteReader();
                            conn.Close();

                            VehicleAvailabilityLabel.Text = "Available";
                            MessageBox.Show("Dismissed", "Dismiss A Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            String rating = Interaction.InputBox("Please Rate The Vehicle 0-5", "Dismiss A Vehicle", "", this.Left + (this.Width / 2) - 185, this.Top + (this.Height / 2) - 110);
                            if(rating != "")
                            {
                                if(int.Parse(rating) < 0)
                                {
                                    rating = "0";
                                }
                                if (int.Parse(rating) > 5)
                                {
                                    rating = "5";
                                }
                                conn.Open();
                                SqlCommand cmdrate = new SqlCommand("UPDATE Vehicles SET rating = (SELECT ROUND((((SUM(rating)* ((SELECT takenamount FROM Vehicles WHERE VID = "+id+")-1))+"+int.Parse(rating)+")/(SELECT takenamount FROM Vehicles WHERE VID = "+id+")),2) FROM Vehicles WHERE VID = "+id+") WHERE VID = "+id+";", conn);
                                cmdrate.ExecuteReader();
                                MessageBox.Show("Your Rating To This Vehicle Is " + rating + " Thank You For Using Horse Rental", "Rating", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                conn.Close();

                                conn.Open();
                                SqlCommand cmdr = new SqlCommand("SELECT rating FROM Vehicles WHERE VID =" + id + "", conn);
                                VehicleRatingLabel.Text = cmdr.ExecuteScalar().ToString();
                                conn.Close();
                            }
                            else
                            {
                                rating = "3";
                                conn.Open();
                                SqlCommand cmdrate = new SqlCommand("UPDATE Vehicles SET rating = (SELECT ROUND((((SUM(rating)* ((SELECT takenamount FROM Vehicles WHERE VID = " + id + ")-1))+" + int.Parse(rating) + ")/(SELECT takenamount FROM Vehicles WHERE VID = " + id + ")),2) FROM Vehicles WHERE VID = " + id + ") WHERE VID = " + id + ";", conn);
                                cmdrate.ExecuteReader();
                                conn.Close();

                                conn.Open();
                                SqlCommand cmdr = new SqlCommand("SELECT rating FROM Vehicles WHERE VID ="+id+"", conn);
                                VehicleRatingLabel.Text = cmdr.ExecuteScalar().ToString();
                                conn.Close();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Invalid", "Dismiss A Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
            }
        }

        private void RentVehicleButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want To Rent A Vehicle", "Rent Vehicle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (LoginClass.Urole == "Client")
                {
                    try
                    {
                        int index = VehicleNameBox.Text.IndexOf(')');
                        int vid = int.Parse(VehicleNameBox.Text.Substring(0, index));
                        conn.Open();
                        SqlCommand cmdcheck = new SqlCommand("SELECT takenid FROM Users WHERE email = '" + LoginClass.Uemail + "'", conn);
                        if ((cmdcheck.ExecuteScalar().ToString() != "") || (VehicleAvailabilityLabel.Text == "Not Available"))
                        {
                            throw new Exception();
                        }
                        cmd = new SqlCommand("UPDATE Users SET takenid = '" + vid + "' WHERE email = '" + LoginClass.Uemail + "'", conn);
                        cmd.ExecuteReader();
                        conn.Close();

                        conn.Open();
                        SqlCommand cmd2 = new SqlCommand("UPDATE Vehicles SET taken = 1 WHERE VID = '" + vid + "'", conn);
                        cmd2.ExecuteReader();
                        conn.Close();
                        VehicleAvailabilityLabel.Text = "Not Available";
                        MessageBox.Show("Rented", "Rent A Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Invalid", "Rent A Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {
                    String email = Interaction.InputBox("Enter Client Email Adress", "Rent A Vehicle", "", this.Left + (this.Width / 2) - 185, this.Top + (this.Height / 2) - 110);
                    if (email != "")
                    {
                        try
                        {
                            int index = VehicleNameBox.Text.IndexOf(')');
                            int vid = int.Parse(VehicleNameBox.Text.Substring(0, index));
                            conn.Open();
                            SqlCommand cmdcheck = new SqlCommand("SELECT takenid FROM Users WHERE email = '" + email + "'", conn);
                            if ((cmdcheck.ExecuteScalar().ToString() != "") || (VehicleAvailabilityLabel.Text == "Not Available"))
                            {
                                throw new Exception();
                            }
                            cmd = new SqlCommand("UPDATE Users SET takenid = '" + vid + "' WHERE email = '" + email + "'", conn);
                            cmd.ExecuteReader();
                            conn.Close();

                            conn.Open();
                            SqlCommand cmd2 = new SqlCommand("UPDATE Vehicles SET taken = 1 WHERE VID = '" + vid + "'", conn);
                            cmd2.ExecuteReader();
                            conn.Close();
                            VehicleAvailabilityLabel.Text = "Not Available";
                            MessageBox.Show("Rented", "Rent A Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Invalid", "Rent A Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
            }
        }
      
        private void LogoutLabel_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            for(int i = 0;i<openForms.Count;i++)
            {
                if (openForms[i].Name != "Login")
                    openForms[i].Dispose();
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            rav.search(VehicleNameBox, SearchBox);
        }

        private void AvailableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AvailableCheckBox.Checked == true)
            {
                rav.getAvailable(VehicleNameBox);
            }
            else
            {
                log.getVehicles(VehicleNameBox);
            }
        }

        private void TypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            rav.searchByType(VehicleNameBox, TypeBox);
        }

        public void ChangeList()
        {
            VehicleNameBox.Items.Clear();
        }
    }
}
