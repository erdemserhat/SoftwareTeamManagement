namespace SoftwareTeamManagement.view.welcomeForm
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            welcomeFormRegisterationMailTextBox = new TextBox();
            WelcomeFormSignUpButton = new Button();
            welcomeFormLoginButton = new LinkLabel();
            SuspendLayout();
            // 
            // welcomeFormRegisterationMailTextBox
            // 
            welcomeFormRegisterationMailTextBox.BorderStyle = BorderStyle.None;
            welcomeFormRegisterationMailTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            welcomeFormRegisterationMailTextBox.Location = new Point(194, 592);
            welcomeFormRegisterationMailTextBox.Multiline = true;
            welcomeFormRegisterationMailTextBox.Name = "welcomeFormRegisterationMailTextBox";
            welcomeFormRegisterationMailTextBox.Size = new Size(397, 44);
            welcomeFormRegisterationMailTextBox.TabIndex = 0;
            // 
            // WelcomeFormSignUpButton
            // 
            WelcomeFormSignUpButton.AllowDrop = true;
            WelcomeFormSignUpButton.BackColor = Color.FromArgb(192, 0, 0);
            WelcomeFormSignUpButton.BackgroundImage = (Image)resources.GetObject("WelcomeFormSignUpButton.BackgroundImage");
            WelcomeFormSignUpButton.BackgroundImageLayout = ImageLayout.None;
            WelcomeFormSignUpButton.CausesValidation = false;
            WelcomeFormSignUpButton.Cursor = Cursors.Hand;
            WelcomeFormSignUpButton.FlatStyle = FlatStyle.Flat;
            WelcomeFormSignUpButton.ForeColor = Color.Transparent;
            WelcomeFormSignUpButton.Location = new Point(633, 592);
            WelcomeFormSignUpButton.Name = "WelcomeFormSignUpButton";
            WelcomeFormSignUpButton.Size = new Size(131, 45);
            WelcomeFormSignUpButton.TabIndex = 1;
            WelcomeFormSignUpButton.UseVisualStyleBackColor = false;
            WelcomeFormSignUpButton.Click += WelcomeFormSignUpButton_Click;
            // 
            // welcomeFormLoginButton
            // 
            welcomeFormLoginButton.AutoSize = true;
            welcomeFormLoginButton.BackColor = SystemColors.ControlLightLight;
            welcomeFormLoginButton.DisabledLinkColor = Color.White;
            welcomeFormLoginButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            welcomeFormLoginButton.Location = new Point(1675, 23);
            welcomeFormLoginButton.Name = "welcomeFormLoginButton";
            welcomeFormLoginButton.Size = new Size(186, 41);
            welcomeFormLoginButton.TabIndex = 2;
            welcomeFormLoginButton.TabStop = true;
            welcomeFormLoginButton.Text = "Oturum Açın";
            welcomeFormLoginButton.LinkClicked += welcomeFormLoginButton_LinkClicked;
            // 
            // WelcomeForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoScroll = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1884, 849);
            Controls.Add(welcomeFormLoginButton);
            Controls.Add(WelcomeFormSignUpButton);
            Controls.Add(welcomeFormRegisterationMailTextBox);
            Name = "WelcomeForm";
            Text = "WelcomeForm";
            Load += WelcomeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox welcomeFormRegisterationMailTextBox;
        private Button WelcomeFormSignUpButton;
        private LinkLabel welcomeFormLoginButton;
    }
}