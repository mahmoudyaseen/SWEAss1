using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;//"Project" -> "Manage NuGet packages" -> "Search for "newtonsoft json". -> click "install".
using System.Net;

namespace WindowsFormsApp1
{
    public partial class SecondCustomerControl : UserControl
    {
        public SecondCustomerControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (WebClient web = new WebClient())
                {
                    string url = string.Format("https://api.weatherbit.io/v2.0/current?key=d254147c15ba46b48bc8e608389ca984&city=" + textBox1.Text);
                    var Json = web.DownloadString(url);
                    CurrentWeather.root oMycustomclassname = Newtonsoft.Json.JsonConvert.DeserializeObject<CurrentWeather.root>(Json);
                    CurentTemp.Text = oMycustomclassname.data.ElementAt(0).temp+ "\u00B0C";
                    city_name.Text = oMycustomclassname.data.ElementAt(0).city_name;
                    timezone.Text = oMycustomclassname.data.ElementAt(0).timezone;
					
					
                }
            }
            catch
            {
                MessageBox.Show("Please enter valid name", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
