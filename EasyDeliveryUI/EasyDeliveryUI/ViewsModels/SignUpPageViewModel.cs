using EasyDeliveryUI.Models;
using EasyDeliveryUI.Resx;
using EasyDeliveryUI.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace EasyDeliveryUI.ViewsModels
{
    public class SignUpPageViewModel:INotifyPropertyChanged
    {
        public List<Account> Accounts { get; set; } = new List<Account>();

        public Account User { get; set; } = new Account();
        public string Validate { get; set; }
        public ICommand IsVisibleCommand { get; set; }

        public bool IsVisible { get; set; }
        public string ImageVisibility { get; set; }
        public ICommand FinishCommand { get; set; }
        public string Password { get; set; }
        public SignUpPageViewModel()
        {
            IsVisible = true;
            ImageVisibility = "baseline_visibility_black_18dp.png" ;
           IsVisibleCommand = new Command(() =>
            {
                IsVisible = !IsVisible;
                ImageVisibility = IsVisible ? "baseline_visibility_black_18dp.png" : "baseline_visibility_off_black_18dp.png";
            });
           
            FinishCommand = new Command(()=> 
            {
                MessagingCenter.Send(this,"List", Accounts);
                AddAccounts();
            });


        }

        public event PropertyChangedEventHandler PropertyChanged;

        public async void AddAccounts()
        {
            if (User.Username.IsStringEmpty() && User.Lastname.IsStringEmpty())
                Validate = AppResource.ValidateUsername;
            else if (User.EmailUser.IsStringEmpty())
                Validate = AppResource.ValidateEmail;
            else if (User.Password.IsStringEmpty() && User.Password != Password)
                Validate = AppResource.ValidatePassword;
            else if (!User.PhoneUser.ValidateNumber())
                Validate = AppResource.ValidatePhoneNumber;
            else if (!User.Id_Card.ValidateNumber())
                Validate = AppResource.ValidateIscardNumber;
            else
            {
                Accounts.Add(User);
                await App.Current.MainPage.Navigation.PushAsync(new MainTabbedPage(User));
            }

        }
    }
}
