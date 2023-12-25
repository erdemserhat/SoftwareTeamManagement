using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.UI.ResetPassword.View
{
    public interface IForgotPasswordAuthenticationForm
    {
        public string Code {  get; }
        event EventHandler ConfirmButtonClicked;
        event EventHandler GoBackLoginClicked;
        event EventHandler ExitButtonClicked;
    
    }
}
