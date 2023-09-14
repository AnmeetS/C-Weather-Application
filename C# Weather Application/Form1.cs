using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace C__Weather_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            callWeather();
        }
        string APIKey = "7140b40b4efa2d0578fd7191418c310d"; // Key to access the data from the API
        void callWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", locationInput.Text, APIKey); //Creates a web client that searches for the URL including the name of the city and the API key to access the data
                var json = web.DownloadString(url); //downloads the data provided from the url as a json string
                WeatherData.root Data = JsonConvert.DeserializeObject<WeatherData.root>(json); //Deserializes and converts the string in to usable data for our program

                labType.Text = Data.weather[0].main;//takes the main information in the main class of the in the data and puts it as text in the variable labType
                labDetails.Text = Data.weather[0].description;
                labTemp.Text = Data.main.temp.ToString() + "K";
                labFL.Text = Data.main.feels_like.ToString() + "K";
                labPressure.Text = Data.main.pressure.ToString() + "Pa";
                labWS.Text = Data.wind.speed.ToString() + "km/h";
                labSunrise.Text = convertDT(Data.sys.sunrise).ToShortTimeString();
                labSunset.Text = convertDT(Data.sys.sunset).ToShortTimeString();
            }
        }
        DateTime convertDT(long Second)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc). ToLocalTime();
            day = day.AddSeconds(Second).ToLocalTime();

            return day;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
