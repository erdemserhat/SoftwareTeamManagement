using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.BusinessLogic.Role.Permissions.ProjectPermission
{
    public class ProjectPermissionSet: IProjectPermissionSetContract
    {
        // Properties
        private bool canChangeProjectName;
        private bool canUpdateDeadline;
        private bool canUpdateProjectDescription;
        private bool canAddMember;
        private bool canRemoveMember;
        private bool canResetMemberPassword;
        private bool canAnnounce;
        private bool canHoldMeeting;
        private bool canUpdateMemberPermissionSet;

        // Constructor
        public ProjectPermissionSet(
            bool changeProjectName,
            bool updateDeadline,
            bool updateProjectDescription,
            bool addMember,
            bool removeMember,
            bool resetMemberPassword,
            bool announce,
            bool holdMeeting,
            bool updateMemberPermissionSet)
        {
            this.canChangeProjectName = changeProjectName;
            this.canUpdateDeadline = updateDeadline;
            this.canUpdateProjectDescription = updateProjectDescription;
            this.canAddMember = addMember;
            this.canRemoveMember = removeMember;
            this.canResetMemberPassword = resetMemberPassword;
            this.canAnnounce = announce;
            this.canHoldMeeting = holdMeeting;
            this.canUpdateMemberPermissionSet = updateMemberPermissionSet;
        }

        // Getters and Setters
        public bool CanChangeProjectName
        {
            get { return canChangeProjectName; }
            set { canChangeProjectName = value; }
        }

        public bool CanUpdateDeadline
        {
            get { return canUpdateDeadline; }
            set { canUpdateDeadline = value; }
        }

        public bool CanUpdateProjectDescription
        {
            get { return canUpdateProjectDescription; }
            set { canUpdateProjectDescription = value; }
        }

        public bool CanAddMember
        {
            get { return canAddMember; }
            set { canAddMember = value; }
        }

        public bool CanRemoveMember
        {
            get { return canRemoveMember; }
            set { canRemoveMember = value; }
        }

        public bool CanResetMemberPassword
        {
            get { return canResetMemberPassword; }
            set { canResetMemberPassword = value; }
        }

        public bool CanAnnounce
        {
            get { return canAnnounce; }
            set { canAnnounce = value; }
        }

        public bool CanHoldMeeting
        {
            get { return canHoldMeeting; }
            set { canHoldMeeting = value; }
        }

        public bool CanUpdateMemberPermissionSet
        {
            get { return canUpdateMemberPermissionSet; }
            set { canUpdateMemberPermissionSet = value; }
        }

        //Implementations

        public bool CanAddMemberInformation()
        {

            return CanAddMember;
        }

        public bool CanAnnounceInformation()
        {
            return CanAnnounce;
        }

        public bool CanChangeProjectNameInformation()
        {
            return CanChangeProjectName;
        }

        public bool CanHoldMeetingInformation()
        {
            return CanHoldMeeting;
        }

        public bool CanRemoveMemberInformation()
        {
            return CanRemoveMember;
        }

        public bool CanResetMemberPasswordInformation()
        {
            return CanResetMemberPassword;
        }

        public bool CanUpdateDeadlineInformation()
        {
            return CanUpdateDeadline;
        }

        public bool CanUpdateMemberPermissionSetİnformation()
        {
            return CanUpdateDeadline;
        }

        public bool CanUpdateProjectDescriptionInformation()
        {
            return CanUpdateDeadline;
        }
    }
}
