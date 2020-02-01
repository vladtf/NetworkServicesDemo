using Newtonsoft.Json;
using OpenWeatherDemo.Services;
using OpenWeatherDemo.Services.ServicesResponses;
using System;
using System.Net;
using System.Threading.Tasks;
using System.Windows;

namespace OpenWeatherDemo.Helpers
{
    public class FormatedWeatherResponse
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                response = "Error on calling WebApi";
            }

            return response;
        }
    }
}