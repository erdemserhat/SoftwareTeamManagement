namespace SoftwareTeamManagement.UI.SprintMateDashboard.Dashboard.View
{
    partial class LogoutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogoutForm));
            logoutBtn = new Panel();
            cancelBtn = new Panel();
            SuspendLayout();
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.Transparent;
            logoutBtn.Location = new Point(57, 218);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(108, 36);
            logoutBtn.TabIndex = 0;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Transparent;
            cancelBtn.Location = new Point(215, 218);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(108, 36);
            cancelBtn.TabIndex = 1;
            // 
            // LogoutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(375, 275);
            Controls.Add(cancelBtn);
            Controls.Add(logoutBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogoutForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "LogoutForm";
            ResumeLayout(false);
        }

        #endregion

        private Panel logoutBtn;
        private Panel cancelBtn;
    }
}