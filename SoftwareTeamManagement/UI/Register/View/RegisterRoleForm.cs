using SoftwareTeamManagement.UI.Register.Presenter;

namespace SoftwareTeamManagement.UI.Register.View
{
    public partial class RegisterRoleForm : Form, IRegisterRoleForm
    {


        private static RegisterRoleForm instance;

        public event EventHandler NextButtonClicked;
        public event EventHandler ExitButtonClicked;

        public string Role => roleTextBox.Text;
        public string Department => departmentTextBox.Text;

        public RegisterRoleForm()
        {
            InitializeComponent();
            instance = this;

            RegisterRoleController controller = new RegisterRoleController();

            nextBtn.Click += (sender, e) => NextButtonClicked?.Invoke(this, EventArgs.Empty);
            exitBtn.Click += (sender, e) => ExitButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        public static RegisterRoleForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new RegisterRoleForm();
            }
            return instance;
        }
    }
}
