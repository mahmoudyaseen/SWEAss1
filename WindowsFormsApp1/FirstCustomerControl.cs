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
        string text = "";

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
            try
            {
                using (WebClient web = new WebClient())
                {
                    string url = string.Format("http://www.omdbapi.com/?apikey=c569ac12&t=" + textBox1.Text);
                    var Json = web.DownloadString(url);
                    omdbAPI.root oMycustomclassname = Newtonsoft.Json.JsonConvert.DeserializeObject<omdbAPI.root>(Json);
                    Title.Text = oMycustomclassname.Title;
                    Year.Text = oMycustomclassname.Year;
                    RunTime.Text = oMycustomclassname.Runtime;
                    Genre.Text = oMycustomclassname.Genre;
                    Director.Text = oMycustomclassname.Director;
                    Actors.Text = ConvertString(oMycustomclassname.Actors,70);
                    text = oMycustomclassname.Plot;
                    Plot.Text = ConvertString(oMycustomclassname.Plot,70);
                    Awards.Text = oMycustomclassname.Awards;
                    Type.Text = oMycustomclassname.Type;
                    Ratings.Text = "";
                    for(int i = 0; i < oMycustomclassname.Ratings.Count ; i++)
                    {
                        Ratings.Text += oMycustomclassname.Ratings.ElementAt(i).Source + "   :   " + oMycustomclassname.Ratings.ElementAt(i).Value + '\n';
                    }
                    Ratings.Text += "imdbRating    :    " + oMycustomclassname.imdbRating + "\nimdbVotes    :    " + oMycustomclassname.imdbVotes;
                    var request = WebRequest.Create(oMycustomclassname.Poster);
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                    }

                }
            }
            catch
            {
                MessageBox.Show("Please enter valid name", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (WebClient web = new WebClient())
                {
                    string url = string.Format("https://translate.yandex.net/api/v1.5/tr.json/translate?key=trnsl.1.1.20190223T151144Z.5e7f83992efd513c.761dea1290b64a0e5fdac11dbd3486151b0a970b&lang=en-fr&text=" + text);
                    var Json = web.DownloadString(url);
                    TranslatedObj.root oMycustomclassname = Newtonsoft.Json.JsonConvert.DeserializeObject<TranslatedObj.root>(Json);
                    Plot.Text = ConvertString(oMycustomclassname.text.ElementAt(0),70);
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
