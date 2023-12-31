using SoftwareTeamManagement.UI.SprintMateDashboard.Projects.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Timer = System.Windows.Forms.Timer;

namespace SoftwareTeamManagement.UI.SprintMateDashboard.Projects.View
{
    public partial class ProjectSection : UserControl, IProjectSection
    {
        private System.Windows.Forms.Timer marqueeTimer;
        //Assigning singleton object of class
        private static ProjectSection instance;


        //Defining relevatn implementations which the form can do...
        public string ProjectTitle { set => projectTitleTB.Text = value; }
        public string ProjectDescription { set => projectDescriptionTB.Text = value; }

        public event EventHandler EditProjectButtonClicked;
        //Assigning the contoller object
        private ProjectSectionController controller;

        public static ProjectSection GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProjectSection();
            }

            return instance;
        }
        public ProjectSection()
        {
            InitializeComponent();
            //Declaring the singleton object
            ArrangeDescriptionText();


            instance = this;
            //initializing the controller when form starts for the first time....
            controller = new ProjectSectionController();
            //init.. events..
            InitializeEvents();

        }


        private void InitializeEvents()
        {
            editBtn.Click += (sender, e) => EditProjectButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        public void ArrangeDescriptionText()
        {
            // TextBox Arrangements...

            projectDescriptionTB.Multiline = true;
            //to cancel selection
            //categoryImage.Focus();
            //descriptionTB.Select(0, 0);
            //activating scrollable feature
            projectDescriptionTB.ScrollBars = ScrollBars.Vertical;
            projectDescriptionTB.Size = new Size(832, 407);
        }

        private void projectDescriptionBackgroundTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}
