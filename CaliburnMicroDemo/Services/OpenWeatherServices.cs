using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OpenWeatherDemo.Services
{
    class OpenWeatherServices
    {
        public static async Task<string> GetCurrentWeatherAsync()
        {
            string url = "http://api.openweathermap.org/data/2.5/weather?q=Galati&units=metric&appid=b18c89a19ac343dd1edd7c762c1def3f";

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            HttpWebResponse httpWebResponse = (HttpWebResponse)await httpWebRequest.GetResponseAsync();

            string response;

            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = await streamReader.ReadToEndAsync();
            }

            await Task.Delay(1000);
            return response;
        }
    }
}
