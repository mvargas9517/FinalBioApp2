using System;

using Xamarin.Forms;

namespace FinalBioApp
{
    public class Bio : ContentPage
    {
        public Bio()
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

