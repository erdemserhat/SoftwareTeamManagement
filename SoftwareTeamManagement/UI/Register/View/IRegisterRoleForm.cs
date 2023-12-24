using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.UI.Register.View
{
    public interface  IRegisterRoleForm
    {
        string Role {  get; }
        string Department {  get; }

        event EventHandler NextButtonClicked;
        event EventHandler ExitButtonClicked;

    }
}
