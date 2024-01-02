namespace SoftwareTeamManagement.UI.SprintMateDashboard.Team.View
{
    partial class TeamSection
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamSection));
            generalContainer = new Panel();
            panel1 = new Panel();
            memberListView = new ListView();
            memberNo = new ColumnHeader();
            fullName = new ColumnHeader();
            roleType = new ColumnHeader();
            roleDepartment = new ColumnHeader();
            email = new ColumnHeader();
            headerContainer = new Panel();
            updateProfile = new Panel();
            titleText = new Label();
            generalContainer.SuspendLayout();
            headerContainer.SuspendLayout();
            SuspendLayout();
            // 
            // generalContainer
            // 
            generalContainer.BackColor = SystemColors.AppWorkspace;
            generalContainer.Controls.Add(panel1);
            generalContainer.Controls.Add(memberListView);
            generalContainer.Controls.Add(headerContainer);
            generalContainer.Dock = DockStyle.Fill;
            generalContainer.Location = new Point(0, 0);
            generalContainer.Name = "generalContainer";
            generalContainer.Size = new Size(900, 650);
            generalContainer.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(23, 151);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 100);
            panel1.TabIndex = 5;
            // 
            // memberListView
            // 
            memberListView.BackColor = SystemColors.AppWorkspace;
            memberListView.Columns.AddRange(new ColumnHeader[] { memberNo, fullName, roleType, roleDepartment, email });
            memberListView.GridLines = true;
            memberListView.Location = new Point(23, 223);
            memberListView.Name = "memberListView";
            memberListView.Scrollable = false;
            memberListView.Size = new Size(850, 400);
            memberListView.TabIndex = 1;
            memberListView.UseCompatibleStateImageBehavior = false;
            memberListView.View = System.Windows.Forms.View.Details;
            // 
            // memberNo
            // 
            memberNo.Text = "Member No";
            memberNo.Width = 0;
            // 
            // fullName
            // 
            fullName.Text = "Full Name";
            fullName.TextAlign = HorizontalAlignment.Center;
            fullName.Width = 200;
            // 
            // roleType
            // 
            roleType.Text = "Position Title";
            roleType.TextAlign = HorizontalAlignment.Center;
            roleType.Width = 200;
            // 
            // roleDepartment
            // 
            roleDepartment.Text = "Department";
            roleDepartment.TextAlign = HorizontalAlignment.Center;
            roleDepartment.Width = 200;
            // 
            // email
            // 
            email.Text = "Email";
            email.TextAlign = HorizontalAlignment.Center;
            email.Width = 250;
            // 
            // headerContainer
            // 
            headerContainer.BackColor = SystemColors.ButtonShadow;
            headerContainer.Controls.Add(updateProfile);
            headerContainer.Controls.Add(titleText);
            headerContainer.Dock = DockStyle.Top;
            headerContainer.Location = new Point(0, 0);
            headerContainer.Name = "headerContainer";
            headerContainer.Size = new Size(900, 75);
            headerContainer.TabIndex = 0;
            // 
            // updateProfile
            // 
            updateProfile.Location = new Point(847, 22);
            updateProfile.Name = "updateProfile";
            updateProfile.Size = new Size(50, 50);
            updateProfile.TabIndex = 3;
            // 
            // titleText
            // 
            titleText.AutoSize = true;
            titleText.Font = new Font("Iceland", 28.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            titleText.ForeColor = Color.FromArgb(34, 40, 49);
            titleText.Location = new Point(354, 14);
            titleText.Name = "titleText";
            titleText.Size = new Size(179, 45);
            titleText.TabIndex = 1;
            titleText.Text = "My Team";
            // 
            // TeamSection
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(generalContainer);
            Name = "TeamSection";
            Size = new Size(900, 650);
            generalContainer.ResumeLayout(false);
            headerContainer.ResumeLayout(false);
            headerContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel generalContainer;
        private Panel headerContainer;
        private Label titleText;
        private ColumnHeader fullName;
        private ColumnHeader roleType;
        private ColumnHeader roleDepartment;
        private ColumnHeader memberNo;
        private ColumnHeader email;
        public ListView memberListView;
        private Panel panel1;
        private Panel updateProfile;
    }
}
