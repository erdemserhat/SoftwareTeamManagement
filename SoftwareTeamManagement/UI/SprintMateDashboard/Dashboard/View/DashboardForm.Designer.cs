namespace SoftwareTeamManagement.UI.SprintMateDashboard.Dashboard.View
{
    partial class DashboardForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            mainContainerPanel = new Panel();
            mainSectionPanel = new Panel();
            menuPanel = new Panel();
            headerContainer = new Panel();
            logoPanel = new Panel();
            welcomeText = new Label();
            dashboardLogoIcon = new PictureBox();
            dashboardIconText = new Label();
            optionsPanel = new Panel();
            optionsGroup = new Panel();
            logoutBtn = new Button();
            meetingsBtn = new Button();
            announcementsBtn = new Button();
            teamBtn = new Button();
            projectsBtn = new Button();
            tasksBtn = new Button();
            mainContainerPanel.SuspendLayout();
            menuPanel.SuspendLayout();
            headerContainer.SuspendLayout();
            logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dashboardLogoIcon).BeginInit();
            optionsPanel.SuspendLayout();
            optionsGroup.SuspendLayout();
            SuspendLayout();
            // 
            // mainContainerPanel
            // 
            mainContainerPanel.Controls.Add(mainSectionPanel);
            mainContainerPanel.Controls.Add(menuPanel);
            mainContainerPanel.Dock = DockStyle.Fill;
            mainContainerPanel.Location = new Point(0, 0);
            mainContainerPanel.Name = "mainContainerPanel";
            mainContainerPanel.Size = new Size(1200, 650);
            mainContainerPanel.TabIndex = 0;
            // 
            // mainSectionPanel
            // 
            mainSectionPanel.BackColor = SystemColors.ButtonShadow;
            mainSectionPanel.Dock = DockStyle.Fill;
            mainSectionPanel.ForeColor = SystemColors.ActiveCaptionText;
            mainSectionPanel.Location = new Point(300, 0);
            mainSectionPanel.Name = "mainSectionPanel";
            mainSectionPanel.Size = new Size(900, 650);
            mainSectionPanel.TabIndex = 1;
            // 
            // menuPanel
            // 
            menuPanel.BackColor = SystemColors.ActiveCaptionText;
            menuPanel.Controls.Add(headerContainer);
            menuPanel.Controls.Add(optionsPanel);
            menuPanel.Dock = DockStyle.Left;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(300, 650);
            menuPanel.TabIndex = 0;
            // 
            // headerContainer
            // 
            headerContainer.BackColor = Color.FromArgb(34, 40, 49);
            headerContainer.Controls.Add(logoPanel);
            headerContainer.Dock = DockStyle.Top;
            headerContainer.Location = new Point(0, 0);
            headerContainer.Name = "headerContainer";
            headerContainer.Size = new Size(300, 200);
            headerContainer.TabIndex = 1;
            // 
            // logoPanel
            // 
            logoPanel.BackColor = Color.FromArgb(34, 40, 49);
            logoPanel.Controls.Add(welcomeText);
            logoPanel.Controls.Add(dashboardLogoIcon);
            logoPanel.Controls.Add(dashboardIconText);
            logoPanel.ForeColor = SystemColors.ControlText;
            logoPanel.Location = new Point(17, 21);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(280, 136);
            logoPanel.TabIndex = 1;
            // 
            // welcomeText
            // 
            welcomeText.AutoSize = true;
            welcomeText.Dock = DockStyle.Bottom;
            welcomeText.Font = new Font("Abhaya Libre Medium", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            welcomeText.ForeColor = SystemColors.ButtonShadow;
            welcomeText.Location = new Point(0, 112);
            welcomeText.Name = "welcomeText";
            welcomeText.Size = new Size(233, 24);
            welcomeText.TabIndex = 1;
            welcomeText.Text = "Welcome, Serhat Erdem!";
            welcomeText.Click += welcomeText_Click;
            // 
            // dashboardLogoIcon
            // 
            dashboardLogoIcon.Image = (Image)resources.GetObject("dashboardLogoIcon.Image");
            dashboardLogoIcon.Location = new Point(0, 0);
            dashboardLogoIcon.Name = "dashboardLogoIcon";
            dashboardLogoIcon.Size = new Size(59, 69);
            dashboardLogoIcon.TabIndex = 0;
            dashboardLogoIcon.TabStop = false;
            // 
            // dashboardIconText
            // 
            dashboardIconText.AutoSize = true;
            dashboardIconText.Font = new Font("Iceland", 24F, FontStyle.Bold, GraphicsUnit.Point);
            dashboardIconText.ForeColor = SystemColors.ButtonShadow;
            dashboardIconText.Location = new Point(56, 10);
            dashboardIconText.Name = "dashboardIconText";
            dashboardIconText.Size = new Size(210, 39);
            dashboardIconText.TabIndex = 0;
            dashboardIconText.Text = "Sprint Mate";
            // 
            // optionsPanel
            // 
            optionsPanel.BackColor = Color.FromArgb(34, 40, 49);
            optionsPanel.Controls.Add(optionsGroup);
            optionsPanel.Dock = DockStyle.Fill;
            optionsPanel.Location = new Point(0, 0);
            optionsPanel.Name = "optionsPanel";
            optionsPanel.Size = new Size(300, 650);
            optionsPanel.TabIndex = 1;
            // 
            // optionsGroup
            // 
            optionsGroup.BackColor = Color.FromArgb(34, 40, 49);
            optionsGroup.Controls.Add(logoutBtn);
            optionsGroup.Controls.Add(meetingsBtn);
            optionsGroup.Controls.Add(announcementsBtn);
            optionsGroup.Controls.Add(teamBtn);
            optionsGroup.Controls.Add(projectsBtn);
            optionsGroup.Controls.Add(tasksBtn);
            optionsGroup.Location = new Point(3, 206);
            optionsGroup.Margin = new Padding(5);
            optionsGroup.Name = "optionsGroup";
            optionsGroup.Padding = new Padding(5);
            optionsGroup.Size = new Size(294, 445);
            optionsGroup.TabIndex = 1;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.Transparent;
            logoutBtn.BackgroundImageLayout = ImageLayout.None;
            logoutBtn.Cursor = Cursors.Hand;
            logoutBtn.Dock = DockStyle.Bottom;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Font = new Font("Abhaya Libre Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            logoutBtn.ForeColor = SystemColors.ButtonShadow;
            logoutBtn.Image = (Image)resources.GetObject("logoutBtn.Image");
            logoutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            logoutBtn.Location = new Point(5, 385);
            logoutBtn.Margin = new Padding(0);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Padding = new Padding(20, 0, 0, 0);
            logoutBtn.Size = new Size(284, 55);
            logoutBtn.TabIndex = 5;
            logoutBtn.Text = "        Log Out";
            logoutBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            logoutBtn.UseVisualStyleBackColor = false;
            // 
            // meetingsBtn
            // 
            meetingsBtn.BackColor = Color.Transparent;
            meetingsBtn.BackgroundImageLayout = ImageLayout.None;
            meetingsBtn.Cursor = Cursors.Hand;
            meetingsBtn.Dock = DockStyle.Top;
            meetingsBtn.FlatStyle = FlatStyle.Flat;
            meetingsBtn.Font = new Font("Abhaya Libre Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            meetingsBtn.ForeColor = SystemColors.ButtonShadow;
            meetingsBtn.Image = (Image)resources.GetObject("meetingsBtn.Image");
            meetingsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            meetingsBtn.Location = new Point(5, 225);
            meetingsBtn.Margin = new Padding(0);
            meetingsBtn.Name = "meetingsBtn";
            meetingsBtn.Padding = new Padding(20, 0, 0, 0);
            meetingsBtn.Size = new Size(284, 55);
            meetingsBtn.TabIndex = 4;
            meetingsBtn.Text = "        Meetings";
            meetingsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            meetingsBtn.UseVisualStyleBackColor = false;
            // 
            // announcementsBtn
            // 
            announcementsBtn.BackColor = Color.Transparent;
            announcementsBtn.BackgroundImageLayout = ImageLayout.None;
            announcementsBtn.Cursor = Cursors.Hand;
            announcementsBtn.Dock = DockStyle.Top;
            announcementsBtn.FlatStyle = FlatStyle.Flat;
            announcementsBtn.Font = new Font("Abhaya Libre Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            announcementsBtn.ForeColor = SystemColors.ButtonShadow;
            announcementsBtn.Image = (Image)resources.GetObject("announcementsBtn.Image");
            announcementsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            announcementsBtn.Location = new Point(5, 170);
            announcementsBtn.Margin = new Padding(0);
            announcementsBtn.Name = "announcementsBtn";
            announcementsBtn.Padding = new Padding(20, 0, 0, 0);
            announcementsBtn.Size = new Size(284, 55);
            announcementsBtn.TabIndex = 3;
            announcementsBtn.Text = " Announcements";
            announcementsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            announcementsBtn.UseVisualStyleBackColor = false;
            // 
            // teamBtn
            // 
            teamBtn.BackColor = Color.Transparent;
            teamBtn.BackgroundImageLayout = ImageLayout.None;
            teamBtn.Cursor = Cursors.Hand;
            teamBtn.Dock = DockStyle.Top;
            teamBtn.FlatStyle = FlatStyle.Flat;
            teamBtn.Font = new Font("Abhaya Libre Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            teamBtn.ForeColor = SystemColors.ButtonShadow;
            teamBtn.Image = (Image)resources.GetObject("teamBtn.Image");
            teamBtn.ImageAlign = ContentAlignment.MiddleLeft;
            teamBtn.Location = new Point(5, 115);
            teamBtn.Margin = new Padding(0);
            teamBtn.Name = "teamBtn";
            teamBtn.Padding = new Padding(20, 0, 0, 0);
            teamBtn.Size = new Size(284, 55);
            teamBtn.TabIndex = 2;
            teamBtn.Text = "        My Team";
            teamBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            teamBtn.UseVisualStyleBackColor = false;
            // 
            // projectsBtn
            // 
            projectsBtn.BackColor = Color.Transparent;
            projectsBtn.BackgroundImageLayout = ImageLayout.None;
            projectsBtn.Cursor = Cursors.Hand;
            projectsBtn.Dock = DockStyle.Top;
            projectsBtn.FlatStyle = FlatStyle.Flat;
            projectsBtn.Font = new Font("Abhaya Libre Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            projectsBtn.ForeColor = SystemColors.ButtonShadow;
            projectsBtn.Image = (Image)resources.GetObject("projectsBtn.Image");
            projectsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            projectsBtn.Location = new Point(5, 60);
            projectsBtn.Margin = new Padding(0);
            projectsBtn.Name = "projectsBtn";
            projectsBtn.Padding = new Padding(20, 0, 0, 0);
            projectsBtn.Size = new Size(284, 55);
            projectsBtn.TabIndex = 1;
            projectsBtn.Text = "        Projects";
            projectsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            projectsBtn.UseVisualStyleBackColor = false;
            // 
            // tasksBtn
            // 
            tasksBtn.BackColor = Color.Transparent;
            tasksBtn.BackgroundImageLayout = ImageLayout.None;
            tasksBtn.Cursor = Cursors.Hand;
            tasksBtn.Dock = DockStyle.Top;
            tasksBtn.FlatStyle = FlatStyle.Flat;
            tasksBtn.Font = new Font("Abhaya Libre Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            tasksBtn.ForeColor = SystemColors.ButtonShadow;
            tasksBtn.Image = (Image)resources.GetObject("tasksBtn.Image");
            tasksBtn.ImageAlign = ContentAlignment.MiddleLeft;
            tasksBtn.Location = new Point(5, 5);
            tasksBtn.Margin = new Padding(0);
            tasksBtn.Name = "tasksBtn";
            tasksBtn.Padding = new Padding(20, 0, 0, 0);
            tasksBtn.Size = new Size(284, 55);
            tasksBtn.TabIndex = 0;
            tasksBtn.Text = "          Tasks";
            tasksBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            tasksBtn.UseVisualStyleBackColor = false;
            tasksBtn.MouseEnter += tasksBtn_MouseEnter;
            tasksBtn.MouseLeave += tasksBtn_MouseLeave;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 650);
            Controls.Add(mainContainerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            mainContainerPanel.ResumeLayout(false);
            menuPanel.ResumeLayout(false);
            headerContainer.ResumeLayout(false);
            logoPanel.ResumeLayout(false);
            logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dashboardLogoIcon).EndInit();
            optionsPanel.ResumeLayout(false);
            optionsGroup.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel mainContainerPanel;
        public Panel mainSectionPanel;
        private Panel menuPanel;
        private Panel optionsPanel;
        private Panel headerContainer;
        private PictureBox dashboardLogoIcon;
        private Panel logoPanel;
        private Label dashboardIconText;
        private Button tasksBtn;
        private Panel optionsGroup;
        private Button projectsBtn;
        private Button teamBtn;
        private Button meetingsBtn;
        private Button announcementsBtn;
        private Button exitBtn;
        private Button logoutBtn;
        private Label welcomeText;
    }
}