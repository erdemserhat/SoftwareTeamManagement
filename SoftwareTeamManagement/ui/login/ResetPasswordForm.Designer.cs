namespace SoftwareTeamManagement.ui.login
{
    partial class ResetPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPasswordForm));
            exitBtn = new Panel();
            resetPasswordTextBox = new TextBox();
            resetPasswordConfirmTextBox = new TextBox();
            resetPasswordButton = new Panel();
            registerBtn = new Panel();
            SuspendLayout();
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Transparent;
            exitBtn.Cursor = Cursors.Hand;
            exitBtn.Location = new Point(1144, 0);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(55, 46);
            exitBtn.TabIndex = 2;
            exitBtn.Click += exitBtn_Click;
            // 
            // resetPasswordTextBox
            // 
            resetPasswordTextBox.BackColor = Color.FromArgb(95, 111, 115);
            resetPasswordTextBox.BorderStyle = BorderStyle.None;
            resetPasswordTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            resetPasswordTextBox.ForeColor = Color.White;
            resetPasswordTextBox.Location = new Point(705, 310);
            resetPasswordTextBox.Name = "resetPasswordTextBox";
            resetPasswordTextBox.Size = new Size(405, 36);
            resetPasswordTextBox.TabIndex = 3;
            // 
            // resetPasswordConfirmTextBox
            // 
            resetPasswordConfirmTextBox.BackColor = Color.FromArgb(95, 111, 115);
            resetPasswordConfirmTextBox.BorderStyle = BorderStyle.None;
            resetPasswordConfirmTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            resetPasswordConfirmTextBox.ForeColor = Color.White;
            resetPasswordConfirmTextBox.Location = new Point(705, 401);
            resetPasswordConfirmTextBox.Name = "resetPasswordConfirmTextBox";
            resetPasswordConfirmTextBox.Size = new Size(405, 36);
            resetPasswordConfirmTextBox.TabIndex = 4;
            // 
            // resetPasswordButton
            // 
            resetPasswordButton.BackColor = Color.Transparent;
            resetPasswordButton.Cursor = Cursors.Hand;
            resetPasswordButton.Location = new Point(705, 456);
            resetPasswordButton.Name = "resetPasswordButton";
            resetPasswordButton.Size = new Size(420, 51);
            resetPasswordButton.TabIndex = 5;
            resetPasswordButton.Click += resetPasswordButton_Click;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.Transparent;
            registerBtn.Cursor = Cursors.Hand;
            registerBtn.Location = new Point(908, 591);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(113, 20);
            registerBtn.TabIndex = 6;
            registerBtn.Click += registerBtn_Click;
            // 
            // ResetPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1200, 650);
            Controls.Add(registerBtn);
            Controls.Add(resetPasswordButton);
            Controls.Add(resetPasswordConfirmTextBox);
            Controls.Add(resetPasswordTextBox);
            Controls.Add(exitBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResetPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResetPasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel exitBtn;
        private TextBox resetPasswordTextBox;
        private TextBox resetPasswordConfirmTextBox;
        private Panel resetPasswordButton;
        private Panel registerBtn;
    }
}