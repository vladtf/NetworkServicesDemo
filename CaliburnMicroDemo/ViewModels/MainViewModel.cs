using Caliburn.Micro;
using OpenWeatherDemo.Commands;
using OpenWeatherDemo.Helpers;
using OpenWeatherDemo.Services;
using OpenWeatherDemo.Services.ServicesResponses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace OpenWeatherDemo.ViewModels
{
    class MainViewModel : Screen
    {
        #region Backend private fields region
        private string _weatherText = "Current weather with Caliburn";
        private string _weatherTextCommand = "Current weather with Command";
        #endregion

        #region Public properties region
        public string WeatherText
        {
            get { return _weatherText; }
            set { Set(ref _weatherText, value); }
        }
        public string WeatherTextCommand
        {
            get { return _weatherTextCommand; }
            set { Set(ref _weatherTextCommand, value); }
        }
        #endregion
        public MainViewModel()
        {

        }


        public async void OnLoad()
        {
            WeatherText = await FormatedWeahterResponse.GetTextAsync();
        }

        public void Update()
        {
            Console.WriteLine();
        }

        private ICommand _windowLoaded;

        public ICommand WindowLoaded
        {
            get 
            {
                if (_windowLoaded == null)
                    _windowLoaded = new LoadedCommand();
                return _windowLoaded; 
            }
            set { _windowLoaded = value; }
        }


    }

}
