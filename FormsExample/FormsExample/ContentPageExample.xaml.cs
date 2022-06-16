using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormsExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContentPageExample : ContentPage
    {
        public ContentPageExample()
        {
            InitializeComponent();
            this.Content = stackLayout;
            this.BackgroundColor = Color.White;
            labelLarge.FontFamily = "Robotto";
            labelSmall.FontFamily = "Robotto";
            button.Clicked += (sender, e) =>
            {
                if (button.Text == "It is so!")
                {
                    button.Text = "Make It so";
                }
                else
                {
                    button.Text = "It is so!";
                }
            };
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (sender, e) =>
            {
                image.Opacity = .5;
            };
            image.GestureRecognizers.Add(tapGestureRecognizer);

        }

        StackLayout stackLayout = new StackLayout
        {
            Children =
            {
                labelLarge,
                labelSmall,
                button,
                entry,
                boxView,
                image
            },
            HeightRequest = 1500
        };

        static Label labelLarge = new Label
        {
            Text = "Label",
            FontSize = 40,
            HorizontalOptions = LayoutOptions.Center,
            TextColor = Color.Black,
            HorizontalTextAlignment = TextAlignment.Start
        };
        static Label labelSmall = new Label
        {
            Text = "This control is great for \n" +
            "displayng one or more\n" +
            "lines of text.",
            FontSize = 20,
            TextColor = Color.Black,
            HorizontalOptions = LayoutOptions.CenterAndExpand,
            HorizontalTextAlignment = TextAlignment.Start
        };

        static Button button = new Button
        {
            Text = "Make It so",
            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
            HorizontalOptions = LayoutOptions.Fill,
            VerticalOptions = LayoutOptions.Fill
        };

        static Entry entry = new Entry
        {
            Placeholder = "Username",
            VerticalOptions = LayoutOptions.Center,
            Keyboard = Keyboard.Text
        };

        static BoxView boxView = new BoxView
        {
            Color = Color.Silver,
            WidthRequest =150,
            HeightRequest = 150,
            HorizontalOptions = LayoutOptions.StartAndExpand,
            VerticalOptions = LayoutOptions.Fill,
        };

        static Image image = new Image
        {
            Source = "monkey.png",
            Aspect = Aspect.AspectFit,
            HorizontalOptions= LayoutOptions.End,
            VerticalOptions= LayoutOptions.Fill,
        };

        
    }
}