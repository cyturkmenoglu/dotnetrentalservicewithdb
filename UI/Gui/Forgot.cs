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
    public partial class Forgot : Form
    {
        ForgotClass forgot = new ForgotClass();
        public Forgot()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            forgot.getID(IDBox);
        }
    }
}
