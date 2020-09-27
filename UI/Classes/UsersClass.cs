using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Classes
{
    class UsersClass
    {
        SqlConnection conn = new SqlConnection(Connection.conn);
        SqlCommand cmd;
        SqlDataReader reader;

        public void getUsers(ComboBox box)
        {
            cmd = new SqlCommand("SELECT username,lastname,email FROM Users ORDER BY username ASC", conn);
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String name = reader["username"].ToString();
                    String lastname = reader["lastname"].ToString();
                    String email = reader["email"].ToString();
                    box.Items.Add(name + " " + lastname + " " + "("+email+")");
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

        public void changeUserLabels(ComboBox box, Label name, Label lastname, Label email, Label pn,Label rv)
        {
            int index1 = box.Text.IndexOf('(');
            int index2 = box.Text.IndexOf(')');
            String em = box.Text.Substring(index1+1, index2-index1-1);
            cmd = new SqlCommand("SELECT username,lastname,email,phonenumber,takenid FROM Users WHERE email ='"+em+"'", conn);

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String Uname = reader["username"].ToString();
                    String Ulastname = reader["lastname"].ToString();
                    String Uemail = reader["email"].ToString();
                    String Uphonenumber = reader["phonenumber"].ToString();
                    String Utakenid = reader["takenid"].ToString();

                    if (Utakenid.Equals(""))
                    {
                        Utakenid = "None";
                    }

                    name.Text = Uname;
                    lastname.Text = Ulastname;
                    email.Text = Uemail;
                    pn.Text = Uphonenumber;
                    rv.Text = Utakenid;
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

        public void deleteUser(ComboBox box)
        {
            try
            {
                conn.Open();
                int index1 = box.Text.IndexOf('(');
                int index2 = box.Text.IndexOf(')');
                String em = box.Text.Substring(index1 + 1, index2 - index1 - 1);

                SqlCommand cmdcheck = new SqlCommand("SELECT takenid FROM Users WHERE email = '" + em + "'", conn);
                if (cmdcheck.ExecuteScalar().ToString() != "")
                {
                    throw new Exception();
                }
                cmd = new SqlCommand("DELETE FROM Users WHERE email ='" + em + "'", conn);
                reader = cmd.ExecuteReader();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Invalid", "Users", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
