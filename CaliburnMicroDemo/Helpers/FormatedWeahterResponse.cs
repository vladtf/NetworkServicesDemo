using OpenWeatherDemo.Services;
using OpenWeatherDemo.Services.ServicesResponses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherDemo.Helpers
{
    public class FormatedWeahterResponse
    {
        public static async Task<string> GetTextAsync()
        {
                string response = "";
                try
                {
                    response = await OpenWeatherServices.GetCurrentWeatherAsync();

                    WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);

                    response = $"Temperatura in {weatherResponse.Name} este {weatherResponse.Main.Temp} ℃";
                }
                catch (WebException e)
                {
                    response = e.Message;
                }
                catch (Exception e)
                {
                    response = e.Message;
                }

                return response;
        }

    }
}
