using EasyDeliveryUI.Models;
using EasyDeliveryUI.Views;
using EasyDeliveryUI.Views.PrincipalsPages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace EasyDeliveryUI.ViewsModels
{
    public class LoginPageViewModel: INotifyPropertyChanged
    {
        public List<Account> Accounts { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public ICommand SignOutCommand { get; set; }
        public ICommand SignUpCommand { get; set; }
        public bool IsVisible { get; set; }
        public string ImageVisibility { get; set; }
        public ICommand IsVisibleCommand { get; set; }
        public LoginPageViewModel()
        {
            Accounts = new List<Account>() {
                new Account { Username = "Rafael",Lastname = "Fernandez",EmailUser = "Rafael@gmail.com",Id_Card =48563214,Password = "123", PhoneUser = 809340201} 
            };
            IsVisible = true;
            ImageVisibility = "baseline_visibility_black_18dp.png";
            IsVisibleCommand = new Command(() =>
            {
                IsVisible = !IsVisible;
                ImageVisibility = IsVisible ? "baseline_visibility_black_18dp.png" : "baseline_visibility_off_black_18dp.png";
            });
            SignOutCommand = new Command(async () =>
            {
                MessagingCenter.Subscribe<SignUpPageViewModel, List<Account>>(this, "List", (sender, param) => {
                    Accounts = param;
                });

                ValidateAccount();
            });
            SignUpCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new SignUpPage());
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public async void ValidateAccount()
        {

            var find = Accounts.Find(e => e.Username == Username ||e.EmailUser==Username && e.Password == Password);
            if (find!=null)
            {
                await App.Current.MainPage.Navigation.PushAsync(new MainTabbedPage(find));

            }
            else
                await App.Current.MainPage.DisplayAlert("Incorrent account", "if you dont have account plis create.", "ok");
        }
    }
}
