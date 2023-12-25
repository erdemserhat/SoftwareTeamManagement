namespace SoftwareTeamManagement.UI.Login.View
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            loginBtn = new Panel();
            exitBtn = new Panel();
            registerBtn = new Panel();
            emailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            forgotPasswordBtn = new Panel();
            SuspendLayout();
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Transparent;
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.Location = new Point(701, 467);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(420, 51);
            loginBtn.TabIndex = 0;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Transparent;
            exitBtn.Cursor = Cursors.Hand;
            exitBtn.Location = new Point(1144, 0);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(55, 46);
            exitBtn.TabIndex = 1;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.Transparent;
            registerBtn.Cursor = Cursors.Hand;
            registerBtn.Location = new Point(939, 537);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(113, 20);
            registerBtn.TabIndex = 1;
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.FromArgb(95, 111, 115);
            emailTextBox.BorderStyle = BorderStyle.None;
            emailTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextBox.ForeColor = Color.White;
            emailTextBox.Location = new Point(701, 265);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(405, 36);
            emailTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.FromArgb(95, 111, 115);
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.ForeColor = Color.White;
            passwordTextBox.Location = new Point(701, 374);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(405, 36);
            passwordTextBox.TabIndex = 3;
            // 
            // forgotPasswordBtn
            // 
            forgotPasswordBtn.BackColor = Color.Transparent;
            forgotPasswordBtn.Cursor = Cursors.Hand;
            forgotPasswordBtn.Location = new Point(1008, 416);
            forgotPasswordBtn.Name = "forgotPasswordBtn";
            forgotPasswordBtn.Size = new Size(113, 27);
            forgotPasswordBtn.TabIndex = 2;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1200, 650);
            Controls.Add(forgotPasswordBtn);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(registerBtn);
            Controls.Add(exitBtn);
            Controls.Add(loginBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Panel loginBtn;
        private Panel exitBtn;
        private Panel registerBtn;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private Panel forgotPasswordBtn;
    }
}