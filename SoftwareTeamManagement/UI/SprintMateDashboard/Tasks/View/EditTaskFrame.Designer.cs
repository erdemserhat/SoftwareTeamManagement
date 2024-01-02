namespace SoftwareTeamManagement.UI.SprintMateDashboard.Tasks.View
{
    partial class EditTaskFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTaskFrame));
            exitBtn = new Panel();
            saveBtn = new Panel();
            titleTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            priorityListBox = new ListBox();
            categoryListBox = new ListBox();
            SuspendLayout();
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Transparent;
            exitBtn.Cursor = Cursors.Hand;
            exitBtn.Location = new Point(337, 3);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(41, 34);
            exitBtn.TabIndex = 0;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.Transparent;
            saveBtn.Cursor = Cursors.Hand;
            saveBtn.Location = new Point(123, 569);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(128, 46);
            saveBtn.TabIndex = 1;
            // 
            // titleTextBox
            // 
            titleTextBox.BackColor = Color.FromArgb(95, 111, 115);
            titleTextBox.BorderStyle = BorderStyle.None;
            titleTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            titleTextBox.ForeColor = Color.White;
            titleTextBox.Location = new Point(28, 130);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(313, 36);
            titleTextBox.TabIndex = 3;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.BackColor = Color.FromArgb(95, 111, 115);
            descriptionTextBox.BorderStyle = BorderStyle.None;
            descriptionTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionTextBox.ForeColor = Color.White;
            descriptionTextBox.Location = new Point(28, 225);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(313, 36);
            descriptionTextBox.TabIndex = 4;
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
            priorityListBox.Location = new Point(28, 315);
            priorityListBox.Name = "priorityListBox";
            priorityListBox.Size = new Size(322, 75);
            priorityListBox.TabIndex = 5;
            priorityListBox.SelectedIndexChanged += priorityListBox_SelectedIndexChanged;
            // 
            // categoryListBox
            // 
            categoryListBox.BackColor = Color.FromArgb(95, 111, 115);
            categoryListBox.BorderStyle = BorderStyle.None;
            categoryListBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            categoryListBox.ForeColor = Color.White;
            categoryListBox.FormattingEnabled = true;
            categoryListBox.ItemHeight = 25;
            categoryListBox.Items.AddRange(new object[] { "Pending", "In Progress", "Done" });
            categoryListBox.Location = new Point(28, 457);
            categoryListBox.Name = "categoryListBox";
            categoryListBox.Size = new Size(322, 75);
            categoryListBox.TabIndex = 6;
            categoryListBox.SelectedIndexChanged += categoryListBox_SelectedIndexChanged;
            // 
            // EditTaskFrame
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(380, 646);
            Controls.Add(categoryListBox);
            Controls.Add(priorityListBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(saveBtn);
            Controls.Add(exitBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditTaskFrame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditTaskFrame";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel exitBtn;
        private Panel saveBtn;
        private TextBox titleTextBox;
        private TextBox descriptionTextBox;
        private ListBox priorityListBox;
        private ListBox categoryListBox;
    }
}