using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace UI.Classes
{
    public class ForgotClass
    {
        public String email { get; set; }
        public String pass { get; set; }

        SqlConnection conn = new SqlConnection(Connection.conn);
        SqlCommand cmd;
        SqlCommand cmdcheck;
        SqlDataReader reader;

            public void getID(TextBox box)
            {
            try
            {
                int id = int.Parse(box.Text);
                cmd = new SqlCommand("SELECT email,pass FROM Users WHERE ID = " + id+"", conn);
                cmdcheck = new SqlCommand("SELECT email FROM Users WHERE ID = " + id + "", conn);
                    conn.Open();                
                if (cmdcheck.ExecuteScalar()==null)
                {
                    throw new Exception();
                }
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        email = reader["email"].ToString();
                        pass = reader["pass"].ToString();
                    }
                    conn.Close();
                    MessageBox.Show("Email:" + email + " Password: " + pass + "", "Forgot", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                catch
                {
                MessageBox.Show("Invalid", "Forgot", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                finally
                {
                    conn.Close();
                }

            }
        }
    }

