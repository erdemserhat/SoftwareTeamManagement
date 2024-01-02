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
            return _data;
        }

        //use this function in case of logout...
        public static void Reset()
        {
            flag = 0;
        }



    }
}
