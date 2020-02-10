using EasyDeliveryUI.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace EasyDeliveryUI.ViewsModels
{
    public class ProfilePageViewModel
    {
        public Account User { get; set; }  = new Account();
        public string FullName { get; set; }
        public ICommand LogOutCommand { get; set; }
        public ProfilePageViewModel(Account user)
        {
             User = user;
            FullName = $"{User.Username} {User.Lastname}";
            LogOutCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PopToRootAsync();
            });
        }
    }
}
