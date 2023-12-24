using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.UI.Register.View
{
    public interface IRegisterForm
    {
        string Name { get; }
        string Email {  get; }
        string Password { get; }
        string ConfirmPassword {  get; }
        event EventHandler RegisterButtonClicked;
        event EventHandler GoBackButtonClicked;
        event EventHandler ExitButtonClicked;
    }
}
