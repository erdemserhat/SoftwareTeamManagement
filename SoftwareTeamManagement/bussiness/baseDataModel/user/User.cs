using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.bussiness.baseDataModel.user
{
    abstract public class User:IUserContract
    {
        //Attributes for User base class
        private string fullName;
        private string email;
        private string password;

        //Getters and Setters
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string EmailInformation()
        {
            return Email;
        }

        public string FullNameInformation()
        {
           return FullName;
        }

        public string PasswordInformation()
        {
            return Password;
        }

        public void UpdateFullName(string fullName)
        {
            this.fullName = fullName;
        }

        public void UpdatePassword(string password)
        {
            this.UpdatePassword(password);
        }
    }
}
