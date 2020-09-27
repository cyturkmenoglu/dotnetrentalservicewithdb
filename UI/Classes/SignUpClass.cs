using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Classes
{
    class SignUpClass
    {

        SqlConnection conn = new SqlConnection(Connection.conn);
        SqlCommand cmd;

        public void insertUser(TextBox id, TextBox pn, TextBox name, TextBox lastname, TextBox email, TextBox password,NumericUpDown age,ComboBox type)
        {
            cmd = new SqlCommand("INSERT INTO Users(ID, email, username, lastname, age, phonenumber, pass, userrole) VALUES("+id.Text+", '"+email.Text + "', '" + name.Text + "', '" + lastname.Text + "', "+age.Text + ", '" + pn.Text + "', '" + password.Text + "', '" + type.Text + "')", conn);
            try
            {
                conn.Open();
                cmd.ExecuteReader();
                conn.Close();
                MessageBox.Show("Succesfully Signed Up", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Invalid", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
