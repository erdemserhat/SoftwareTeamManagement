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
    public partial class RegisterRoleForm : Form
    {
        public RegisterRoleForm()
        {
            InitializeComponent();
            instance = this;
        }

        private static RegisterRoleForm instance;

        public static RegisterRoleForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new RegisterRoleForm();
            }
            return instance;

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
