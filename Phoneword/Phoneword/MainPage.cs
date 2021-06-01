using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Phoneword
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            this.Padding = new Thickness(20);

            StackLayout panel = new StackLayout
            {
                Spacing = 15
            };

            panel.Children.Add(new Label
            {
                Text = "Enter a Phoneword please:",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            });

            panel.Children.Add(phoneNumberText = new Entry
            {
                Text = "1-999-Testingicle"
            });

            panel.Children.Add(translateButton = new Button
            {
                Text = "Translate"
            });

            panel.Chilrdren.Add(callButton = new Button
            {
                Text = "Call",
                IsEnabled = false
            });

            this.Content = panel;
        }
    }
}