using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.UI.SprintMateDashboard.Controller
{
    internal class Class1 : IClass1
    {
        //ctr r + e
        private string a;
        private string b;

        // select methods and ctrl r +ı extract interface and di
        //ctrl r +o reorder parameters
        //crtl r+r rename whole parameter's name
        //ctrl k +s surround with 
        //ctrl u make lower case
        //ctrl shift u upperc

        public Class1(string serhaterdem, string SerhatErdem) { 
        
        }


        
        public string A { get => a; set => a = value; }
        public string B { get => b; set => b = value; }
    }
}
