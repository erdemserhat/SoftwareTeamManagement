namespace SoftwareTeamManagement.ui.registerForm.UltimateRegisterForm
{
    partial class UltimateRegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UltimateRegisterForm));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Devam = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(742, 403);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(397, 44);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(742, 497);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(397, 44);
            textBox2.TabIndex = 2;
            // 
            // Devam
            // 
            Devam.BackColor = Color.Transparent;
            Devam.ForeColor = Color.Transparent;
            Devam.Location = new Point(764, 725);
            Devam.Name = "Devam";
            Devam.Size = new Size(252, 58);
            Devam.TabIndex = 3;
            Devam.Text = "Devam";
            Devam.UseVisualStyleBackColor = false;
            Devam.Click += Devam_Click;
            // 
            // UltimateRegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1887, 848);
            Controls.Add(Devam);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "UltimateRegisterForm";
            Text = "UltimateRegisterForm";
            Load += UltimateRegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button Devam;
    }
}