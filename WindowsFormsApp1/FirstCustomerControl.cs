using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;//"Project" -> "Manage NuGet packages" -> "Search for "newtonsoft json". -> click "install".

namespace WindowsFormsApp1
{
    public partial class FirstCustomerControl : UserControl
    {
        

        public FirstCustomerControl()
        {
            InitializeComponent();

        }
        string ConvertString(string s , int max)
        {
            string snew = "";
            int c = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (c > max && s[i] == ' ')
                {
                    snew += '\n'; c = 0; continue;
                }
                snew += s[i];
                c++;
            }
            return snew;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

    }
}
