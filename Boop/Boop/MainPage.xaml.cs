using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Boop
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            
            //Button getStartedButton = new Button
            //{
            //    Text = "Get Started",
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center
            //};

            //getStartedButton.Clicked += async (sender, args) =>
            //{
            //    await Navigation.PushAsync(new SignUpPage());
            //};
            //// Next Button
            //Button signInButton = new Button
            //{
            //    Text = "Sign In",
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center
            //};

            //signInButton.Clicked += async (sender, args) =>
            //{
            //    await Navigation.PushAsync(new MenuPage());
            //};
            //Content = new StackLayout
            //{
            //    Children =
            //    {
            //        getStartedButton,
            //        signInButton
            //    }
            //};
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MenuPage());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
