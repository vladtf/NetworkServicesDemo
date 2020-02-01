using OpenWeatherDemo.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            textBlock.Text = await FormatedWeahterResponse.GetTextAsync();
        }
    }
}
