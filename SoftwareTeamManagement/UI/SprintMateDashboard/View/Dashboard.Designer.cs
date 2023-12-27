namespace SoftwareTeamManagement.UI.SprintMateDashboard.View
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            menuPanel = new Panel();
            button2 = new Button();
            button1 = new Button();
            logoutBtn = new Button();
            teamBtn = new Button();
            projectsBtn = new Button();
            tasksBtn = new Button();
            profilPanel = new Panel();
            label1 = new Label();
            User = new Label();
            pictureBox1 = new PictureBox();
            sectionPanel = new FlowLayoutPanel();
            teamMemberBindingSource = new BindingSource(components);
            menuPanel.SuspendLayout();
            profilPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teamMemberBindingSource).BeginInit();
            SuspendLayout();
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.FromArgb(6, 6, 6);
            menuPanel.Controls.Add(button2);
            menuPanel.Controls.Add(button1);
            menuPanel.Controls.Add(logoutBtn);
            menuPanel.Controls.Add(teamBtn);
            menuPanel.Controls.Add(projectsBtn);
            menuPanel.Controls.Add(tasksBtn);
            menuPanel.Controls.Add(profilPanel);
            menuPanel.Dock = DockStyle.Left;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(248, 650);
            menuPanel.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(241, 241, 241);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 357);
            button2.Name = "button2";
            button2.Padding = new Padding(20, 0, 0, 0);
            button2.Size = new Size(248, 64);
            button2.TabIndex = 13;
            button2.Text = "Meetings";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(241, 241, 241);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 293);
            button1.Name = "button1";
            button1.Padding = new Padding(20, 0, 0, 0);
            button1.Size = new Size(248, 64);
            button1.TabIndex = 12;
            button1.Text = "      Announcements";
            button1.UseVisualStyleBackColor = true;
            // 
            // logoutBtn
            // 
            logoutBtn.BackgroundImageLayout = ImageLayout.Stretch;
            logoutBtn.Dock = DockStyle.Bottom;
            logoutBtn.FlatAppearance.BorderSize = 0;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Font = new Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            logoutBtn.ForeColor = Color.FromArgb(241, 241, 241);
            logoutBtn.Image = (Image)resources.GetObject("logoutBtn.Image");
            logoutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            logoutBtn.Location = new Point(0, 586);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Padding = new Padding(20, 0, 0, 0);
            logoutBtn.Size = new Size(248, 64);
            logoutBtn.TabIndex = 11;
            logoutBtn.Text = "Log Out";
            logoutBtn.UseVisualStyleBackColor = true;
            // 
            // teamBtn
            // 
            teamBtn.BackgroundImageLayout = ImageLayout.Stretch;
            teamBtn.Dock = DockStyle.Top;
            teamBtn.FlatAppearance.BorderSize = 0;
            teamBtn.FlatStyle = FlatStyle.Flat;
            teamBtn.Font = new Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            teamBtn.ForeColor = Color.FromArgb(241, 241, 241);
            teamBtn.Image = (Image)resources.GetObject("teamBtn.Image");
            teamBtn.ImageAlign = ContentAlignment.MiddleLeft;
            teamBtn.Location = new Point(0, 229);
            teamBtn.Name = "teamBtn";
            teamBtn.Padding = new Padding(20, 0, 0, 0);
            teamBtn.Size = new Size(248, 64);
            teamBtn.TabIndex = 10;
            teamBtn.Text = "My Team";
            teamBtn.UseVisualStyleBackColor = true;
            // 
            // projectsBtn
            // 
            projectsBtn.BackgroundImageLayout = ImageLayout.Stretch;
            projectsBtn.Dock = DockStyle.Top;
            projectsBtn.FlatAppearance.BorderSize = 0;
            projectsBtn.FlatStyle = FlatStyle.Flat;
            projectsBtn.Font = new Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            projectsBtn.ForeColor = Color.FromArgb(241, 241, 241);
            projectsBtn.Image = (Image)resources.GetObject("projectsBtn.Image");
            projectsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            projectsBtn.Location = new Point(0, 165);
            projectsBtn.Name = "projectsBtn";
            projectsBtn.Padding = new Padding(20, 0, 0, 0);
            projectsBtn.Size = new Size(248, 64);
            projectsBtn.TabIndex = 9;
            projectsBtn.Text = "Projects";
            projectsBtn.UseVisualStyleBackColor = true;
            // 
            // tasksBtn
            // 
            tasksBtn.BackgroundImageLayout = ImageLayout.Stretch;
            tasksBtn.Dock = DockStyle.Top;
            tasksBtn.FlatAppearance.BorderSize = 0;
            tasksBtn.FlatStyle = FlatStyle.Flat;
            tasksBtn.Font = new Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tasksBtn.ForeColor = Color.FromArgb(241, 241, 241);
            tasksBtn.Image = (Image)resources.GetObject("tasksBtn.Image");
            tasksBtn.ImageAlign = ContentAlignment.MiddleLeft;
            tasksBtn.Location = new Point(0, 101);
            tasksBtn.Name = "tasksBtn";
            tasksBtn.Padding = new Padding(20, 0, 0, 0);
            tasksBtn.Size = new Size(248, 64);
            tasksBtn.TabIndex = 3;
            tasksBtn.Text = "Tasks";
            tasksBtn.UseVisualStyleBackColor = true;
            // 
            // profilPanel
            // 
            profilPanel.BackColor = Color.FromArgb(6, 6, 6);
            profilPanel.Controls.Add(label1);
            profilPanel.Controls.Add(User);
            profilPanel.Controls.Add(pictureBox1);
            profilPanel.Dock = DockStyle.Top;
            profilPanel.Location = new Point(0, 0);
            profilPanel.Name = "profilPanel";
            profilPanel.Size = new Size(248, 101);
            profilPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 98);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // User
            // 
            User.AutoSize = true;
            User.BackColor = Color.Transparent;
            User.Font = new Font("Iceland", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point);
            User.ForeColor = Color.White;
            User.Location = new Point(73, 22);
            User.Name = "User";
            User.Size = new Size(164, 32);
            User.TabIndex = 1;
            User.Text = "Sprint Mate";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // sectionPanel
            // 
            sectionPanel.BackColor = Color.FromArgb(238, 245, 255);
            sectionPanel.Dock = DockStyle.Fill;
            sectionPanel.Location = new Point(248, 0);
            sectionPanel.Name = "sectionPanel";
            sectionPanel.Size = new Size(952, 650);
            sectionPanel.TabIndex = 1;
            // 
            // teamMemberBindingSource
            // 
            teamMemberBindingSource.DataSource = typeof(BusinessLogic.BaseDataModel.TeamMember.TeamMember);
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1200, 650);
            Controls.Add(sectionPanel);
            Controls.Add(menuPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            menuPanel.ResumeLayout(false);
            profilPanel.ResumeLayout(false);
            profilPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)teamMemberBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel menuPanel;
        private Panel profilPanel;
        private PictureBox pictureBox1;
        private Label User;
        private Button logoutBtn;
        private Label label1;
        private Button button5;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button3;
        private Button button2;
        private Button teamBtn;
        private Button projectsBtn;
        private Button tasksBtn;
        private Button button1;
        private BindingSource teamMemberBindingSource;
        private FlowLayoutPanel sectionPanel;
    }
}