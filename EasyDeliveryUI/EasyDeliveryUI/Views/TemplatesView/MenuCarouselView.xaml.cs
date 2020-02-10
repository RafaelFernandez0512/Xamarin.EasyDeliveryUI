using EasyDeliveryUI.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyDeliveryUI.Views.TemplatesView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuCarouselView : ContentView
    {
        public MenuCarouselView()
        {
            InitializeComponent();
            BindingContext = new HomePageViewModel();
        }
    }
}