using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Boop
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }


        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }

        void Handle_Clicked2(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
//var optionsButton = new Button
//{
//    Text = "Options",
//    HorizontalOptions = LayoutOptions.Center,
//    VerticalOptions = LayoutOptions.Center
//};

//optionsButton.Clicked += async (sender, e) =>
//{
//    await Navigation.PushAsync(new MainPage());
//};
//// Next button
//var visualizationButton = new Button
//{
//    Text = "Visualization",
//    HorizontalOptions = LayoutOptions.Center,
//    VerticalOptions = LayoutOptions.Center
//};

//visualizationButton.Clicked += async (sender, e) =>
//{
//    await Navigation.PushAsync(new VisualizationPage());
//};
//// Next button
//var socialButton = new Button
//{
//    Text = "Social",
//    HorizontalOptions = LayoutOptions.Center,
//    VerticalOptions = LayoutOptions.Center
//};

//socialButton.Clicked += async (sender, e) =>
//{
//    await Navigation.PushAsync(new MainPage());
//};
//Content = new StackLayout
//{
//    Children =
//    {
//        optionsButton,
//        visualizationButton,
//        socialButton
//    }
//};

