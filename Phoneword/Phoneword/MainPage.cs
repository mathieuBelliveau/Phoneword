﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Phoneword
{
    public class MainPage : ContentPage
    {
        Entry phoneNumberText;
        Button translateButton;
        Button callButton;
        string translatedNumber;
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

            panel.Children.Add(callButton = new Button
            {
                Text = "Call",
                IsEnabled = false
            });

            
            //Why no arguments? why +=?
            translateButton.Clicked += OnTranslate;
            this.Content = panel;
        }

        private void OnTranslate(object sender, EventArgs e)
        {
            string enteredNumber = phoneNumberText.Text;
            translatedNumber = Phoneword.PhonewordTranslator.ToNumber(enteredNumber);

            if (!string.IsNullOrEmpty(translatedNumber))
            {
                callButton.IsEnabled = true;
                callButton.Text = "Call " + translatedNumber;
            }
            else
            {
                callButton.IsEnabled = false;
                callButton.Text = "Call";
            }
        }
    }
}