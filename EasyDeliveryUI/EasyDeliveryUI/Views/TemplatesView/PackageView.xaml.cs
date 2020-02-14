using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyDeliveryUI.Views.TemplatesView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PackageView : ContentView
    {
        public static readonly BindableProperty TitlePackageProperty = BindableProperty.Create(nameof(TitlePackage), typeof(string), typeof(PackageView), string.Empty);
        public string TitlePackage
        {
            get => (string)GetValue(TitlePackageProperty);
            set => SetValue(TitlePackageProperty, value);
        }

        public static readonly BindableProperty DescriptionPackageProperty = BindableProperty.Create(nameof(DescriptionPackage), typeof(string), typeof(PackageView), string.Empty);
        public string DescriptionPackage
        {
            get => (string)GetValue(DescriptionPackageProperty);
            set => SetValue(DescriptionPackageProperty, value);
        }
        public static readonly BindableProperty NumberPackageProperty = BindableProperty.Create(nameof(NumberPackage), typeof(string), typeof(PackageView), string.Empty);
        public string NumberPackage
        {
            get => (string)GetValue(NumberPackageProperty);
            set => SetValue(NumberPackageProperty, value);
        }
        public static readonly BindableProperty StatePackageProperty = BindableProperty.Create(nameof(StatePackage), typeof(string), typeof(PackageView), string.Empty);
        public string StatePackage
        {
            get => (string)GetValue(StatePackageProperty);
            set => SetValue(StatePackageProperty, value);
        }


        public PackageView()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}