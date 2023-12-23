using SoftwareTeamManagement.ui.login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTeamManagement.ui.register
{
    public partial class RegisterForm : Form
    {
        private static RegisterForm instance;

        public static RegisterForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new RegisterForm();
            }
            return instance;
        }
        public RegisterForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goBackToLoginBtn_Click(object sender, EventArgs e)
        {
            LoginForm.GetInstance().Show();
            instance.Hide();



        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            /// handle controls
            /// 
            RegisterRoleForm.GetInstance().Show();
            this.Hide();

            
        }

    }
}
