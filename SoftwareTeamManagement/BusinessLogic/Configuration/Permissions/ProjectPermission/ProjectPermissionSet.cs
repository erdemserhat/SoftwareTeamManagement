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
        private bool canUpdateProjectDescription;
        private bool canAddMember;
        private bool canRemoveMember;
        private bool canResetMemberPassword;
        private bool canAnnounce;
        private bool canHoldMeeting;
        private bool canUpdateMemberPermissionSet;

        public ProjectPermissionSet(bool canChangeProjectName, bool canUpdateProjectDescription, bool canAddMember, bool canRemoveMember, bool canResetMemberPassword, bool canAnnounce, bool canHoldMeeting, bool canUpdateMemberPermissionSet)
        {
            this.canChangeProjectName = canChangeProjectName;
            this.canUpdateProjectDescription = canUpdateProjectDescription;
            this.canAddMember = canAddMember;
            this.canRemoveMember = canRemoveMember;
            this.canResetMemberPassword = canResetMemberPassword;
            this.canAnnounce = canAnnounce;
            this.canHoldMeeting = canHoldMeeting;
            this.canUpdateMemberPermissionSet = canUpdateMemberPermissionSet;
        }

        

        // Getters and Setters
        public bool CanChangeProjectName
        {
            get { return canChangeProjectName; }
            set { canChangeProjectName = value; }
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



        public bool CanUpdateMemberPermissionSetInformation()
        {
            return canUpdateMemberPermissionSet;
        }

        public bool CanUpdateMemberPermissionSetİnformation()
        {
            return CanUpdateMemberPermissionSet;
        }

        public bool CanUpdateProjectDescriptionInformation()
        {
            return CanUpdateProjectDescription;
        }
    }
}
