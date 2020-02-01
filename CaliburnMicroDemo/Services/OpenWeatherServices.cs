using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace OpenWeatherDemo.Services
{
    internal class OpenWeatherServices
    {
        public static async Task<string> GetCurrentWeatherAsync()
        {
            string location = "Galati";
            string units = "metric";
            string appid = "b18c89a19ac343dd1edd7c762c1def3f";

            string url = $"http://api.openweathermap.org/data/2.5/weather?q={location}&units={units}&appid={appid}";

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)await httpWebRequest.GetResponseAsync();

            string response;

            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = await streamReader.ReadToEndAsync();
            }

            // Simulation of time-expensive tasks
            await Task.Delay(1000);

            return response;
        }
    }
}