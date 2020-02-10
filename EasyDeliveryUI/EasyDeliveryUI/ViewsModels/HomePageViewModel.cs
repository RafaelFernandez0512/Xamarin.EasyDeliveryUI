using EasyDeliveryUI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace EasyDeliveryUI.ViewsModels
{
    public class HomePageViewModel
    {
        public ObservableCollection<HomeMenu> ItemMenus { get; set; } = new ObservableCollection<HomeMenu>() {new HomeMenu()
        {
            TitleCard = "Delivery",
            Description = "Managed the delivery of the stuff you can't fit into your car.",
            ImageCard = "EmpacadorImage.jpg"
            },
        new HomeMenu()
        {
            TitleCard = "Tracking package",
            Description = "We can track your package with the number of traking",
            ImageCard = "PaquetesImage.jpg"
            },
        new HomeMenu()
            {
            TitleCard = "Package",
            Description = "For packages from 0 to 70 pounds, this service arrives within 24 to 48 hours from the USA.",
            ImageCard = "PaquetesImage.jpg"
            }
        };
    };
}

