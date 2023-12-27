namespace SoftwareTeamManagement.BusinessLogic.Configuration.Roles
{
    public enum RoleDepartment
    {
        Development,
        QualityAssurance,
        Devops,
        ProductManagement,
        UserExperience,
        ITInfrastructure,
        TechnicalSupport,
        ResearchDevelopment,
        DataScience,
        Marketing,
        Sales,
        TrainingEducation
    }

    public static class RoleDepartmentHelper
    {
        public static Dictionary<RoleDepartment, string> RoleDepartmentNames = new Dictionary<RoleDepartment, string>
        {
            { RoleDepartment.Development, "Development Department" },
            { RoleDepartment.QualityAssurance, "Quality Assurance Department" },
            { RoleDepartment.Devops, "DevOps Department" },
            { RoleDepartment.ProductManagement, "Product Management Department" },
            { RoleDepartment.UserExperience, "User Experience Department" },
            { RoleDepartment.ITInfrastructure, "IT Infrastructure Department" },
            { RoleDepartment.TechnicalSupport, "Technical Support Department" },
            { RoleDepartment.ResearchDevelopment, "Research and Development Department" },
            { RoleDepartment.DataScience, "Data Science Department" },
            { RoleDepartment.Marketing, "Marketing Department" },
            { RoleDepartment.Sales, "Sales Department" },
            { RoleDepartment.TrainingEducation, "Training and Education Department" }
        };

        public static string GetRoleDepartment(RoleDepartment roleDepartment)
        {
            return RoleDepartmentNames[roleDepartment];
        }

        public static RoleDepartment getTypeAsEnum(string department)
        {
            foreach (var entry in RoleDepartmentHelper.RoleDepartmentNames)
            {
                if (entry.Value.Equals(department, StringComparison.OrdinalIgnoreCase))
                {
                    return entry.Key;
                }
            }

            throw new ArgumentException("Cannot find specified department", nameof(department));
        }
    }
}
