using System.Drawing;

namespace ForeCast_UA
{
    public class WeatherInfo
    {
        public string Description { get; set; }
        public string Icon { get; set; }

        public Bitmap WeatherIcon
        {
            get
            {
                return new Bitmap(Image.FromFile($"WeatherIcons/{Icon}.png"));
            }
        }
    }
}

