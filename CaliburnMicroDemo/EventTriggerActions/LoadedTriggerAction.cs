using OpenWeatherDemo.Helpers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace OpenWeatherDemo.EventTriggerActions
{
    public class LoadedTriggerAction : TriggerAction<TextBlock>
    {
        protected override async void Invoke(object parameter)
        {
            TextBlock textBlock = (TextBlock)((RoutedEventArgs)parameter).Source;

            textBlock.Text = await FormatedWeatherResponse.GetTextAsync();
        }
    }
}