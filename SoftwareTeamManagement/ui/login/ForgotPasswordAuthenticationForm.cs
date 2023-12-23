using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTeamManagement.ui.login
{
    public partial class ForgotPasswordAuthenticationForm : Form
    {
        private static ForgotPasswordAuthenticationForm? instance;

        public static ForgotPasswordAuthenticationForm? GetInstance()
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new ForgotPasswordAuthenticationForm();
              
            }
            return instance;
        }


        public ForgotPasswordAuthenticationForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void authenticationCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // controls the entered char if it's numeric or not
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goBackToLoginBtn_Paint(object sender, PaintEventArgs e)
        {
            LoginForm.GetInstance().Show();
            this.Hide();
        }
    }
}
