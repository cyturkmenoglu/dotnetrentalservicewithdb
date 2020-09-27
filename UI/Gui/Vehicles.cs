using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Classes;

namespace UI
{
    public partial class Vehicles : Form
    {

        SqlConnection conn = new SqlConnection(Connection.conn);
        SqlCommand cmd;

        VehiclesClass vc = new VehiclesClass();
        LoginClass log = new LoginClass();

        public Vehicles()
        {
            InitializeComponent();
            vc.getVehicles(TypeBox);
        }


        private void VehicleNameLabel_Click(object sender, EventArgs e)
        {
            String name = Interaction.InputBox("Enter New Name", "Update Name", "", this.Left + (this.Width / 2) - 185, this.Top + (this.Height / 2) - 110);
            if ( name != "")
            {
                try
                {
                    int index = TypeBox.Text.IndexOf(')');
                    int vid = int.Parse(TypeBox.Text.Substring(0, index));
                    cmd = new SqlCommand("UPDATE Vehicles SET name = '" +name+ "' WHERE VID = '"+vid+"'", conn);
                    conn.Open();
                    cmd.ExecuteReader();
                    conn.Close();
                    TypeBox.Items.Clear();
                    TypeBox.Text = "--Choose--";
                    VehicleNameLabel.Text = "Vehicle Name";
                    VehicleYearLabel.Text = "Vehicle Year";
                    VehicleMileageLabel.Text = "Vehicle Mileage";
                    VehicleColorLabel.Text = "Vehicle Color";
                    VehicleTypeLabel.Text = "Vehicle Type";
                    vc.getVehicles(TypeBox);
                    MessageBox.Show("Changed", "Vehicles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Invalid", "Vehicles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void VehicleYearLabel_Click(object sender, EventArgs e)
        {
            String year = Interaction.InputBox("Enter New Year", "Update Year", "", this.Left + (this.Width / 2) - 185, this.Top + (this.Height / 2) - 110);
            if (year != "" && int.Parse(year) >= 1886 && int.Parse(year) <= 4000)
            {
                try
                {
                    int index = TypeBox.Text.IndexOf(')');
                    int vid = int.Parse(TypeBox.Text.Substring(0, index));
                    cmd = new SqlCommand("UPDATE Vehicles SET vyear = '" + year + "' WHERE VID = '" + vid + "'", conn);
                    conn.Open();
                    cmd.ExecuteReader();
                    conn.Close();
                    TypeBox.Items.Clear();
                    TypeBox.Text = "--Choose--";
                    VehicleNameLabel.Text = "Vehicle Name";
                    VehicleYearLabel.Text = "Vehicle Year";
                    VehicleMileageLabel.Text = "Vehicle Mileage";
                    VehicleColorLabel.Text = "Vehicle Color";
                    VehicleTypeLabel.Text = "Vehicle Type";
                    vc.getVehicles(TypeBox);
                    MessageBox.Show("Changed", "Vehicles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Invalid", "Vehicles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void VehicleMileageLabel_Click(object sender, EventArgs e)
        {
            String mileage = Interaction.InputBox("Enter New Mileage", "Update Mileage", "", this.Left + (this.Width / 2) - 185, this.Top + (this.Height / 2) - 110);
            if (mileage != "" && int.Parse(mileage) >= 0 && int.Parse(mileage) <= 2000000)
            {
                try
                {
                    int index = TypeBox.Text.IndexOf(')');
                    int vid = int.Parse(TypeBox.Text.Substring(0, index));
                    cmd = new SqlCommand("UPDATE Vehicles SET mileage = '" + mileage + "' WHERE VID = '" + vid + "'", conn);
                    conn.Open();
                    cmd.ExecuteReader();
                    conn.Close();
                    TypeBox.Items.Clear();
                    TypeBox.Text = "--Choose--";
                    VehicleNameLabel.Text = "Vehicle Name";
                    VehicleYearLabel.Text = "Vehicle Year";
                    VehicleMileageLabel.Text = "Vehicle Mileage";
                    VehicleColorLabel.Text = "Vehicle Color";
                    VehicleTypeLabel.Text = "Vehicle Type";
                    vc.getVehicles(TypeBox);
                    MessageBox.Show("Changed", "Vehicles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Invalid", "Vehicles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void VehicleTypeLabel_Click(object sender, EventArgs e)
        {
            String type = Interaction.InputBox("Enter New Type", "Update Type", "", this.Left + (this.Width / 2) - 185, this.Top + (this.Height / 2) - 110);
            if (type != "")
            {
                try
                {
                    int index = TypeBox.Text.IndexOf(')');
                    int vid = int.Parse(TypeBox.Text.Substring(0, index));
                    cmd = new SqlCommand("UPDATE Vehicles SET vtype = '" + type + "' WHERE VID = '" + vid + "'", conn);
                    conn.Open();
                    cmd.ExecuteReader();
                    conn.Close();
                    TypeBox.Items.Clear();
                    TypeBox.Text = "--Choose--";
                    VehicleNameLabel.Text = "Vehicle Name";
                    VehicleYearLabel.Text = "Vehicle Year";
                    VehicleMileageLabel.Text = "Vehicle Mileage";
                    VehicleColorLabel.Text = "Vehicle Color";
                    VehicleTypeLabel.Text = "Vehicle Type";
                    vc.getVehicles(TypeBox);
                    MessageBox.Show("Changed", "Vehicles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Invalid", "Vehicles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void VehicleColorLabel_Click(object sender, EventArgs e)
        {
            String color = Interaction.InputBox("Enter New Color", "Update Color", "", this.Left + (this.Width / 2) - 185, this.Top + (this.Height / 2) - 110);
            if (color != "")
            {
                try
                {
                    int index = TypeBox.Text.IndexOf(')');
                    int vid = int.Parse(TypeBox.Text.Substring(0, index));
                    cmd = new SqlCommand("UPDATE Vehicles SET color = '" + color + "' WHERE VID = '" + vid + "'", conn);
                    conn.Open();
                    cmd.ExecuteReader();
                    conn.Close();
                    TypeBox.Items.Clear();
                    TypeBox.Text = "--Choose--";
                    VehicleNameLabel.Text = "Vehicle Name";
                    VehicleYearLabel.Text = "Vehicle Year";
                    VehicleMileageLabel.Text = "Vehicle Mileage";
                    VehicleColorLabel.Text = "Vehicle Color";
                    VehicleTypeLabel.Text = "Vehicle Type";
                    vc.getVehicles(TypeBox);
                    MessageBox.Show("Changed", "Vehicles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Invalid", "Vehicles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want To Remove This Vehicle", "Remove Vehicle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                vc.deleteVehicle(TypeBox);
                TypeBox.Items.Clear();
                TypeBox.Text = "--Choose--";
                VehicleNameLabel.Text = "Vehicle Name";
                VehicleYearLabel.Text = "Vehicle Year";
                VehicleMileageLabel.Text = "Vehicle Mileage";
                VehicleColorLabel.Text = "Vehicle Color";
                VehicleTypeLabel.Text = "Vehicle Type";
                vc.getVehicles(TypeBox);

                List<Form> openForms = new List<Form>();

                foreach (Form f in Application.OpenForms)
                    openForms.Add(f);

                for (int i = 0; i < openForms.Count; i++)
                {
                    if (openForms[i].Name == "RentAVehicle")
                    {
                        ListBox box = (ListBox)openForms[i].Controls.Find("VehicleNameBox", true).FirstOrDefault();
                        box.Items.Clear();
                        log.getVehicles(box);
                    }
                }
            }
        }

        private void TypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            vc.changeVehicleLabels(TypeBox, VehicleNameLabel, VehicleYearLabel,VehicleMileageLabel, VehicleColorLabel, VehicleTypeLabel);
        }

        public void AddButton_Click(object sender, EventArgs e)
        {
            vc.insertVehicle(NameBox, YearBox, mileagebox, Colorbox, addtypebox);
            TypeBox.Items.Clear();
            vc.getVehicles(TypeBox);

            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
            openForms.Add(f);

            for (int i = 0; i < openForms.Count; i++)
            {
                if (openForms[i].Name == "RentAVehicle") { 
                ListBox box = (ListBox)openForms[i].Controls.Find("VehicleNameBox", true).FirstOrDefault();
                box.Items.Clear();
                log.getVehicles(box);
                }
            }
        }
    }
}
