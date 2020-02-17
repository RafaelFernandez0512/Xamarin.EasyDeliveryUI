using EasyDeliveryUI.Models;
using EasyDeliveryUI.Resx;
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
            TitleCard = AppResource.DeliveryText,
            Description = AppResource.DescriptionDelivery,
            ImageCard = "transporteaereo"
            },
        new HomeMenu()
        {
            TitleCard =  AppResource.TrackPackageText,
            Description = AppResource.DescriptionTrackPackage,
            ImageCard = "paquetesImage"
            },
        new HomeMenu()
            {
            TitleCard =  AppResource.PountsText,
            Description = AppResource.DescriptionPountsText,
            ImageCard = "CarImage.png"
            }
        };
    };
}

