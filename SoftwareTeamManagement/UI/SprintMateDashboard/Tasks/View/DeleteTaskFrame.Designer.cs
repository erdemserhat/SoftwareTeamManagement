namespace SoftwareTeamManagement.UI.SprintMateDashboard.Tasks.View
{
    partial class DeleteTaskFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteTaskFrame));
            exitBtn = new Panel();
            deleteBtn = new Panel();
            taskInformation = new Label();
            SuspendLayout();
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Transparent;
            exitBtn.Cursor = Cursors.Hand;
            exitBtn.Location = new Point(340, 2);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(37, 36);
            exitBtn.TabIndex = 0;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Transparent;
            deleteBtn.Cursor = Cursors.Hand;
            deleteBtn.Location = new Point(124, 303);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(131, 48);
            deleteBtn.TabIndex = 1;
            // 
            // taskInformation
            // 
            taskInformation.AutoEllipsis = true;
            taskInformation.Font = new Font("Abhaya Libre Medium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            taskInformation.Location = new Point(99, 98);
            taskInformation.Name = "taskInformation";
            taskInformation.Size = new Size(262, 35);
            taskInformation.TabIndex = 2;
            taskInformation.Text = "Android Task #122";
            // 
            // DeleteTaskFrame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(380, 375);
            Controls.Add(taskInformation);
            Controls.Add(deleteBtn);
            Controls.Add(exitBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteTaskFrame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeleteTaskFrame";
            Enter += DeleteTaskFrame_Enter;
            ResumeLayout(false);
        }

        #endregion

        private Panel exitBtn;
        private Panel deleteBtn;
        private Label taskInformation;
    }
}