namespace SoftwareTeamManagement.UI.Register.View
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            goBackToLoginBtn = new Panel();
            exitBtn = new Panel();
            fullNameTextBox = new TextBox();
            registerBtn = new Panel();
            emailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            confirmPasswordTextBox = new TextBox();
            SuspendLayout();
            // 
            // goBackToLoginBtn
            // 
            goBackToLoginBtn.BackColor = Color.Transparent;
            goBackToLoginBtn.Cursor = Cursors.Hand;
            goBackToLoginBtn.Location = new Point(941, 604);
            goBackToLoginBtn.Name = "goBackToLoginBtn";
            goBackToLoginBtn.Size = new Size(98, 19);
            goBackToLoginBtn.TabIndex = 2;

            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Transparent;
            exitBtn.Cursor = Cursors.Hand;
            exitBtn.Location = new Point(1145, 2);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(53, 43);
            exitBtn.TabIndex = 3;
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.BackColor = Color.FromArgb(95, 111, 115);
            fullNameTextBox.BorderStyle = BorderStyle.None;
            fullNameTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            fullNameTextBox.ForeColor = Color.White;
            fullNameTextBox.Location = new Point(704, 231);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(409, 36);
            fullNameTextBox.TabIndex = 4;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.Transparent;
            registerBtn.Cursor = Cursors.Hand;
            registerBtn.Location = new Point(704, 537);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(420, 51);
            registerBtn.TabIndex = 8;
  

            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.FromArgb(95, 111, 115);
            emailTextBox.BorderStyle = BorderStyle.None;
            emailTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextBox.ForeColor = Color.White;
            emailTextBox.Location = new Point(704, 320);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(409, 36);
            emailTextBox.TabIndex = 9;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.FromArgb(95, 111, 115);
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.ForeColor = Color.White;
            passwordTextBox.Location = new Point(704, 404);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(409, 36);
            passwordTextBox.TabIndex = 10;
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.BackColor = Color.FromArgb(95, 111, 115);
            confirmPasswordTextBox.BorderStyle = BorderStyle.None;
            confirmPasswordTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            confirmPasswordTextBox.ForeColor = Color.White;
            confirmPasswordTextBox.Location = new Point(704, 482);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.PasswordChar = '*';
            confirmPasswordTextBox.Size = new Size(409, 36);
            confirmPasswordTextBox.TabIndex = 11;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1200, 650);
            Controls.Add(confirmPasswordTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(registerBtn);
            Controls.Add(fullNameTextBox);
            Controls.Add(exitBtn);
            Controls.Add(goBackToLoginBtn);
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel goBackToLoginBtn;
        private Panel exitBtn;
        private TextBox fullNameTextBox;
        private Panel registerBtn;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private TextBox confirmPasswordTextBox;
    }
}