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
    public partial class ResetPasswordForm : Form
    {
        private static ResetPasswordForm? instance;

        public static ResetPasswordForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ResetPasswordForm();
            }
            return instance;
        }
        public ResetPasswordForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetPasswordButton_Click(object sender, EventArgs e)
        {
            //handle process

            ////.....
            ///
            //
            LoginForm.GetInstance().Show();
            this.Hide();

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            LoginForm.GetInstance().Show();
            this.Hide();
        }
    }
}
