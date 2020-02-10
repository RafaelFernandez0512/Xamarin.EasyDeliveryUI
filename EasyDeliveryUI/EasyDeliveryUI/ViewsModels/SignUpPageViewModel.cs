using EasyDeliveryUI.Models;
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
            var name = User.Username;
            var lastname = User.Lastname;
            var password = User.Password;
            var email = User.EmailUser;
            var phone = User.PhoneUser;
            var idCard = User.Id_Card;
            var dateOfBirth = User.DateOfBirth;

            if (name.IsStringEmpty() && lastname.IsStringEmpty())
                Validate = "Complete field nombre or lastname ";
            else if (email.IsStringEmpty())
                Validate = "Complete field email o incorrect email";
            else if (password.IsStringEmpty() && password != Password)
                Validate = "Complete field password or password is not equal ";
            else if (!phone.ValidateNumber())
                Validate = "Complete field number o incorrect number";
            else if (!idCard.ValidateNumber())
                Validate = "Complete field id car o incorrect id Car";
            else if (dateOfBirth == null)
                Validate = "Complete field Date of birth";
            else
            {
                Accounts.Add(User);
                await App.Current.MainPage.Navigation.PushAsync(new MainTabbedPage(User));
            }

        }
    }
}
