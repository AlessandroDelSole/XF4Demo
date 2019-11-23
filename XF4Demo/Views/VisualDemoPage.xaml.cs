using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF4Demo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VisualDemoPage : ContentPage
    {
        public VisualDemoPage()
        {
            InitializeComponent();
        }

        private async void ConfirmButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Confirmation",
                $"You are {NameEntry.Text}, born on {BirthDatePicker.Date.ToShortDateString()}, of age {Math.Round(AgeSlider.Value)}",
                "OK");
        }
    }
}