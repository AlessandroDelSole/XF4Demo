using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace XF4Demo.Model
{
    public class Product : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this,
              new PropertyChangedEventArgs(propertyName));
        }

        private int _productQuantity;
        private string _productName;
        private string _productImage;
        
        public int ProductQuantity
        {
            get
            {
                return _productQuantity;
            }
            set
            {
                _productQuantity = value;
                OnPropertyChanged();
            }
        }
        public string ProductName
        {
            get
            {
                return _productName;
            }
            set
            {
                _productName = value;
                OnPropertyChanged();
            }
        }
        public string ProductImage
        {
            get
            {
                return _productImage;
            }
            set
            {
                _productImage = value;
                OnPropertyChanged();
            }
        }
    }
}
