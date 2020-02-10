using EasyDeliveryUI.Views.TemplatesView;
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
        }

        private void ChangeColorSelect_Tapped(object sender, EventArgs e)
        {
            PoundsTap.BackgroundColor = Color.White;
            CapitalTap.BackgroundColor = Color.White;
            DeliveryTap.BackgroundColor = Color.White;
            TrackTap.BackgroundColor = Color.White;
            CarPackageTap.BackgroundColor = Color.White;
            DeliveryStateTap.BackgroundColor = Color.White;
            var select = (ButtonView)sender;
            select.BackgroundColor = Color.Goldenrod;
        }
    }
}