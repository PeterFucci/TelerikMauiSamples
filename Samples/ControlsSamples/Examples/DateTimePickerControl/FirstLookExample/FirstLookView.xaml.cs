﻿using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Devices;
using QSF.Views;

namespace QSF.Examples.DateTimePickerControl.FirstLookExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstLookView : PickerExampleViewBase
    {
        public FirstLookView()
        {
            InitializeComponent();
            if (DeviceInfo.Idiom != DeviceIdiom.Phone)
            {
                this.dateTimePicker.MaximumWidthRequest = 300;
            }
        }
    }
}