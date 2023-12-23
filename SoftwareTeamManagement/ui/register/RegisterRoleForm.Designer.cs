namespace SoftwareTeamManagement.ui.register
{
    partial class RegisterRoleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterRoleForm));
            exitBtn = new Panel();
            nextBtn = new Panel();
            departmentTextBox = new TextBox();
            roleTextBox = new TextBox();
            SuspendLayout();
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Transparent;
            exitBtn.Cursor = Cursors.Hand;
            exitBtn.Location = new Point(1146, 1);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(53, 43);
            exitBtn.TabIndex = 4;
            exitBtn.Click += exitBtn_Click;
            // 
            // nextBtn
            // 
            nextBtn.BackColor = Color.Transparent;
            nextBtn.Cursor = Cursors.Hand;
            nextBtn.Location = new Point(703, 467);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(420, 51);
            nextBtn.TabIndex = 9;
            nextBtn.Click += nextBtn_Click;
            // 
            // departmentTextBox
            // 
            departmentTextBox.BackColor = Color.FromArgb(95, 111, 115);
            departmentTextBox.BorderStyle = BorderStyle.None;
            departmentTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            departmentTextBox.ForeColor = Color.White;
            departmentTextBox.Location = new Point(703, 378);
            departmentTextBox.Name = "departmentTextBox";
            departmentTextBox.Size = new Size(409, 36);
            departmentTextBox.TabIndex = 5;
            // 
            // roleTextBox
            // 
            roleTextBox.BackColor = Color.FromArgb(95, 111, 115);
            roleTextBox.BorderStyle = BorderStyle.None;
            roleTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            roleTextBox.ForeColor = Color.White;
            roleTextBox.Location = new Point(703, 270);
            roleTextBox.Name = "roleTextBox";
            roleTextBox.Size = new Size(409, 36);
            roleTextBox.TabIndex = 10;
            // 
            // RegisterRoleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1200, 650);
            Controls.Add(roleTextBox);
            Controls.Add(departmentTextBox);
            Controls.Add(nextBtn);
            Controls.Add(exitBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterRoleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterRoleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel exitBtn;
        private Panel registerBtn;
        private Panel nextBtn;
        private TextBox departmentTextBox;
        private TextBox roleTextBox;
    }
}