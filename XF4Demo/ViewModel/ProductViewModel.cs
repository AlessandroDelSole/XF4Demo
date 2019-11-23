using XF4Demo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace XF4Demo.ViewModel
{
    public class ProductViewModel
    {
        public ObservableCollection<Product> Products { get; set; }
        public ProductViewModel()
        {
            // Sample products
            this.Products = new ObservableCollection<Product>();
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
}
