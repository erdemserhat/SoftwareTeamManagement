namespace SoftwareTeamManagement.UI.Register.View
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
