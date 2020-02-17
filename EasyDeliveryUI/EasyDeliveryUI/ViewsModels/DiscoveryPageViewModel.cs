using EasyDeliveryUI.Models;
using EasyDeliveryUI.Resx;
using EasyDeliveryUI.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace EasyDeliveryUI.ViewsModels
{
    public class DiscoveryPageViewModel:INotifyPropertyChanged
    {
        public ObservableCollection<DiscoveryMenu> ItemsMenu { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;


        public DiscoveryPageViewModel()
        {
            ItemsMenu = new ObservableCollection<DiscoveryMenu>() { new DiscoveryMenu() { 
            TitleDiscovery = AppResource.PountsText,
            SubTitleDiscovery = " Punts Calculate",
            ImageDiscovery = "PountsImage.png",
             Type_Target = typeof(PackagePage)
            },
            new DiscoveryMenu() {
            TitleDiscovery = AppResource.PackageText,
            SubTitleDiscovery = "Type package",
            ImageDiscovery = "SendImage.png",
             Type_Target = typeof(PackagePage)
            },
            new DiscoveryMenu() {
            TitleDiscovery = AppResource.BoatText,
            SubTitleDiscovery = "1 week",
            ImageDiscovery = "BoatImage.png",
            },
            new DiscoveryMenu() {
            TitleDiscovery = AppResource.TrackPackageText,
            SubTitleDiscovery = "Number Tracking",
            ImageDiscovery = "ImageLocation.png",
            Type_Target = typeof(PackagePage)
            },
            new DiscoveryMenu() {
            TitleDiscovery = AppResource.TruckText,
            SubTitleDiscovery = "Move your package",
            ImageDiscovery = "TruckImage.png",
            },
            new DiscoveryMenu() {
            TitleDiscovery = AppResource.StoreText,
            SubTitleDiscovery = "Associated stores",
            ImageDiscovery = "StoreBag.png",
            }
            };
          
        }
    }
}
