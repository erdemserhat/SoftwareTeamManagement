using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.UI.ResetPassword.View
{
    public interface IForgotPasswordForm
    {
        event EventHandler SearchButtonClicked;
        event EventHandler GoBackLoginButtonClicked;
        event EventHandler ExitButtonClicked;

        string Email { get; }
    }
}
