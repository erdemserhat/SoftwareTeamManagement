using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTeamManagement.UI.SprintMateDashboard.Meetings.View
{
    public partial class Meetings : UserControl
    {
        public Meetings()
        {
            InitializeComponent();
        }

        //Implementing singleton...

        private static Meetings instance;

    }
}
