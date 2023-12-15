﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.bussiness.baseDataModel.user
{
    public interface IUserContract
    {
        public void UpdateFullName(string fullName);
        public void UpdatePassword(string password);

        public string FullNameInformation();
        public string PasswordInformation();
        public string EmailInformation();
    }
}
