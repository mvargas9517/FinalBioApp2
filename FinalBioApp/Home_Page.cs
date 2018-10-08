using System;

using Xamarin.Forms;

namespace FinalBioApp
{
    public class Home_Page : ContentPage
    {
        public Home_Page()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

