using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CurrentWeather
    {
        public class data
        {
            public string timezone { get; set; }
            public string city_name { get; set; }
            public string temp { get; set; }

        }
        public class root
        {
            public List<data> data { get; set; }
        }
    }
}
