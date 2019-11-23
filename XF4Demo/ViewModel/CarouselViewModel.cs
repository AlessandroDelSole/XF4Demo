using XF4Demo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace XF4Demo.ViewModel
{
    public class CarouselViewModel
    {
        public ObservableCollection<Product> Products { get; set; }
        public CarouselViewModel()
        {
            // Sample products
            this.Products = new ObservableCollection<Product>();
            this.Products.Add(new Product
            {
                ProductQuantity = 50,
                ProductName = "Cheese",
                ProductImage = "cheese_big.png"
            });
            this.Products.Add(new Product
            {
                ProductQuantity = 10,
                ProductName = "Water",
                ProductImage = "water_big.png"
            });
            this.Products.Add(new Product
            {
                ProductQuantity = 6,
                ProductName = "Bread",
                ProductImage = "bread_big.png"
            });
            this.Products.Add(new Product
            {
                ProductQuantity = 40,
                ProductName = "Tomatoes",
                ProductImage = "tomato_big.png"
            });
        }
    }
}
