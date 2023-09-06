using AppWeather.Model;
using Newtonsoft.Json;
using System.Net;

namespace BookingSytem
{
    class ApiConfig
    {
        static string APPID = "3ad3bbc4ae8ad572fc1b8252553aeb26";
        static string accessToken = "9F6520E9-78E04316-A5E4B8E9-4BE9D46B";

        public static WeatherModel.RootObject getOneDayWeather(string cityName)
        {
            string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&APPID={1}&units=metric", cityName, APPID);
            WebClient client = new WebClient();
            try
            {
                var json = client.DownloadString(url);
                var result = JsonConvert.DeserializeObject<WeatherModel.RootObject>(json);
                WeatherModel.RootObject weatherData = result;
                return weatherData;
            }
            catch (WebException e)
            {
                return null;
            }
        }


        public static Loadsheddingmobel.RootObject Loadsheeding()
        {
            string url = string.Format("https://developer.sepush.co.za/business/2.0/status");
            WebClient client = new WebClient();
            client.Headers.Add("token:" + accessToken);
            try
            {
                
                var json = client.DownloadString(url);
                var result = JsonConvert.DeserializeObject<Loadsheddingmobel.RootObject>(json);
                Loadsheddingmobel.RootObject LoadsheddingData = result;
                return LoadsheddingData;
            }
            catch (WebException e)
            {
                return null;
            }
        }



    }

}

