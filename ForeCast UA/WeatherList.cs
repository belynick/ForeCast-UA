using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeCast_UA
{
    public class WeatherList
    {
        public MainInfo Main { get; set; }
        public WeatherInfo[] Weather { get; set; }
        public WindInfo Wind { get; set; }
        public CloudsInfo Clouds { get; set; }

        public string dt_txt { get; set; }
    }
}
