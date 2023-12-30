using SoftwareTeamManagement.UI.SprintMateDashboard.Tasks.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTeamManagement.UI.SprintMateDashboard.Tasks.View
{
    public partial class DeleteTaskFrame : Form, IDeleteTaskFrame
    {
        //assigning the singleton object
        private static DeleteTaskFrame instance;
        public string Id;

        public DeleteTaskFrame()
        {
            InitializeComponent();
            instance = this;
            DeleteTaskController controller = new DeleteTaskController();
            InitializeEvents();
            Button acceptButton = new Button();
            acceptButton.Click += (sender, e) => { DeleteButtonClicked.Invoke(sender, e); };
            this.AcceptButton = acceptButton;
           
        }



        public event EventHandler DeleteButtonClicked;
        public event EventHandler ExitButtonClicked;

        //implementing singleton method
        public static DeleteTaskFrame GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new DeleteTaskFrame();
            }

            return instance;
        }

        //this method initializes the events for controller

        private void InitializeEvents()
        {
            deleteBtn.Click += (sender, e) => DeleteButtonClicked?.Invoke(this, EventArgs.Empty);
            exitBtn.Click += (sender, e) => ExitButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        public void ProvideTaskInformation(string title, string no)
        {
            taskInformation.Text = $"{title} #{no}";
            Id = no;
        }

        private void DeleteTaskFrame_Enter(object sender, EventArgs e)
        {
            DeleteButtonClicked?.Invoke(sender, e);
        }


    }
}
