using SoftwareTeamManagement.UI.Register.View;
using SoftwareTeamManagement.UI.ResetPassword.View;

namespace SoftwareTeamManagement.UI.Login.View
{


    public partial class LoginForm : Form
    {
       

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
