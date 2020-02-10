﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyDeliveryUI.ViewsModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyDeliveryUI.Views.PrincipalsPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
            BindingContext = new SignUpPageViewModel();
        }
    }
}