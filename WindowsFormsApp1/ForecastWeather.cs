using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ForecastWeather
    {
       public class data
        {
            public string temp { get; set; }
            public string max_temp { get; set; }
            public string min_temp { get; set; }
            public string datetime { get; set; }
        }
        public class root
        {
            public List<data> data { get; set; }
        }
    }
}
