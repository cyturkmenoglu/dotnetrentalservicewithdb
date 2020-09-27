using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Classes
{
    class RentAVehicleClass
    {
        SqlConnection conn = new SqlConnection(Connection.conn);
        SqlCommand cmd;
        SqlDataReader reader;

        public void getTypes(ComboBox box)
        {
            cmd = new SqlCommand("SELECT vtype FROM Vehicles GROUP BY vtype ORDER BY vtype ASC", conn);
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                box.Items.Add("All");
                while (reader.Read())
                {
                    String vtype = reader["vtype"].ToString();
                    box.Items.Add(vtype);
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

        public void search(ListBox box,TextBox tbox)
        {
            String keyword = tbox.Text;
            cmd = new SqlCommand("SELECT VID,name,vyear,mileage,color,vtype,rating,taken FROM Vehicles WHERE name LIKE '%"+keyword+ "%' OR vyear LIKE '%" + keyword + "%' OR mileage LIKE '%" + keyword + "%' OR color LIKE '%" + keyword + "%' OR rating LIKE '%" + keyword + "%'", conn);
            try
            {
                box.Items.Clear();
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String VID = reader["VID"].ToString();
                    String name = reader["name"].ToString();
                    String vyear = reader["vyear"].ToString();
                    box.Items.Add(VID + ") " + name + " " + vyear);
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

        public void getAvailable(ListBox box)
        {
            cmd = new SqlCommand("SELECT VID,name,vyear FROM Vehicles WHERE taken = 0 ORDER BY VID ASC", conn);
            try
            {
                box.Items.Clear();
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String VID = reader["VID"].ToString();
                    String name = reader["name"].ToString();
                    String vyear = reader["vyear"].ToString();
                    box.Items.Add(VID + ") " + name + " " + vyear);
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

        public void searchByType(ListBox box, ComboBox cbox)
        {
            String keyword = cbox.Text;
            if (keyword.Equals("All"))
            {
                cmd = new SqlCommand("SELECT VID,name,vyear FROM Vehicles", conn);
            }
            else
            {
                cmd = new SqlCommand("SELECT VID,name,vyear FROM Vehicles WHERE vtype = '" + keyword + "'", conn);
            }
            try
            {
                box.Items.Clear();
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String VID = reader["VID"].ToString();
                    String name = reader["name"].ToString();
                    String vyear = reader["vyear"].ToString();
                    box.Items.Add(VID + ") " + name + " " + vyear);
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

        public int deleteAccount()
        {
            try
            {
                cmd = new SqlCommand("DELETE FROM Users WHERE email ='" + LoginClass.Uemail + "'", conn);
                conn.Open();
                    SqlCommand cmdcheck = new SqlCommand("SELECT takenid FROM Users WHERE email = '" + LoginClass.Uemail + "'", conn);
                    if (cmdcheck.ExecuteScalar().ToString() != "")
                    {
                        throw new Exception();
                    }
                reader = cmd.ExecuteReader();
                conn.Close();
                return 1;
            }
            catch
            {
                MessageBox.Show("Invalid", "Rent A Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
