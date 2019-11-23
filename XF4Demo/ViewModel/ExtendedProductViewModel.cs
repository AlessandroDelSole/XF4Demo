using XF4Demo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF4Demo.ViewModel
{
    public class ExtendedProductViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Product> Products { get; set; }
        private Product _selectedProduct;
        public Product SelectedProduct
        {
            get
            {
                return _selectedProduct;
            }
            set
            {
                _selectedProduct = value;
                OnPropertyChanged();
            }
        }
        private Command _productSelectedCommand;
        public Command ProductSelectedCommand
        {
            get
            {
                return _productSelectedCommand;
            }
            set
            {
                _productSelectedCommand = value;
                OnPropertyChanged();
            }
        }

        private Command _refreshCommand;
        public Command RefreshCommand
        {
            get
            {
                return _refreshCommand;
            }
            set
            {
                _refreshCommand = value;
                OnPropertyChanged();
            }
        }

        public ExtendedProductViewModel()
        {
            // Sample products
            this.Products = new ObservableCollection<Product>();

            LoadData();

            this.ProductSelectedCommand =
              new Command(ExecuteProductSelectedCommand,
                CanExecuteProductSelectedCommand);

            this.RefreshCommand = new Command(ExecuteRefreshCommand);

        }

        private bool _isRefreshing;
        public bool IsRefreshing
        {
            get
            {
                return _isRefreshing;
            }
            set
            {
                _isRefreshing = value;
                OnPropertyChanged();
            }
        }

        private async void ExecuteRefreshCommand(object obj)
        {
            IsRefreshing = true;
            LoadData();
            await Task.Delay(3000);
            IsRefreshing = false;
        }

        private void LoadData()
        {
            for (int i = 0; i < 100; i++)
            {
                this.Products.Add(new Product
                {
                    ProductQuantity = 50,
                    ProductName = "Cheese",
                    ProductImage = "cheese.png"
                });
                this.Products.Add(new Product
                {
                    ProductQuantity = 10,
                    ProductName = "Water",
                    ProductImage = "water.png"
                });
                this.Products.Add(new Product
                {
                    ProductQuantity = 6,
                    ProductName = "Bread",
                    ProductImage = "bread.png"
                });
                this.Products.Add(new Product
                {
                    ProductQuantity = 40,
                    ProductName = "Tomatoes",
                    ProductImage = "tomato.png"
                });

            }
        }

        private bool CanExecuteProductSelectedCommand(object arg)
        {
            return this.SelectedProduct != null;
        }
        private void ExecuteProductSelectedCommand(object obj)
        {
            // Handle your object here....
            var currentProduct = this.SelectedProduct;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this,
              new PropertyChangedEventArgs(propertyName));
        }
    }
}
