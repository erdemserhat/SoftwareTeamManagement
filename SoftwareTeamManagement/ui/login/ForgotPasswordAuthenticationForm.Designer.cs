namespace SoftwareTeamManagement.ui.login
{
    partial class ForgotPasswordAuthenticationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordAuthenticationForm));
            authenticationCodeTextBox = new TextBox();
            exitBtn = new Panel();
            confirmButton = new Panel();
            goBackToLoginBtn = new Panel();
            SuspendLayout();
            // 
            // authenticationCodeTextBox
            // 
            authenticationCodeTextBox.BackColor = Color.FromArgb(95, 111, 115);
            authenticationCodeTextBox.BorderStyle = BorderStyle.None;
            authenticationCodeTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            authenticationCodeTextBox.ForeColor = Color.White;
            authenticationCodeTextBox.Location = new Point(704, 298);
            authenticationCodeTextBox.Name = "authenticationCodeTextBox";
            authenticationCodeTextBox.Size = new Size(405, 36);
            authenticationCodeTextBox.TabIndex = 3;
            authenticationCodeTextBox.KeyPress += authenticationCodeTextBox_KeyPress;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Transparent;
            exitBtn.Cursor = Cursors.Hand;
            exitBtn.Location = new Point(1144, 1);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(55, 46);
            exitBtn.TabIndex = 4;
            exitBtn.Click += exitBtn_Click;
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.Transparent;
            confirmButton.Cursor = Cursors.Hand;
            confirmButton.Location = new Point(704, 360);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(424, 51);
            confirmButton.TabIndex = 5;
            confirmButton.Click += confirmButton_Click;
            // 
            // goBackToLoginBtn
            // 
            goBackToLoginBtn.BackColor = Color.Transparent;
            goBackToLoginBtn.Cursor = Cursors.Hand;
            goBackToLoginBtn.Location = new Point(912, 546);
            goBackToLoginBtn.Name = "goBackToLoginBtn";
            goBackToLoginBtn.Size = new Size(88, 24);
            goBackToLoginBtn.TabIndex = 6;
            goBackToLoginBtn.Click += goBackToLoginBtn_Click;
            // 
            // ForgotPasswordAuthenticationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1200, 650);
            Controls.Add(goBackToLoginBtn);
            Controls.Add(confirmButton);
            Controls.Add(exitBtn);
            Controls.Add(authenticationCodeTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgotPasswordAuthenticationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPasswordAuthenticationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox authenticationCodeTextBox;
        private Panel exitBtn;
        private Panel confirmButton;
        private Panel goBackToLoginBtn;
    }
}