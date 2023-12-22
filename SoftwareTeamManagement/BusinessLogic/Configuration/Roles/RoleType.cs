using System;
using System.Collections.Generic;

namespace SoftwareTeamManagement.BusinessLogic.Configuration.Roles
{
    public enum RoleType
    {
        SoftwareEngineer,
        TeamLeader,
        FrontendEngineer,
        BackendEngineer,
        FullStackEngineer,
        DevOpsEngineer,
        SystemArchitect,
        DatabaseAdministrator,
        QAEngineer,
        SecurityEngineer,
        UIDeveloper,
        UXDesigner,
        TechnicalWriter,
        CloudEngineer,
        MachineLearningEngineer,
        DataEngineer,
        SiteReliabilityEngineer,
        NetworkEngineer,
        ApplicationSupportEngineer,
        ReleaseManager,
        SoftwareProjectManager,
        AgileCoach
    }

    public static class RoleTypeHelper
    {
        private static Dictionary<RoleType, string> RoleTypeNames = new Dictionary<RoleType, string>
        {
            { RoleType.SoftwareEngineer, "Software Engineer" },
            { RoleType.FrontendEngineer, "Frontend Engineer" },
            { RoleType.BackendEngineer, "Backend Engineer" },
            { RoleType.FullStackEngineer, "Full Stack Engineer" },
            { RoleType.DevOpsEngineer, "DevOps Engineer" },
            { RoleType.SystemArchitect, "System Architect" },
            { RoleType.DatabaseAdministrator, "Database Administrator" },
            { RoleType.QAEngineer, "QA Engineer" },
            { RoleType.SecurityEngineer, "Security Engineer" },
            { RoleType.UIDeveloper, "UI Developer" },
            { RoleType.UXDesigner, "UX Designer" },
            { RoleType.TechnicalWriter, "Technical Writer" },
            { RoleType.CloudEngineer, "Cloud Engineer" },
            { RoleType.MachineLearningEngineer, "Machine Learning Engineer" },
            { RoleType.DataEngineer, "Data Engineer" },
            { RoleType.SiteReliabilityEngineer, "Site Reliability Engineer" },
            { RoleType.NetworkEngineer, "Network Engineer" },
            { RoleType.ApplicationSupportEngineer, "Application Support Engineer" },
            { RoleType.ReleaseManager, "Release Manager" },
            { RoleType.SoftwareProjectManager, "Software Project Manager" },
            { RoleType.AgileCoach, "Agile Coach" }
        };

        public static string GetRoleName(RoleType roleType)
        {
            return RoleTypeNames[roleType];
        }
        public static RoleType getTypeAsEnum(string type)
        {
            foreach (var entry in RoleTypeNames)
            {
                if (entry.Value.Equals(type, StringComparison.OrdinalIgnoreCase))
                {
                    return entry.Key;
                }
            }

            throw new ArgumentException("Belirtilen role tipi bulunamadı.", nameof(type));
        }
    }
}

//how to use this class make read in case of need

//RoleType selectedRole = RoleType.SoftwareEngineer;
//string roleName = RoleTypeHelper.GetRoleName(selectedRole);
//Console.WriteLine("Selected role: " + roleName);

