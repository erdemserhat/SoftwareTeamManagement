using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.BusinessLogic.BaseDataModel.User
{
    public interface IUserContract
    {
        public void UpdateFullName(string fullName);
        public void UpdatePassword(string password);
        public void UpdateEmail(string email);

        public string FullNameInformation();
        public string PasswordInformation();
        public string EmailInformation();

        public int IdInformation();
  
    }
}
