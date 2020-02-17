using EasyDeliveryUI.Models;
using EasyDeliveryUI.Views.TemplatesView;
using EasyDeliveryUI.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyDeliveryUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiscoveryPage : ContentPage
    {
        public DiscoveryPage()
        {
            InitializeComponent();
            BindingContext = new DiscoveryPageViewModel();
        }


        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var product = e.CurrentSelection;
            if (product != null)
            {
                var select = product.FirstOrDefault() as DiscoveryMenu;
                if (select.Type_Target !=null)
                {
                    var page = (Page)Activator.CreateInstance(select.Type_Target);
                    page.Title = select.TitleDiscovery;
                    Navigation.PushAsync(page);
                }

            }
        }
    }
}