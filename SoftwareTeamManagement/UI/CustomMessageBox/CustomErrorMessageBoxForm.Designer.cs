namespace SoftwareTeamManagement.UI.CustomMessageBox
{
    partial class CustomErrorMessageBoxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomErrorMessageBoxForm));
            exitBtn = new Panel();
            warningText = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Transparent;
            exitBtn.Cursor = Cursors.Hand;
            exitBtn.Location = new Point(131, 286);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(132, 46);
            exitBtn.TabIndex = 2;
            exitBtn.Click += exitBtn_Click;
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
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(warningText);
            panel1.Location = new Point(24, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 163);
            panel1.TabIndex = 4;
            // 
            // CustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(393, 344);
            Controls.Add(panel1);
            Controls.Add(exitBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomMessageBox";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomMessageBox";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel exitBtn;
        private Label warningText;
        private Panel panel1;
    }
}