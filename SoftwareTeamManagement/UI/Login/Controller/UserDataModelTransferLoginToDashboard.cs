using SoftwareTeamManagement.UI.CustomMessageBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.UI.Login.Controller
{
    public static class UserDataModelTransferLoginToDashboard
    {
        private static string _data;
        private static int flag;
        public static void SetEmail(string email)
        {
            flag++;
            _data = email;
        }

        public static string GetEmail()
        {
            if (flag > 0)
            {
                return _data;
            }

            //throw new Exception("you must set the value before get");
            //for testing
            return "me.serhaterdem@gmail.com";
        }

        //use this function in case of logout...
        public static void  Reset()
        {
            flag = 0;
        }



    }
}
