using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student_Results
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] Roll = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"};
            string[] Name = {"Charan", "Hare Ram", "Nikhila", "Navya", "Adnan", "Vamsi", "Tanmayii", "Dniesh", "Rahul", "Chitanya"};

            string[] Hin = {"89", "78", "75", "85", "74", "82", "73", "80", "70", "81" };
            string[] Eng = { "80", "68", "85", "78", "65", "50", "80", "70", "52", "62"};
            string[] Math = { "95", "92", "81", "72", "70", "50", "90", "70", "80", "62"};
            string[] Phy = { "90", "80", "58", "91", "85", "80", "60", "70", "50", "80"};
            string[] Che = { "95", "80", "78", "27", "45", "78", "56", "50", "70", "80"};
        }
    }
}