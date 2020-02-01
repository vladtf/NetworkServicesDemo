using OpenWeatherDemo.Helpers;
using System;
using System.Windows.Controls;
using System.Windows.Input;

namespace OpenWeatherDemo.Commands
{
    public class LoadedCommand : ICommand
    {
        #region ICommand Members

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public async void Execute(object parameter)
        {
            string response = (string)await FormatedWeatherResponse.GetTextAsync();
            var textBlock = (TextBlock)parameter;
            textBlock.Text = response;
        }

        #endregion ICommand Members
    }
}