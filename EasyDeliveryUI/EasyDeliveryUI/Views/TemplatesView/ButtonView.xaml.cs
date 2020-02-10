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
    public partial class ButtonView : ContentView
    {
        public static readonly BindableProperty TitleButtonProperty = BindableProperty.Create(nameof(TitleButton), typeof(string), typeof(CardView), string.Empty);
        public static readonly BindableProperty SubTitleButtonProperty = BindableProperty.Create(nameof(SubTitleButton), typeof(string), typeof(CardView), string.Empty);
        public static readonly BindableProperty ImageCardButtonProperty = BindableProperty.Create(nameof(ImageCardButton), typeof(ImageSource), typeof(CardView), default(ImageSource));


        public string TitleButton
        {
            get => (string)GetValue(TitleButtonProperty);
            set => SetValue(TitleButtonProperty, value);
        }
        public string SubTitleButton
        {
            get => (string)GetValue(SubTitleButtonProperty);
            set => SetValue(SubTitleButtonProperty, value);
        }
        public ImageSource ImageCardButton
        {
            get => (ImageSource)GetValue(ImageCardButtonProperty);
            set => SetValue(ImageCardButtonProperty, value);
        }
        public ButtonView()
        {
            InitializeComponent();
        }
    }
}