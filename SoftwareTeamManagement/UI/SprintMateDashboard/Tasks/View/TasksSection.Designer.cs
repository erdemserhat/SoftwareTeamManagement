namespace SoftwareTeamManagement.UI.SprintMateDashboard.Tasks.View
{
    partial class TasksSection
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
            ColumnHeader id;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TasksSection));
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point));
            generalContainer = new Panel();
            tasksContainer = new Panel();
            addTaskBtn = new Panel();
            label10 = new Label();
            addTaskBtn1 = new Panel();
            panel4 = new Panel();
            label9 = new Label();
            deleteTaskBtn = new Panel();
            panel2 = new Panel();
            label8 = new Label();
            editTaskBtn = new Panel();
            panel3 = new Panel();
            label7 = new Label();
            refreshTask = new Panel();
            optionsSection = new Panel();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            taskListView = new ListView();
            taskTitle = new ColumnHeader();
            taskPriorityLevel = new ColumnHeader();
            taskCreatedTime = new ColumnHeader();
            taskCategory = new ColumnHeader();
            taskDescription = new ColumnHeader();
            optionsContainer = new Panel();
            tasksSectionHeader = new Panel();
            label6 = new Label();
            id = new ColumnHeader();
            generalContainer.SuspendLayout();
            tasksContainer.SuspendLayout();
            addTaskBtn.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            tasksSectionHeader.SuspendLayout();
            SuspendLayout();
            // 
            // id
            // 
            id.Text = "Task No";
            id.Width = 0;
            // 
            // generalContainer
            // 
            generalContainer.BackColor = SystemColors.AppWorkspace;
            generalContainer.Controls.Add(tasksContainer);
            generalContainer.Controls.Add(optionsContainer);
            generalContainer.Controls.Add(tasksSectionHeader);
            generalContainer.Dock = DockStyle.Fill;
            generalContainer.Location = new Point(0, 0);
            generalContainer.Name = "generalContainer";
            generalContainer.Size = new Size(900, 650);
            generalContainer.TabIndex = 0;
            // 
            // tasksContainer
            // 
            tasksContainer.BackColor = Color.Transparent;
            tasksContainer.Controls.Add(addTaskBtn);
            tasksContainer.Controls.Add(panel4);
            tasksContainer.Controls.Add(panel2);
            tasksContainer.Controls.Add(panel3);
            tasksContainer.Controls.Add(optionsSection);
            tasksContainer.Controls.Add(panel1);
            tasksContainer.Controls.Add(taskListView);
            tasksContainer.Dock = DockStyle.Fill;
            tasksContainer.Location = new Point(0, 74);
            tasksContainer.Name = "tasksContainer";
            tasksContainer.Size = new Size(900, 576);
            tasksContainer.TabIndex = 3;
            // 
            // addTaskBtn
            // 
            addTaskBtn.Controls.Add(label10);
            addTaskBtn.Controls.Add(addTaskBtn1);
            addTaskBtn.Location = new Point(116, 6);
            addTaskBtn.Name = "addTaskBtn";
            addTaskBtn.Size = new Size(68, 95);
            addTaskBtn.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 63);
            label10.Name = "label10";
            label10.Size = new Size(37, 20);
            label10.TabIndex = 3;
            label10.Text = "Add";
            // 
            // addTaskBtn1
            // 
            addTaskBtn1.BackgroundImage = (Image)resources.GetObject("addTaskBtn1.BackgroundImage");
            addTaskBtn1.Cursor = Cursors.Hand;
            addTaskBtn1.Location = new Point(1, 0);
            addTaskBtn1.Name = "addTaskBtn1";
            addTaskBtn1.Size = new Size(64, 64);
            addTaskBtn1.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(label9);
            panel4.Controls.Add(deleteTaskBtn);
            panel4.Location = new Point(300, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(68, 95);
            panel4.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 63);
            label9.Name = "label9";
            label9.Size = new Size(53, 20);
            label9.TabIndex = 3;
            label9.Text = "Delete";
            // 
            // deleteTaskBtn
            // 
            deleteTaskBtn.BackgroundImage = (Image)resources.GetObject("deleteTaskBtn.BackgroundImage");
            deleteTaskBtn.Cursor = Cursors.Hand;
            deleteTaskBtn.Location = new Point(1, 0);
            deleteTaskBtn.Name = "deleteTaskBtn";
            deleteTaskBtn.Size = new Size(64, 64);
            deleteTaskBtn.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(label8);
            panel2.Controls.Add(editTaskBtn);
            panel2.Location = new Point(515, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(68, 95);
            panel2.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 63);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 3;
            label8.Text = "Update";
            // 
            // editTaskBtn
            // 
            editTaskBtn.BackgroundImage = (Image)resources.GetObject("editTaskBtn.BackgroundImage");
            editTaskBtn.Cursor = Cursors.Hand;
            editTaskBtn.Location = new Point(1, 0);
            editTaskBtn.Name = "editTaskBtn";
            editTaskBtn.Size = new Size(64, 64);
            editTaskBtn.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(label7);
            panel3.Controls.Add(refreshTask);
            panel3.Location = new Point(720, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(68, 95);
            panel3.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 63);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 3;
            label7.Text = "Refresh";
            // 
            // refreshTask
            // 
            refreshTask.BackgroundImage = (Image)resources.GetObject("refreshTask.BackgroundImage");
            refreshTask.Cursor = Cursors.Hand;
            refreshTask.Location = new Point(1, 0);
            refreshTask.Name = "refreshTask";
            refreshTask.Size = new Size(64, 64);
            refreshTask.TabIndex = 2;
            // 
            // optionsSection
            // 
            optionsSection.Location = new Point(116, 19);
            optionsSection.Name = "optionsSection";
            optionsSection.Size = new Size(672, 64);
            optionsSection.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(38, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 45);
            panel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(551, 7);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 6;
            label5.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(461, 7);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 5;
            label4.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(294, 7);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 4;
            label3.Text = "Created Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(160, 7);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 3;
            label2.Text = "Priority";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 7);
            label1.Name = "label1";
            label1.Size = new Size(44, 25);
            label1.TabIndex = 2;
            label1.Text = "Title";
            // 
            // taskListView
            // 
            taskListView.Activation = ItemActivation.OneClick;
            taskListView.Alignment = ListViewAlignment.SnapToGrid;
            taskListView.AllowDrop = true;
            taskListView.AutoArrange = false;
            taskListView.BackColor = SystemColors.AppWorkspace;
            taskListView.BorderStyle = BorderStyle.None;
            taskListView.Columns.AddRange(new ColumnHeader[] { id, taskTitle, taskPriorityLevel, taskCreatedTime, taskCategory, taskDescription });
            taskListView.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            taskListView.ForeColor = Color.Black;
            taskListView.ImeMode = ImeMode.NoControl;
            listViewItem1.StateImageIndex = 0;
            taskListView.Items.AddRange(new ListViewItem[] { listViewItem1 });
            taskListView.Location = new Point(38, 118);
            taskListView.MultiSelect = false;
            taskListView.Name = "taskListView";
            taskListView.Size = new Size(805, 437);
            taskListView.TabIndex = 0;
            taskListView.Tag = "";
            taskListView.UseCompatibleStateImageBehavior = false;
            taskListView.View = System.Windows.Forms.View.Details;
            taskListView.KeyDown += taskListView_KeyDown;
            // 
            // taskTitle
            // 
            taskTitle.Text = "Title";
            taskTitle.Width = 150;
            // 
            // taskPriorityLevel
            // 
            taskPriorityLevel.Text = "Priority Level";
            taskPriorityLevel.TextAlign = HorizontalAlignment.Center;
            taskPriorityLevel.Width = 100;
            // 
            // taskCreatedTime
            // 
            taskCreatedTime.Text = "Created Time";
            taskCreatedTime.TextAlign = HorizontalAlignment.Center;
            taskCreatedTime.Width = 200;
            // 
            // taskCategory
            // 
            taskCategory.Text = "Category";
            taskCategory.TextAlign = HorizontalAlignment.Center;
            taskCategory.Width = 100;
            // 
            // taskDescription
            // 
            taskDescription.Text = "Description";
            taskDescription.Width = 200;
            // 
            // optionsContainer
            // 
            optionsContainer.Location = new Point(0, 74);
            optionsContainer.Name = "optionsContainer";
            optionsContainer.Size = new Size(900, 58);
            optionsContainer.TabIndex = 2;
            // 
            // tasksSectionHeader
            // 
            tasksSectionHeader.BackColor = SystemColors.ButtonShadow;
            tasksSectionHeader.Controls.Add(label6);
            tasksSectionHeader.Dock = DockStyle.Top;
            tasksSectionHeader.Location = new Point(0, 0);
            tasksSectionHeader.Name = "tasksSectionHeader";
            tasksSectionHeader.Size = new Size(900, 74);
            tasksSectionHeader.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Iceland", 28.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(34, 40, 49);
            label6.Location = new Point(367, 16);
            label6.Name = "label6";
            label6.Size = new Size(119, 45);
            label6.TabIndex = 0;
            label6.Text = "Tasks";
            // 
            // TasksSection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(generalContainer);
            Name = "TasksSection";
            Size = new Size(900, 650);
            Load += TasksSection_Load;
            generalContainer.ResumeLayout(false);
            tasksContainer.ResumeLayout(false);
            addTaskBtn.ResumeLayout(false);
            addTaskBtn.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tasksSectionHeader.ResumeLayout(false);
            tasksSectionHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel generalContainer;
        private Panel optionsSection;
        private Panel tasksSectionHeader;
        private Panel optionsContainer;
        private Panel tasksContainer;
        private ColumnHeader taskTitle;
        private ColumnHeader taskPriorityLevel;
        private ColumnHeader taskDescription;
        private ColumnHeader taskCreatedTime;
        private ColumnHeader taskCategory;
        public ListView taskListView;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Panel refreshTask;
        private Panel panel3;
        private Label label7;
        private Panel panel2;
        private Label label8;
        private Panel editTaskBtn;
        private Panel panel4;
        private Label label9;
        private Panel deleteTaskBtn;
        private Panel addTaskBtn;
        private Label label10;
        private Panel addTaskBtn1;
    }
}
