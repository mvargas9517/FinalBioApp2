using System;

using Xamarin.Forms;

namespace FinalBioApp
{
    public class ContactForm : ContentPage
    {
        public ContactForm()
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

