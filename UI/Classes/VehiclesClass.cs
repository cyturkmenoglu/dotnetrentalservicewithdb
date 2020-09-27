using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Classes
{
    class VehiclesClass
    {
        SqlConnection conn = new SqlConnection(Connection.conn);
        SqlCommand cmd;
        SqlDataReader reader;

        LoginClass log = new LoginClass();
        public void getVehicles(ComboBox box)
        {
            cmd = new SqlCommand("SELECT VID,name,vyear FROM Vehicles ORDER BY VID ASC", conn);
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String vid = reader["VID"].ToString();
                    String name = reader["name"].ToString();
                    String vyear = reader["vyear"].ToString();
                    box.Items.Add(vid + ") " + name + " " + vyear);
                }
                conn.Close();
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }

        public void changeVehicleLabels(ComboBox box, Label name, Label year, Label mileage, Label color, Label type)
        {
            int index = box.Text.IndexOf(')');
            int vid = int.Parse(box.Text.Substring(0, index));
            cmd = new SqlCommand("SELECT name,vyear,mileage,color,vtype FROM Vehicles WHERE VID =" + vid + "", conn);

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String Vname = reader["name"].ToString();
                    String Vyear = reader["vyear"].ToString();
                    String Vmileage = reader["mileage"].ToString();
                    String Vcolor = reader["color"].ToString();
                    String Vtype = reader["vtype"].ToString();

                    name.Text = Vname;
                    year.Text = Vyear;
                    mileage.Text = Vmileage;
                    color.Text = Vcolor;
                    type.Text = Vtype;
                }
                conn.Close();
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }

        public void deleteVehicle(ComboBox box)
        {
            try
            {
                int index = box.Text.IndexOf(')');
                int vid = int.Parse(box.Text.Substring(0, index));
                cmd = new SqlCommand("DELETE FROM Vehicles WHERE VID ='" + vid + "'", conn); 
                conn.Open();
                reader = cmd.ExecuteReader();
                conn.Close();
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }

        public void insertVehicle(TextBox vname, NumericUpDown year, NumericUpDown mileage, TextBox color, TextBox vtype)
        {
            int vidnum = 1,i=0,check =0,cont = 0,count=1;
            SqlCommand cmdnum = new SqlCommand("SELECT COUNT(*) FROM Vehicles", conn);
            SqlCommand cmdcheck = new SqlCommand("SELECT VID FROM Vehicles", conn);
            try
            {
                conn.Open();
                i = (int)cmdnum.ExecuteScalar();
                reader = cmdcheck.ExecuteReader();

                    while (reader.Read())
                    {
                        check = int.Parse(reader["VID"].ToString());
                        if(count != check)
                        {
                            vidnum = count;
                            cont = 1;
                            break;
                        }
                        count++;
                    }
                    if(cont == 0)
                {
                    vidnum = i + 1;
                }
                conn.Close();
                conn.Open();
                cmd = new SqlCommand("INSERT INTO Vehicles(VID, name, vyear, mileage, color, vtype, taken, takenamount) VALUES(" + vidnum + ", '" + vname.Text + "', " + year.Text + ", " + mileage.Text + ", '" + color.Text + "', '" + vtype.Text + "', 0, 0)", conn);
                cmd.ExecuteReader();
                conn.Close();
                MessageBox.Show("Succesfully Added Vehicle", "Vehicles", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
}
