﻿using System;
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
    public partial class ForgotPasswordForm : Form
    {
        public static ForgotPasswordForm instance;

        public static ForgotPasswordForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ForgotPasswordForm();
            }
            return instance;
        }
        public ForgotPasswordForm()
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
            this.Hide();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            ForgotPasswordAuthenticationForm.GetInstance().Show();
            this.Hide();

        }
    }
}
