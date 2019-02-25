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
					
		    string url2 = string.Format("https://api.weatherbit.io/v2.0/forecast/daily?key=d254147c15ba46b48bc8e608389ca984&city=" + textBox1.Text);
                    var Json2 = web.DownloadString(url2);
                    ForecastWeather.root oMycustomclassname2 = Newtonsoft.Json.JsonConvert.DeserializeObject<ForecastWeather.root>(Json2);

                    DATE1.Text = oMycustomclassname2.data.ElementAt(0).datetime;
                    AVGTemp1.Text = oMycustomclassname2.data.ElementAt(0).temp + "\u00B0C";
                    MAXTemp1.Text = oMycustomclassname2.data.ElementAt(0).max_temp + "\u00B0C";
                    MINTemp1.Text = oMycustomclassname2.data.ElementAt(0).min_temp + "\u00B0C";
                    DATE2.Text = oMycustomclassname2.data.ElementAt(1).datetime;
                    AVGTemp2.Text = oMycustomclassname2.data.ElementAt(1).temp + "\u00B0C";
                    MAXTemp2.Text = oMycustomclassname2.data.ElementAt(1).max_temp + "\u00B0C";
                    MINTemp2.Text = oMycustomclassname2.data.ElementAt(1).min_temp + "\u00B0C";
                    DATE3.Text = oMycustomclassname2.data.ElementAt(2).datetime;
                    AVGTemp3.Text = oMycustomclassname2.data.ElementAt(2).temp + "\u00B0C";
                    MAXTemp3.Text = oMycustomclassname2.data.ElementAt(2).max_temp + "\u00B0C";
                    MINTemp3.Text = oMycustomclassname2.data.ElementAt(2).min_temp + "\u00B0C";
		
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
