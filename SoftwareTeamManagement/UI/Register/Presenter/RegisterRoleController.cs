using SoftwareTeamManagement.BusinessLogic.BaseDataModel.TeamMember;
using SoftwareTeamManagement.BusinessLogic.Configuration.Roles;
using SoftwareTeamManagement.DataAccess.Repository;
using SoftwareTeamManagement.UI.CustomMessageBox;
using SoftwareTeamManagement.UI.Login.View;
using SoftwareTeamManagement.UI.Register.View;

namespace SoftwareTeamManagement.UI.Register.Presenter
{
    public class RegisterRoleController
    {
        private IRegisterRoleForm _view = RegisterRoleForm.GetInstance();

        public RegisterRoleController()
        {

            _view.NextButtonClicked += OnNextButtonClicked;
            _view.ExitButtonClicked += OnExitButtonClicked;


        }

        private void OnNextButtonClicked(object sender, EventArgs e)
        {
            if (AreStringsNullOrWhiteSpace(_view.Role, _view.Department))
            {

                string fullName = RegisterForm.GetInstance().fullName;
                string email = RegisterForm.GetInstance().email;
                string password = RegisterForm.GetInstance().password;
                string role = _view.Role;
                string department = _view.Department;

                TeamMember member = new TeamMember(fullName, email, password, new Role(role, department));
                TeamMemberRepository repo = new TeamMemberRepository();
                repo.AddTeamMember(member);


                LoginForm.GetInstance().Show();
                RegisterRoleForm.GetInstance().Hide();

                CustomSuccessMessageBoxForm messageBox = new CustomSuccessMessageBoxForm("You have successfully registered in our system. Welcome to Sprint Mate!");
                LoginForm.GetInstance().Email = email;
                LoginForm.GetInstance().Password = password;











            }
            else
            {
                CustomErrorMessageBoxForm messageBox = new CustomErrorMessageBoxForm("Please fill the fields.");
            }

        }

        private void OnExitButtonClicked(object sender, EventArgs e)
        {
            Application.Exit();

        }

        //controls

        public bool AreStringsNullOrWhiteSpace(string str1, string str2)
        {
            // Perform the checks
            if (string.IsNullOrWhiteSpace(str1) || string.IsNullOrWhiteSpace(str2))
            {
                // At least one string is empty or consists only of whitespaces
                return false;
            }
            else
            {
                // Both strings are non-empty and do not consist only of whitespaces
                return true;
            }


        }
    }
}
