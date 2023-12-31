namespace SoftwareTeamManagement.UI.SprintMateDashboard.Tasks.View
{
    partial class TaskViewerFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskViewerFrame));
            descriptionTB = new TextBox();
            priorityImage = new PictureBox();
            categoryImage = new PictureBox();
            titleTB = new TextBox();
            taskDateAndNo = new Label();
            exitBtn = new Panel();
            ((System.ComponentModel.ISupportInitialize)priorityImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryImage).BeginInit();
            SuspendLayout();
            // 
            // descriptionTB
            // 
            descriptionTB.BackColor = Color.FromArgb(95, 111, 115);
            descriptionTB.BorderStyle = BorderStyle.None;
            descriptionTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionTB.ForeColor = Color.White;
            descriptionTB.Location = new Point(25, 141);
            descriptionTB.Multiline = true;
            descriptionTB.Name = "descriptionTB";
            descriptionTB.Size = new Size(323, 27);
            descriptionTB.TabIndex = 1;
            descriptionTB.KeyPress += descriptionTB_KeyPress;
            // 
            // priorityImage
            // 
            priorityImage.BackColor = Color.Transparent;
            priorityImage.Location = new Point(39, 339);
            priorityImage.Name = "priorityImage";
            priorityImage.Size = new Size(151, 136);
            priorityImage.TabIndex = 2;
            priorityImage.TabStop = false;
            // 
            // categoryImage
            // 
            categoryImage.BackColor = Color.Transparent;
            categoryImage.Location = new Point(217, 339);
            categoryImage.Name = "categoryImage";
            categoryImage.Size = new Size(151, 136);
            categoryImage.TabIndex = 3;
            categoryImage.TabStop = false;
            // 
            // titleTB
            // 
            titleTB.BackColor = Color.FromArgb(95, 111, 115);
            titleTB.BorderStyle = BorderStyle.None;
            titleTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleTB.ForeColor = Color.White;
            titleTB.Location = new Point(25, 94);
            titleTB.Multiline = true;
            titleTB.Name = "titleTB";
            titleTB.Size = new Size(323, 27);
            titleTB.TabIndex = 4;
            titleTB.Text = "Android Feature Tabanı Hakkında";
            titleTB.KeyPress += titleTB_KeyPress;
            // 
            // taskDateAndNo
            // 
            taskDateAndNo.AutoSize = true;
            taskDateAndNo.BackColor = Color.Transparent;
            taskDateAndNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            taskDateAndNo.ForeColor = Color.White;
            taskDateAndNo.Location = new Point(12, 297);
            taskDateAndNo.Name = "taskDateAndNo";
            taskDateAndNo.Size = new Size(250, 28);
            taskDateAndNo.TabIndex = 5;
            taskDateAndNo.Text = "2023-12-29 05:31:26  #122";
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Transparent;
            exitBtn.Cursor = Cursors.Hand;
            exitBtn.Location = new Point(338, 12);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(37, 33);
            exitBtn.TabIndex = 6;
            // 
            // TaskViewerFrame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(380, 497);
            Controls.Add(exitBtn);
            Controls.Add(taskDateAndNo);
            Controls.Add(titleTB);
            Controls.Add(categoryImage);
            Controls.Add(priorityImage);
            Controls.Add(descriptionTB);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "TaskViewerFrame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaskViewerFrame";
            Load += TaskViewerFrame_Load;
            ((System.ComponentModel.ISupportInitialize)priorityImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox descriptionTB;
        private PictureBox pictureBox1;
        private PictureBox priorityImage;
        private PictureBox categoryImage;
        private Label taskDateAndNo;
        private Panel exitBtn;
        private TextBox titleTB;
    }
}