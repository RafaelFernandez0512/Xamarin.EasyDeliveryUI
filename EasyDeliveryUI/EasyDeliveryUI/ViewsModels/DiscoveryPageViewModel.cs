using EasyDeliveryUI.Models;
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
            TitleDiscovery = "Pounts ",
            SubTitleDiscovery = " Punts Calculate",
            ImageDiscovery = "PountsImage.png",
             Type_Target = typeof(PackagePage)
            },
            new DiscoveryMenu() {
            TitleDiscovery = "Package",
            SubTitleDiscovery = "Type package",
            ImageDiscovery = "SendImage.png",
             Type_Target = typeof(PackagePage)
            },
            new DiscoveryMenu() {
            TitleDiscovery = "Boat",
            SubTitleDiscovery = "1 week",
            ImageDiscovery = "BoatImage.png",
            },
            new DiscoveryMenu() {
            TitleDiscovery = "Track package",
            SubTitleDiscovery = "Number Tracking",
            ImageDiscovery = "ImageLocation.png",
            Type_Target = typeof(PackagePage)
            },
            new DiscoveryMenu() {
            TitleDiscovery = "Truck",
            SubTitleDiscovery = "Delivery home",
            ImageDiscovery = "TruckImage.png",
            },
            new DiscoveryMenu() {
            TitleDiscovery = "Go to store",
            SubTitleDiscovery = "Associated stores",
            ImageDiscovery = "StoreBag.png",
            }
            };
          
        }
    }
}
