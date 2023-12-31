namespace SoftwareTeamManagement.UI.Splash.View
{
    partial class SplashScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreenForm));
            progress = new Panel();
            progressbar = new Panel();
            progressStat = new Label();
            progressbar.SuspendLayout();
            SuspendLayout();
            // 
            // progress
            // 
            progress.BackColor = SystemColors.ActiveCaption;
            progress.Dock = DockStyle.Left;
            progress.Location = new Point(0, 0);
            progress.Name = "progress";
            progress.Size = new Size(55, 50);
            progress.TabIndex = 0;
            // 
            // progressbar
            // 
            progressbar.Controls.Add(progress);
            progressbar.Dock = DockStyle.Bottom;
            progressbar.Location = new Point(0, 600);
            progressbar.Name = "progressbar";
            progressbar.Size = new Size(1200, 50);
            progressbar.TabIndex = 1;
            // 
            // progressStat
            // 
            progressStat.AutoSize = true;
            progressStat.BackColor = Color.Transparent;
            progressStat.Font = new Font("Abhaya Libre Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            progressStat.ForeColor = SystemColors.ButtonFace;
            progressStat.Location = new Point(12, 560);
            progressStat.Name = "progressStat";
            progressStat.Size = new Size(0, 27);
            progressStat.TabIndex = 2;
            // 
            // SplashScreenForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1200, 650);
            Controls.Add(progressStat);
            Controls.Add(progressbar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreenForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashScreenForm";
            progressbar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel progress;
        private Panel progressbar;
        private Label progressStat;
    }
}