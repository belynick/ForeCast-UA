using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeCast_UA
{
    public class WeatherResponse
    {
        public WeatherList[] List { get; set; }
        public CityInfo City { get; set; }
    }
}
