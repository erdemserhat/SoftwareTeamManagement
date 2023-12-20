﻿using SoftwareTeamManagement.BusinessLogic.Role;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.BusinessLogic.BaseDataModel.TeamMember.TeamMemberContracts
{
    public interface ITeamMemberTaskContract
    {
        void AddTask(DataModel.Task.Task task);
        void DeleteTask(DataModel.Task.Task task);
        void UpdateTask(DataModel.Task.Task task);



    }
}
