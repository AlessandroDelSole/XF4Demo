using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XF4Demo.Views;
using Xamarin.Forms;

namespace XF4Demo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void CollectionViewButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SimpleCollectionViewPage());
        }

        private async void CollectionViewMVVMButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MvvmCollectionView());

        }

        private async void RefreshViewButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RefreshViewPage());

        }

        private async void CarouselViewButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CarouselViewPage());

        }

        private async void VisualButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VisualDemoPage());

        }
    }
}
