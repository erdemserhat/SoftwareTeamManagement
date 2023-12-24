using SoftwareTeamManagement.UI.CustomMessageBox;
using SoftwareTeamManagement.UI.Register.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if(AreStringsNullOrWhiteSpace(_view.Role, _view.Department))
            {
                CustomSuccessMessageBoxForm messageBox = new CustomSuccessMessageBoxForm("Sucsess");

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
