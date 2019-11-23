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
    public partial class RefreshViewPage : ContentPage
    {
        private ExtendedProductViewModel ViewModel { get; set; }

        public RefreshViewPage()
        {
            InitializeComponent();

            this.ViewModel = new ExtendedProductViewModel();
            this.BindingContext = this.ViewModel;
        }
    }
}