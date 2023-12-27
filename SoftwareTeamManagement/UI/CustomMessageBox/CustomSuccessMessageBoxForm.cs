using System.Drawing.Drawing2D;

namespace SoftwareTeamManagement.UI.CustomMessageBox
{
    public partial class CustomSuccessMessageBoxForm : Form
    {

        public CustomSuccessMessageBoxForm(string text)
        {
            InitializeComponent();
            warningText.Text = text;
            warningText.UseCompatibleTextRendering = true;
            warningText.AutoSize = false;
            this.SetRoundForm(this, 45);
            this.ShowDialog();


        }





        private void SetRoundForm(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            control.Region = new Region(path);
        }

        private void exitBtn_Click_1(object sender, EventArgs e)
        {

            this.Dispose();


        }
    }
}
