using SoftwareTeamManagement.UI.SprintMateDashboard.Tasks.Presenter;

namespace SoftwareTeamManagement.UI.SprintMateDashboard.Tasks.View
{
    public partial class AddTaskFrame : Form, IAddTaskFrame
    {
        private static AddTaskFrame instance;

        //to hold selectedPrio.
        private string? selectedPriority;

        public string? Title => titleTextBox.Text;

        public string? Description => descriptionTextBox.Text;

        public string? Priority => selectedPriority;

        public event EventHandler ExitButtonClicked;
        public event EventHandler SaveButtonClicked;


        public AddTaskFrame()
        {

            InitializeComponent();
            instance = this;
            AddTaskController controller = new AddTaskController();
            exitBtn.Click += (sender, e) => ExitButtonClicked?.Invoke(this, EventArgs.Empty);
            saveBtn.Click += (sender, e) => SaveButtonClicked?.Invoke(this, EventArgs.Empty);
            Button acceptButton = new Button();
            acceptButton.Click += (sender, e) => { SaveButtonClicked.Invoke(sender, e); };
            this.AcceptButton = acceptButton;




        }

        public static AddTaskFrame GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new AddTaskFrame();
            }


            return instance;
        }

        //Normally, this class should not contain any logic, but it's easy to handle this situation here.
        private void priorityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (priorityListBox.SelectedIndex != -1)
            {
                object selectedObject = priorityListBox.SelectedItem;
                string content = selectedObject.ToString();
                selectedPriority = content;



            }
            else
            {
                selectedPriority = null;
            }
        }

        public void ClearSelections()
        {
            titleTextBox.Text = string.Empty;
            descriptionTextBox.Text = string.Empty;
            priorityListBox.SelectedIndex = -1;
        }

        private void AddTaskFrame_Load(object sender, EventArgs e)
        {

        }
    }
}
