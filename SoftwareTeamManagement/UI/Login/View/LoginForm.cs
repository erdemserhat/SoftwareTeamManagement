using SoftwareTeamManagement.UI.Login.Controller;

namespace SoftwareTeamManagement.UI.Login.View
{


    public partial class LoginForm : Form, ILoginForm
    {


        ///Singleton
        public static LoginForm? instance;


        public string Email { get => emailTextBox.Text; set => emailTextBox.Text = value; }
        public string Password { get => passwordTextBox.Text; set => passwordTextBox.Text = value; }

        public event EventHandler ExitButtonClicked;
        public event EventHandler RegisterButtonClicked;
        public event EventHandler LoginButtonClicked;
        public event EventHandler ForgotPasswordClicked;

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
            exitBtn.Click += (sender, e) => ExitButtonClicked?.Invoke(this, EventArgs.Empty);
            registerBtn.Click += (sender, e) => RegisterButtonClicked?.Invoke(this, EventArgs.Empty);
            loginBtn.Click += (sender, e) => LoginButtonClicked?.Invoke(this, EventArgs.Empty);
            forgotPasswordBtn.Click += (sender, e) => ForgotPasswordClicked?.Invoke(this, EventArgs.Empty);


            LoginController controller = new LoginController();


        }

    }




}
