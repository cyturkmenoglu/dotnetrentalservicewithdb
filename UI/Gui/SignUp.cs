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
    public partial class SignUp : Form
    {
        SignUpClass su = new SignUpClass();
        public SignUp()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            su.insertUser(IDBox, PhoneNumberBox, NameBox, LastnameBox, EmailBox, PasswordBox, AgeBox, AccountTypeBox);
        }
    }
}
