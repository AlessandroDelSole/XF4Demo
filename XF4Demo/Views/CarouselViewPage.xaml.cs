using XF4Demo.Model;
using XF4Demo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF4Demo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselViewPage : ContentPage
    {
        private CarouselViewModel ViewModel { get; set; }
        public CarouselViewPage()
        {
            InitializeComponent();

            this.ViewModel = new CarouselViewModel();
            this.BindingContext = this.ViewModel;
        }

        private void ProductList_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
        {
            Product previousItem = e.PreviousItem as Product;
            Product currentItem = e.CurrentItem as Product;
        }

        private void ProductList_PositionChanged(object sender, PositionChangedEventArgs e)
        {
            int previousItemPosition = e.PreviousPosition;
            int currentItemPosition = e.CurrentPosition;
        }

        /*
         * public ICommand PositionChangedCommand => new Command<int>((position) =>
           {
                PreviousPosition = CurrentPosition;
                CurrentPosition = position;
           });
         */
    }
}