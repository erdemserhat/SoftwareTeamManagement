namespace SoftwareTeamManagement.UI.SprintMateDashboard.Tasks.View
{
    partial class AddTaskFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTaskFrame));
            exitBtn = new Panel();
            saveBtn = new Panel();
            titleTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            priorityListBox = new ListBox();
            SuspendLayout();
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Transparent;
            exitBtn.Cursor = Cursors.Hand;
            exitBtn.Location = new Point(336, 2);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(41, 37);
            exitBtn.TabIndex = 0;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.Transparent;
            saveBtn.Cursor = Cursors.Hand;
            saveBtn.Location = new Point(123, 426);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(130, 46);
            saveBtn.TabIndex = 1;
            // 
            // titleTextBox
            // 
            titleTextBox.BackColor = Color.FromArgb(95, 111, 115);
            titleTextBox.BorderStyle = BorderStyle.None;
            titleTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            titleTextBox.ForeColor = Color.White;
            titleTextBox.Location = new Point(30, 129);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(313, 36);
            titleTextBox.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.BackColor = Color.FromArgb(95, 111, 115);
            descriptionTextBox.BorderStyle = BorderStyle.None;
            descriptionTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionTextBox.ForeColor = Color.White;
            descriptionTextBox.Location = new Point(30, 225);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(313, 36);
            descriptionTextBox.TabIndex = 3;
            // 
            // priorityListBox
            // 
            priorityListBox.BackColor = Color.FromArgb(95, 111, 115);
            priorityListBox.BorderStyle = BorderStyle.None;
            priorityListBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            priorityListBox.ForeColor = Color.White;
            priorityListBox.FormattingEnabled = true;
            priorityListBox.ItemHeight = 25;
            priorityListBox.Items.AddRange(new object[] { "Low", "Medium", "High" });
            priorityListBox.Location = new Point(30, 317);
            priorityListBox.Name = "priorityListBox";
            priorityListBox.Size = new Size(322, 75);
            priorityListBox.TabIndex = 4;
            priorityListBox.SelectedIndexChanged += priorityListBox_SelectedIndexChanged;
            // 
            // AddTaskFrame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 96, 93);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(380, 510);
            Controls.Add(priorityListBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(saveBtn);
            Controls.Add(exitBtn);
            ForeColor = Color.Coral;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddTaskFrame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddTaskFrame";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel mainContainer;
        private Panel headContainer;
        private Label title;
        private ListBox priorityListBox;
        private Panel exitBtn;
        private Panel saveBtn;
        private TextBox titleTextBox;
        private TextBox descriptionTextBox;
    }
}