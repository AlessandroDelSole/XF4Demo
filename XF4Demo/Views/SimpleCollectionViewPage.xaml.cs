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
    public partial class SimpleCollectionViewPage : ContentPage
    {
        private ProductViewModel ViewModel { get; set; }

        public SimpleCollectionViewPage()
        {
            InitializeComponent();
            this.ViewModel = new ProductViewModel();
            this.BindingContext = this.ViewModel;
        }

        private void ProductList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedProduct = this.ProductList.SelectedItem as Product;

            // In case of multi-selection:
            var singleProduct = e.CurrentSelection.FirstOrDefault() as Product;

            var selectedItems = e.CurrentSelection.Cast<Product>();
            foreach (var product in selectedItems)
            {
                // Handle your object properties here...
            }
        }
    }
}