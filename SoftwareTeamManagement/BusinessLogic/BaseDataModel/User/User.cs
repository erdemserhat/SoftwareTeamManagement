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
        private string _fullName;
        private string _email;
        private string _password;
        private int _id;

        //Getters and Setters
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
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
            get { return _id; }
            set { _id = value; }
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
