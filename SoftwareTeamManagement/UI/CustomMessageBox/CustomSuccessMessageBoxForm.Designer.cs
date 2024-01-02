namespace SoftwareTeamManagement.UI.CustomMessageBox
{
    partial class CustomSuccessMessageBoxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomSuccessMessageBoxForm));
            panel1 = new Panel();
            warningText = new Label();
            exitBtn = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(warningText);
            panel1.Location = new Point(15, 137);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 141);
            panel1.TabIndex = 5;
            // 
            // warningText
            // 
            warningText.AutoSize = true;
            warningText.BackColor = Color.Transparent;
            warningText.Dock = DockStyle.Fill;
            warningText.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            warningText.ForeColor = Color.Transparent;
            warningText.Location = new Point(0, 0);
            warningText.Name = "warningText";
            warningText.Size = new Size(178, 38);
            warningText.TabIndex = 3;
            warningText.Text = "Warning Text";
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Transparent;
            exitBtn.Cursor = Cursors.Hand;
            exitBtn.Location = new Point(130, 289);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(133, 43);
            exitBtn.TabIndex = 6;
            exitBtn.Click += exitBtn_Click_1;
            // 
            // CustomSuccessMessageBoxForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(375, 344);
            Controls.Add(exitBtn);
            Controls.Add(panel1);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomSuccessMessageBoxForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomSuccessMessageBox";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label warningText;
        private Panel exitBtn;
    }
}