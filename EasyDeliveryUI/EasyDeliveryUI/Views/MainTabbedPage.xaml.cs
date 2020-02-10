using EasyDeliveryUI.Models;
using EasyDeliveryUI.ViewsModels;
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
    public partial class MainTabbedPage : TabbedPage
    {
        public Account User { get; set; }
        public MainTabbedPage(Account user)
        {

            InitializeComponent();
            User = user;
        }
        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            if (CurrentPage.Title == "Profile")
            {
                CurrentPage.BindingContext = new ProfilePageViewModel(User);
            }
        }
    }
}