using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;


namespace ForeCast_UA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        string city;

        private void Form1_Load(object sender, EventArgs e)
        {
            ClientSize = new System.Drawing.Size(910, 510);
            FormBorderStyle = FormBorderStyle.FixedSingle;

            city = CityName.Text;
            string url = String.Format("https://api.openweathermap.org/data/2.5/forecast?q={0},ua&units=metric&lang=ua&&appid=e1fb48f13eefac68e436f8d673d4ccf5", city);
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }

            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);

            panel1.BackgroundImage = weatherResponse.List[0].Weather[0].WeatherIcon;

            label1.Text = $"Місто: {weatherResponse.City.Name} ({weatherResponse.City.Country})";

            label2.Text = $"Температура: {weatherResponse.List[0].Main.Temp} °C";
            label3.Text = $"Відчувається як: {weatherResponse.List[0].Main.Feels_Like} °C";
            label4.Text = $"Мінімальна температура: {weatherResponse.List[0].Main.Temp_Min} °C";
            label5.Text = $"Mаскимальна температура: {weatherResponse.List[0].Main.Temp_Max} °C";

            label6.Text = $"Швидкість вітру: {weatherResponse.List[0].Wind.Speed} м/с";
            label7.Text = $"Напрям вітру: {weatherResponse.List[0].Wind.Deg}°";

            label8.Text = $"Погода: {weatherResponse.List[0].Weather[0].Description}\n";
            label9.Text = $"Хмарність: {weatherResponse.List[0].Clouds.All}%";

            label10.Text = $"Тиск: {weatherResponse.List[0].Main.Pressure} гПа";
            label11.Text = $"Вологість: {weatherResponse.List[0].Main.Humidity}%";

            label12.Text = $"Дата: {weatherResponse.List[0].dt_txt}";
        }

        private void todayWeather_Click(object sender, EventArgs e)
        {
            city = CityName.Text;
            string url = String.Format("https://api.openweathermap.org/data/2.5/forecast?q={0},ua&units=metric&lang=ua&&appid=e1fb48f13eefac68e436f8d673d4ccf5", city);

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            string response;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }

            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);

            panel1.BackgroundImage = weatherResponse.List[0].Weather[0].WeatherIcon;

            label1.Text = $"Місто: {weatherResponse.City.Name} ({weatherResponse.City.Country})";

            label2.Text = $"Температура: {weatherResponse.List[0].Main.Temp} °C";
            label3.Text = $"Відчувається як: {weatherResponse.List[0].Main.Feels_Like} °C";
            label4.Text = $"Мінімальна температура: {weatherResponse.List[0].Main.Temp_Min} °C";
            label5.Text = $"Mаскимальна температура: {weatherResponse.List[0].Main.Temp_Max} °C";

            label6.Text = $"Швидкість вітру: {weatherResponse.List[0].Wind.Speed} м/с";
            label7.Text = $"Напрям вітру: {weatherResponse.List[0].Wind.Deg}°";

            label8.Text = $"Погода: {weatherResponse.List[0].Weather[0].Description}\n";
            label9.Text = $"Хмарність: {weatherResponse.List[0].Clouds.All}%";

            label10.Text = $"Тиск: {weatherResponse.List[0].Main.Pressure} гПа";
            label11.Text = $"Вологість: {weatherResponse.List[0].Main.Humidity}%";

            label12.Text = $"Дата: {weatherResponse.List[0].dt_txt}";
        }

        private void nextdayWeather_Click(object sender, EventArgs e)
        {
            city = CityName.Text;
            string url = String.Format("https://api.openweathermap.org/data/2.5/forecast?q={0},ua&units=metric&lang=ua&&appid=e1fb48f13eefac68e436f8d673d4ccf5", city);

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            string response;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }

            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);

            panel1.BackgroundImage = weatherResponse.List[8].Weather[0].WeatherIcon;

            label1.Text = $"Місто: {weatherResponse.City.Name} ({weatherResponse.City.Country})";

            label2.Text = $"Температура: {weatherResponse.List[8].Main.Temp} °C";
            label3.Text = $"Відчувається як: {weatherResponse.List[8].Main.Feels_Like} °C";
            label4.Text = $"Мінімальна температура: {weatherResponse.List[8].Main.Temp_Min} °C";
            label5.Text = $"Mаскимальна температура: {weatherResponse.List[8].Main.Temp_Max} °C";

            label6.Text = $"Швидкість вітру: {weatherResponse.List[8].Wind.Speed} м/с";
            label7.Text = $"Напрям вітру: {weatherResponse.List[8].Wind.Deg}°";

            label8.Text = $"Погода: {weatherResponse.List[8].Weather[0].Description}\n";
            label9.Text = $"Хмарність: {weatherResponse.List[8].Clouds.All}%";

            label10.Text = $"Тиск: {weatherResponse.List[8].Main.Pressure} гПа";
            label11.Text = $"Вологість: {weatherResponse.List[8].Main.Humidity}%";

            label12.Text = $"Дата: {weatherResponse.List[8].dt_txt}";
        }
    }
}

