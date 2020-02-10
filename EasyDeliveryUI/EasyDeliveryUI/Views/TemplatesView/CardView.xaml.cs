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
    public partial class CardView : ContentView
    {
        public static readonly BindableProperty TitleCardProperty = BindableProperty.Create(nameof(TitleCard),typeof(string),typeof(CardView));
        public static readonly BindableProperty DescriptionProperty = BindableProperty.Create(nameof(Description), typeof(string), typeof(CardView), string.Empty);
        public static readonly BindableProperty ImageCardProperty = BindableProperty.Create(nameof(ImageCard), typeof(ImageSource), typeof(CardView), default(ImageSource));

        public string TitleCard 
        { 
            get => (string)GetValue(TitleCardProperty); 
            set => SetValue(TitleCardProperty, value); 
        }
        public string Description
        { 
            get => (string)GetValue(DescriptionProperty);
            set => SetValue(DescriptionProperty,value); 
        }

       
        public ImageSource ImageCard
        {
            get => (ImageSource)GetValue(ImageCardProperty); 
            set => SetValue(ImageCardProperty,value);
        }
        public CardView()
        {
            InitializeComponent();
           Content.BindingContext = this;
        }
    }
}