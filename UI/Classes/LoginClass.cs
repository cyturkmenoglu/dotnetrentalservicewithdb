using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Classes
{
    class LoginClass
    {
        public static String Urole = null;
        public static String Uemail = null;

        SqlConnection conn = new SqlConnection(Connection.conn);
        SqlCommand cmd;
        SqlDataReader reader;

        public void getVehicles(ListBox box)
            {
            cmd = new SqlCommand("SELECT VID,name,vyear FROM Vehicles ORDER BY VID ASC",conn);
            try
            {
                conn.Open();
                box.Items.Clear();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String VID = reader["VID"].ToString();
                    String name = reader["name"].ToString();
                    String vyear = reader["vyear"].ToString();
                    box.Items.Add(VID+") "+name +" "+ vyear);
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

        public void changeVehicleLabels(ListBox box,Label vname, Label vyear, Label vmileage, Label vcolor, Label vtype, Label vavailability, Label vrating)
        {
            int index = box.Text.IndexOf(')');
            int vid = int.Parse(box.Text.Substring(0, index));
            cmd = new SqlCommand("SELECT name,vyear,mileage,color,vtype,rating,taken FROM Vehicles WHERE VID ="+vid+"", conn);

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
                    String Vavailability = reader["taken"].ToString();
                    String Vrating = reader["rating"].ToString();

                    if (int.Parse(Vavailability) == 0)
                    {
                        Vavailability = "Available";
                    }
                    else
                    {
                        Vavailability = "Not Available";
                    }
                    vname.Text = Vname;
                    vyear.Text = Vyear;
                    vmileage.Text = Vmileage;
                    vcolor.Text = Vcolor;
                    vtype.Text = Vtype;
                    vavailability.Text = Vavailability;
                    vrating.Text = Vrating;
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

        public int checkLogin(TextBox email, TextBox pass)
        {
            String Upass=null;

            try
            {
                cmd = new SqlCommand("SELECT email,pass,userrole FROM Users WHERE email ='" + email.Text + "'", conn);
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Uemail = reader["email"].ToString();
                    Upass = reader["pass"].ToString();
                    Urole = reader["userrole"].ToString();
                }
                conn.Close();
                if (Upass == pass.Text)
                {
                    return 1;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Invalid", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }
    }
    }
