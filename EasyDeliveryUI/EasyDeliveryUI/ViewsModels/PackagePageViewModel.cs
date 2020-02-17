using EasyDeliveryUI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace EasyDeliveryUI.ViewsModels
{
    public class PackagePageViewModel:INotifyPropertyChanged
    {
        readonly IList<Package> packages;

        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsFreshing { get; set; }
        public ICommand FreshingCommad { get; set; }
        public List<Package> Packages { get; private set; }
        public ICommand FilterCommand => new Command<string>(FindPackages);
        public PackagePageViewModel()
        {
            IsFreshing = false;
            packages = new ObservableCollection<Package>() { new Package() { 
            NamePackage = "Laptop Dell inspiron",
            Description = "Laptop dell inspiron 15",
            LocationPackage = "Miami Delivery",
            NumberTranking = 1321534873,
            StatePackage = "transit",
            PountsPackage = 20
            },
            new Package() {
            NamePackage = "Playstation",
            Description = "Sony Psp 4 usable 500gb ",
            LocationPackage = "Santo Doming",
            NumberTranking = 567453483,
            StatePackage = "embarked",
            PountsPackage = 30
            },
            new Package() {
            NamePackage = "Mouse gamer",
            Description = "Mouser gamer Logitech",
            LocationPackage = "unknow",
            NumberTranking = 976534103,
            StatePackage = "unknow",
            PountsPackage = 5
            },
            new Package() {
            NamePackage = "Michael Kors Men's Slim Runway Quartz",
            Description = "2 Year International Warranty Slim Runway Black IP Three-Hand Watch",
            LocationPackage = "Miami",
            NumberTranking = 254783173,
            StatePackage = "transit",
            PountsPackage = 14
            },
            new Package() {
            NamePackage = "Panasonic Electric Body Groomer",
            Description = "Panasonic Electric Body Groomer & Trimmer for Men ER-GK60-S, Cordless, Showerproof with 3 Comb Attachments, Washable",
            LocationPackage = "Santo domingo",
            NumberTranking = 231544873,
            StatePackage = "to deliver",
            PountsPackage = 15
            },
            new Package() {
            NamePackage = "Ailun for Apple iPhone 11 Pro Max",
            Description = "Ailun for Apple iPhone 11 Pro Max/iPhone Xs Max Screen Protector 3 Pack 6.5 Inch Case",
            LocationPackage = "Miami Delivery",
            NumberTranking = 112734873,
            StatePackage = "transit",
            PountsPackage = 3
            }};
            Packages = new List<Package>(packages);
            FreshingCommad = new Command(() =>
            {
                IsFreshing = true;
                Packages = new List<Package>(packages);
                IsFreshing = false;
            });
        }

        public void FindPackages(string find)
        {
            var FindElements = packages.Where(e => e.NumberTranking.ToString().Contains(find)).ToList();
            Packages.RemoveAll(e => e.NumberTranking.ToString().Contains(find));
            Packages = FindElements;
        }
    }
}
