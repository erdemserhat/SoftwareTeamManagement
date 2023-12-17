using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.BusinessLogic.BaseDataModel.User
{
    abstract public class User:IUserContract
    {
        //Attributes for User base class
        private string fullName;
        private string email;
        private string password;
        private int id;

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

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int IdInformation()
        {
            return Id;
        }

        public string PasswordInformation()
        {
            return Password;
        }

        public void UpdateEmail(string email)
        {
            Email = email;
        }

        public void UpdateFullName(string fullName)
        {
            FullName = fullName;
        }

        public void UpdatePassword(string password)
        {
            Password = password;
        }
    }
}
