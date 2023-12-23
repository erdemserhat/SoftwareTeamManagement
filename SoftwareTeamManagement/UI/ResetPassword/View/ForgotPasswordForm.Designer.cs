namespace SoftwareTeamManagement.UI.ResetPassword.View
{
    partial class ForgotPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordForm));
            fullNameTextBox = new TextBox();
            exitBtn = new Panel();
            goBackToLoginBtn = new Panel();
            searchBtn = new Panel();
            SuspendLayout();
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.BackColor = Color.FromArgb(95, 111, 115);
            fullNameTextBox.BorderStyle = BorderStyle.None;
            fullNameTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            fullNameTextBox.ForeColor = Color.White;
            fullNameTextBox.Location = new Point(703, 268);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(409, 36);
            fullNameTextBox.TabIndex = 5;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Transparent;
            exitBtn.Cursor = Cursors.Hand;
            exitBtn.Location = new Point(1144, 1);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(55, 46);
            exitBtn.TabIndex = 6;
            exitBtn.Click += exitBtn_Click;
            // 
            // goBackToLoginBtn
            // 
            goBackToLoginBtn.BackColor = Color.Transparent;
            goBackToLoginBtn.Cursor = Cursors.Hand;
            goBackToLoginBtn.Location = new Point(902, 548);
            goBackToLoginBtn.Name = "goBackToLoginBtn";
            goBackToLoginBtn.Size = new Size(98, 19);
            goBackToLoginBtn.TabIndex = 7;
            goBackToLoginBtn.Click += goBackToLoginBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.Transparent;
            searchBtn.Cursor = Cursors.Hand;
            searchBtn.Location = new Point(703, 361);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(420, 51);
            searchBtn.TabIndex = 8;
            searchBtn.Click += searchBtn_Click;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1200, 650);
            Controls.Add(searchBtn);
            Controls.Add(goBackToLoginBtn);
            Controls.Add(exitBtn);
            Controls.Add(fullNameTextBox);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgotPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fullNameTextBox;
        private Panel exitBtn;
        private Panel goBackToLoginBtn;
        private Panel searchBtn;
    }
}