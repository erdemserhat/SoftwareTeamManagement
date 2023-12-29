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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point));
            generalContainer = new Panel();
            tasksContainer = new Panel();
            taskListView = new ListView();
            taskTitle = new ColumnHeader();
            taskPriorityLevel = new ColumnHeader();
            taskCreatedTime = new ColumnHeader();
            taskCategory = new ColumnHeader();
            taskDescription = new ColumnHeader();
            optionsContainer = new Panel();
            optionsSection = new Panel();
            refreshTask = new Button();
            deleteTaskBtn = new Button();
            editTaskBtn = new Button();
            addTaskBtn = new Button();
            tasksSectionHeader = new Panel();
            id = new ColumnHeader();
            generalContainer.SuspendLayout();
            tasksContainer.SuspendLayout();
            optionsContainer.SuspendLayout();
            optionsSection.SuspendLayout();
            SuspendLayout();
            // 
            // id
            // 
            id.Text = "Task No";
            id.Width = 80;
            // 
            // generalContainer
            // 
            generalContainer.BackColor = Color.FromArgb(196, 215, 178);
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
            tasksContainer.Controls.Add(taskListView);
            tasksContainer.Dock = DockStyle.Fill;
            tasksContainer.Location = new Point(0, 128);
            tasksContainer.Name = "tasksContainer";
            tasksContainer.Size = new Size(900, 522);
            tasksContainer.TabIndex = 3;
            // 
            // taskListView
            // 
            taskListView.Activation = ItemActivation.OneClick;
            taskListView.Alignment = ListViewAlignment.SnapToGrid;
            taskListView.AllowDrop = true;
            taskListView.AutoArrange = false;
            taskListView.BackColor = Color.White;
            taskListView.BorderStyle = BorderStyle.None;
            taskListView.Columns.AddRange(new ColumnHeader[] { id, taskTitle, taskPriorityLevel, taskCreatedTime, taskCategory, taskDescription });
            taskListView.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            taskListView.ForeColor = Color.Black;
            taskListView.ImeMode = ImeMode.NoControl;
            listViewItem1.StateImageIndex = 0;
            taskListView.Items.AddRange(new ListViewItem[] { listViewItem1 });
            taskListView.Location = new Point(41, 30);
            taskListView.MultiSelect = false;
            taskListView.Name = "taskListView";
            taskListView.Size = new Size(805, 437);
            taskListView.TabIndex = 0;
            taskListView.Tag = "";
            taskListView.UseCompatibleStateImageBehavior = false;
            taskListView.View = System.Windows.Forms.View.Details;
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
            taskPriorityLevel.Width = 120;
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
            taskDescription.Width = 250;
            // 
            // optionsContainer
            // 
            optionsContainer.Controls.Add(optionsSection);
            optionsContainer.Dock = DockStyle.Top;
            optionsContainer.Location = new Point(0, 64);
            optionsContainer.Name = "optionsContainer";
            optionsContainer.Size = new Size(900, 64);
            optionsContainer.TabIndex = 2;
            // 
            // optionsSection
            // 
            optionsSection.Controls.Add(refreshTask);
            optionsSection.Controls.Add(deleteTaskBtn);
            optionsSection.Controls.Add(editTaskBtn);
            optionsSection.Controls.Add(addTaskBtn);
            optionsSection.Location = new Point(103, 0);
            optionsSection.Name = "optionsSection";
            optionsSection.Size = new Size(661, 64);
            optionsSection.TabIndex = 1;
            // 
            // refreshTask
            // 
            refreshTask.FlatStyle = FlatStyle.Popup;
            refreshTask.Location = new Point(597, 0);
            refreshTask.Margin = new Padding(0);
            refreshTask.Name = "refreshTask";
            refreshTask.Size = new Size(64, 64);
            refreshTask.TabIndex = 3;
            refreshTask.Text = "Refresh Tasks";
            refreshTask.UseVisualStyleBackColor = true;
            // 
            // deleteTaskBtn
            // 
            deleteTaskBtn.FlatStyle = FlatStyle.Popup;
            deleteTaskBtn.Location = new Point(399, 0);
            deleteTaskBtn.Margin = new Padding(0);
            deleteTaskBtn.Name = "deleteTaskBtn";
            deleteTaskBtn.Size = new Size(64, 64);
            deleteTaskBtn.TabIndex = 2;
            deleteTaskBtn.Text = "Delete";
            deleteTaskBtn.UseVisualStyleBackColor = true;
            // 
            // editTaskBtn
            // 
            editTaskBtn.FlatStyle = FlatStyle.Popup;
            editTaskBtn.Location = new Point(191, 0);
            editTaskBtn.Margin = new Padding(0);
            editTaskBtn.Name = "editTaskBtn";
            editTaskBtn.Size = new Size(64, 64);
            editTaskBtn.TabIndex = 1;
            editTaskBtn.Text = "Update";
            editTaskBtn.UseVisualStyleBackColor = true;
            // 
            // addTaskBtn
            // 
            addTaskBtn.BackColor = Color.Transparent;
            addTaskBtn.Dock = DockStyle.Left;
            addTaskBtn.FlatStyle = FlatStyle.Flat;
            addTaskBtn.Location = new Point(0, 0);
            addTaskBtn.Margin = new Padding(0);
            addTaskBtn.Name = "addTaskBtn";
            addTaskBtn.Size = new Size(64, 64);
            addTaskBtn.TabIndex = 0;
            addTaskBtn.Text = "Add";
            addTaskBtn.UseVisualStyleBackColor = false;
            // 
            // tasksSectionHeader
            // 
            tasksSectionHeader.Dock = DockStyle.Top;
            tasksSectionHeader.Location = new Point(0, 0);
            tasksSectionHeader.Name = "tasksSectionHeader";
            tasksSectionHeader.Size = new Size(900, 64);
            tasksSectionHeader.TabIndex = 0;
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
            optionsContainer.ResumeLayout(false);
            optionsSection.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel generalContainer;
        private Panel optionsSection;
        private Button deleteTaskBtn;
        private Button editTaskBtn;
        private Button addTaskBtn;
        private Panel tasksSectionHeader;
        private Panel optionsContainer;
        private Panel tasksContainer;
        private ColumnHeader taskTitle;
        private ColumnHeader taskPriorityLevel;
        private ColumnHeader taskDescription;
        private ColumnHeader taskCreatedTime;
        private ColumnHeader taskCategory;
        public ListView taskListView;
        public Button refreshTask;
        private PictureBox pictureBox1;
    }
}
