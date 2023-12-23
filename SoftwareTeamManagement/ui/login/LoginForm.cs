using SoftwareTeamManagement.ui.register;
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


    public partial class LoginForm : Form
    {
        private System.Timers.Timer opacityTimer;

        ///Singleton
        private static LoginForm? instance;
        public static LoginForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new LoginForm();
            }
            return instance;
        }


        public LoginForm()
        {
            InitializeComponent();
            instance = this;

        }


        //exit button
        private void exitBtn_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //Handle login





        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            RegisterForm.GetInstance().Show();
            instance.Hide();
        }

        private void forgotPasswordBtn_Click(object sender, EventArgs e)
        {
            //when forget password is clicked handle the process.
            ForgotPasswordForm.GetInstance().Show();
            this.Hide();
        }
    }




}
