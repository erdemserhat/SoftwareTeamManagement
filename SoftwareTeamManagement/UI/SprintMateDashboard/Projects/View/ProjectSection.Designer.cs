namespace SoftwareTeamManagement.UI.SprintMateDashboard.Projects.View
{
    partial class ProjectSection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectSection));
            generalContainer = new Panel();
            refreshProject = new Panel();
            label1 = new Label();
            saveBtn = new Panel();
            label2 = new Label();
            editBtn = new Panel();
            headerContainer = new Panel();
            label6 = new Label();
            projectDescriptionBackgroundTitle = new Panel();
            projectDescriptionTB = new TextBox();
            titleBackgroundContainer = new Panel();
            label3 = new Label();
            projectTitleTB = new TextBox();
            editTaskBtn = new Panel();
            generalContainer.SuspendLayout();
            headerContainer.SuspendLayout();
            projectDescriptionBackgroundTitle.SuspendLayout();
            titleBackgroundContainer.SuspendLayout();
            SuspendLayout();
            // 
            // generalContainer
            // 
            generalContainer.BackColor = SystemColors.AppWorkspace;
            generalContainer.BackgroundImage = (Image)resources.GetObject("generalContainer.BackgroundImage");
            generalContainer.Controls.Add(refreshProject);
            generalContainer.Controls.Add(label1);
            generalContainer.Controls.Add(saveBtn);
            generalContainer.Controls.Add(label2);
            generalContainer.Controls.Add(editBtn);
            generalContainer.Controls.Add(headerContainer);
            generalContainer.Controls.Add(projectDescriptionBackgroundTitle);
            generalContainer.Controls.Add(titleBackgroundContainer);
            generalContainer.Dock = DockStyle.Fill;
            generalContainer.ImeMode = ImeMode.Disable;
            generalContainer.Location = new Point(0, 0);
            generalContainer.Name = "generalContainer";
            generalContainer.Size = new Size(900, 650);
            generalContainer.TabIndex = 0;
            // 
            // refreshProject
            // 
            refreshProject.BackgroundImage = (Image)resources.GetObject("refreshProject.BackgroundImage");
            refreshProject.BackgroundImageLayout = ImageLayout.Stretch;
            refreshProject.Cursor = Cursors.Hand;
            refreshProject.Location = new Point(664, 102);
            refreshProject.Name = "refreshProject";
            refreshProject.Size = new Size(45, 45);
            refreshProject.TabIndex = 6;
            refreshProject.Click += refreshProject_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(746, 145);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 5;
            label1.Text = "Save";
            // 
            // saveBtn
            // 
            saveBtn.BackgroundImage = (Image)resources.GetObject("saveBtn.BackgroundImage");
            saveBtn.BackgroundImageLayout = ImageLayout.Stretch;
            saveBtn.Cursor = Cursors.Hand;
            saveBtn.Location = new Point(746, 102);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(38, 38);
            saveBtn.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(822, 147);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 4;
            label2.Text = "Edit";
            // 
            // editBtn
            // 
            editBtn.BackgroundImage = (Image)resources.GetObject("editBtn.BackgroundImage");
            editBtn.BackgroundImageLayout = ImageLayout.Stretch;
            editBtn.Cursor = Cursors.Hand;
            editBtn.Location = new Point(822, 102);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(45, 45);
            editBtn.TabIndex = 3;
            // 
            // headerContainer
            // 
            headerContainer.BackColor = SystemColors.ButtonShadow;
            headerContainer.Controls.Add(label6);
            headerContainer.Dock = DockStyle.Top;
            headerContainer.Location = new Point(0, 0);
            headerContainer.Name = "headerContainer";
            headerContainer.Size = new Size(900, 74);
            headerContainer.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Iceland", 28.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(34, 40, 49);
            label6.Location = new Point(278, 14);
            label6.Name = "label6";
            label6.Size = new Size(332, 45);
            label6.TabIndex = 1;
            label6.Text = "Project Overview";
            // 
            // projectDescriptionBackgroundTitle
            // 
            projectDescriptionBackgroundTitle.BackColor = Color.Silver;
            projectDescriptionBackgroundTitle.Controls.Add(projectDescriptionTB);
            projectDescriptionBackgroundTitle.Location = new Point(36, 198);
            projectDescriptionBackgroundTitle.Name = "projectDescriptionBackgroundTitle";
            projectDescriptionBackgroundTitle.Size = new Size(832, 395);
            projectDescriptionBackgroundTitle.TabIndex = 2;
            projectDescriptionBackgroundTitle.Paint += projectDescriptionBackgroundTitle_Paint;
            // 
            // projectDescriptionTB
            // 
            projectDescriptionTB.BackColor = Color.Silver;
            projectDescriptionTB.BorderStyle = BorderStyle.None;
            projectDescriptionTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            projectDescriptionTB.Location = new Point(0, 0);
            projectDescriptionTB.Name = "projectDescriptionTB";
            projectDescriptionTB.Size = new Size(821, 27);
            projectDescriptionTB.TabIndex = 0;
            // 
            // titleBackgroundContainer
            // 
            titleBackgroundContainer.BackColor = SystemColors.AppWorkspace;
            titleBackgroundContainer.Controls.Add(label3);
            titleBackgroundContainer.Controls.Add(projectTitleTB);
            titleBackgroundContainer.Location = new Point(145, 131);
            titleBackgroundContainer.Name = "titleBackgroundContainer";
            titleBackgroundContainer.Size = new Size(595, 41);
            titleBackgroundContainer.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(513, 16);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 7;
            label3.Text = "Refresh";
            // 
            // projectTitleTB
            // 
            projectTitleTB.BackColor = SystemColors.AppWorkspace;
            projectTitleTB.BorderStyle = BorderStyle.None;
            projectTitleTB.Dock = DockStyle.Fill;
            projectTitleTB.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            projectTitleTB.Location = new Point(0, 0);
            projectTitleTB.Name = "projectTitleTB";
            projectTitleTB.Size = new Size(595, 31);
            projectTitleTB.TabIndex = 0;
            projectTitleTB.TextAlign = HorizontalAlignment.Center;
            // 
            // editTaskBtn
            // 
            editTaskBtn.BackgroundImage = (Image)resources.GetObject("editTaskBtn.BackgroundImage");
            editTaskBtn.BackgroundImageLayout = ImageLayout.Stretch;
            editTaskBtn.Cursor = Cursors.Hand;
            editTaskBtn.Location = new Point(3, 0);
            editTaskBtn.Name = "editTaskBtn";
            editTaskBtn.Size = new Size(47, 47);
            editTaskBtn.TabIndex = 2;
            // 
            // ProjectSection
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(generalContainer);
            Name = "ProjectSection";
            Size = new Size(900, 650);
            generalContainer.ResumeLayout(false);
            generalContainer.PerformLayout();
            headerContainer.ResumeLayout(false);
            headerContainer.PerformLayout();
            projectDescriptionBackgroundTitle.ResumeLayout(false);
            projectDescriptionBackgroundTitle.PerformLayout();
            titleBackgroundContainer.ResumeLayout(false);
            titleBackgroundContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel headerContainer;
        private Label label6;
        private Panel projectDescriptionBackgroundTitle;
        public Panel titleBackgroundContainer;
        public TextBox projectDescriptionTB;
        public TextBox projectTitleTB;
        public Panel generalContainer;
        private Label label8;
        private Panel editTaskBtn;
        private Panel editBtn;
        private Label label2;
        private Label label1;
        private Panel saveBtn;
        private Panel refreshProject;
        private Label label3;
    }
}
