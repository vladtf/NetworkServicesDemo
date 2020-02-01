using Caliburn.Micro;
using OpenWeatherDemo.Commands;
using OpenWeatherDemo.Helpers;
using System;
using System.Windows.Input;

namespace OpenWeatherDemo.ViewModels
{
    internal class MainViewModel : Screen
    {
        #region Backend private fields region

        private string _weatherText = "Current weather with Caliburn";
        private string _weatherTextCommand = "Current weather with Command";

        #endregion Backend private fields region

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

        #endregion Public properties region

        public MainViewModel()
        {
        }

        #region Caliburn.Micro Messages

        public async void OnLoad()
        {
            WeatherText = await FormatedWeatherResponse.GetTextAsync();
        }

        public void Update()
        {
            Console.WriteLine();
        }

        #endregion Caliburn.Micro Messages

        #region Commands

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

        #endregion Commands
    }
}