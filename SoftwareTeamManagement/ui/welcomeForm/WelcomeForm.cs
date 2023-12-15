using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTeamManagement.view.welcomeForm
{
    public partial class WelcomeForm : Form
    {
        private string signUpMail;
        public WelcomeForm()
        {
            InitializeComponent();
            WelcomeFormSignUpButton.FlatStyle = FlatStyle.Flat;
            WelcomeFormSignUpButton.FlatAppearance.BorderSize = 0;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
           



        }

        private void welcomeFormLoginButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void WelcomeFormSignUpButton_Click(object sender, EventArgs e)
        {


        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
