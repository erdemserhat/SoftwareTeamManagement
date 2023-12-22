﻿using SoftwareTeamManagement.BusinessLogic.DataModel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.BusinessLogic.DataModel.Task
{
    public interface ITaskContract
    {
        string Title { get; set; }
        string Description { get; set; }
        string PriorityLevel { get; set; }
        DateTime CreatedTime { get; set; }

        string TaskCatagory {  get; set; }
        
        int Id {  get; set; }



    }
}
