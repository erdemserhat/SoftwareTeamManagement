﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.BusinessLogic.DataModel.Team
{
    public interface ITeamContract
        {

        string Name { get; set; }
        string Description { get; set; }
        int Size { get; set; }
        BaseDataModel.TeamMember.TeamMember TeamLeader { get; set; }
        List<BaseDataModel.TeamMember.TeamMember> Members { get; set; }

        string Id {  get; set; }
    }
}
