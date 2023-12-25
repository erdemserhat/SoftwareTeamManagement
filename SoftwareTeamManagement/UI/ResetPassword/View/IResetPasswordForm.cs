using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.UI.ResetPassword.View
{
    public interface IResetPasswordForm
    {
        public string Password { get; }
        public string ConfirmPassowrd {  get; }

        public event EventHandler ResetPasswordClicked;
        public event EventHandler GoBackLoginButtonClicked;
        public event EventHandler ExitButtonClicked;
    }
}
