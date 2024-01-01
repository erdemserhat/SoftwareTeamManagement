namespace SoftwareTeamManagement.UI.SprintMateDashboard.Team.View
{
    partial class TeamSection
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            generalContainer = new Panel();
            headerContainer = new Panel();
            titleText = new Label();
            listView1 = new ListView();
            generalContainer.SuspendLayout();
            headerContainer.SuspendLayout();
            SuspendLayout();
            // 
            // generalContainer
            // 
            generalContainer.BackColor = SystemColors.AppWorkspace;
            generalContainer.Controls.Add(listView1);
            generalContainer.Controls.Add(headerContainer);
            generalContainer.Dock = DockStyle.Fill;
            generalContainer.Location = new Point(0, 0);
            generalContainer.Name = "generalContainer";
            generalContainer.Size = new Size(900, 650);
            generalContainer.TabIndex = 0;
            // 
            // headerContainer
            // 
            headerContainer.BackColor = SystemColors.ButtonShadow;
            headerContainer.Controls.Add(titleText);
            headerContainer.Dock = DockStyle.Top;
            headerContainer.Location = new Point(0, 0);
            headerContainer.Name = "headerContainer";
            headerContainer.Size = new Size(900, 75);
            headerContainer.TabIndex = 0;
            // 
            // titleText
            // 
            titleText.AutoSize = true;
            titleText.Font = new Font("Iceland", 28.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            titleText.ForeColor = Color.FromArgb(34, 40, 49);
            titleText.Location = new Point(354, 14);
            titleText.Name = "titleText";
            titleText.Size = new Size(179, 45);
            titleText.TabIndex = 1;
            titleText.Text = "My Team";
            // 
            // listView1
            // 
            listView1.Location = new Point(211, 144);
            listView1.Name = "listView1";
            listView1.Size = new Size(151, 121);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // TeamSection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(generalContainer);
            Name = "TeamSection";
            Size = new Size(900, 650);
            generalContainer.ResumeLayout(false);
            headerContainer.ResumeLayout(false);
            headerContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel generalContainer;
        private Panel headerContainer;
        private Label titleText;
        private ListView listView1;
    }
}
