using SoftwareTeamManagement.UI.Login.View;
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

namespace SoftwareTeamManagement.UI.Splash.View
{
    public partial class SplashScreenForm : Form
    {
        //Assinging essential properties for Progress Bar implementation...
        private Timer timer;
        private int targetValue = 1200;
        private int currentValue = 0;
        private int progressStatusTargetValue;
        private int currentStatusValue = 0;

        private readonly string[] progressStatus = new string[]
        {
            "Loading files...",
            "Updating database...",
            "Process in progress...",
            "Checking files...",
            "Processing data...",
            "Moving to the next step...",
            "Process ongoing...",
            "Checking performed tasks...",
            "Process nearing completion...",
            "Final check...",
            "Process completed!"


        };



        public SplashScreenForm()
        {
            InitializeComponent();
            progressStatusTargetValue = progressStatus.Length;


            //When form is started,the timer starts counting
            timer = new Timer();
            // timer.Interval sets the "Timer Frequency", for example  if you set 10, this means that your timer tick tocks every 10 milliseconds. :)
            timer.Interval = 1000;
            //timer.Tick sets the event which will be trigered in every frequency circle...
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void SplashScreenForm_Load(object sender, EventArgs e)
        {
            progress.Width = 0;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            currentValue += 30; ; ; // Her zamanlayıcı tetiklendiğinde değeri artırın
            currentStatusValue++;

            if (currentValue <= targetValue)
            {
                progress.Width += currentValue;
            }
            if (currentStatusValue < progressStatusTargetValue)
            {
                progressStat.Text = progressStatus[currentStatusValue];
            }

            else
            {
                timer.Stop();
                LoginForm.GetInstance().Show();
                this.Hide();

            }
        }


    }
}
