using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FinalBioApp
{
    public partial class ContactForm : ContentPage
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(NameEntry.Text))
            {
                DisplayAlert("Error", "Please enter Name!", "Ok");
                return;
            }
            if (string.IsNullOrEmpty(EmailEntry.Text))
            {
                DisplayAlert("Error", "Please enter E-mail!", "Ok");
                return;
            }
            if (string.IsNullOrEmpty(MessageEntry.Text))
            {
                DisplayAlert("Error", "Please enter Message!", "Ok");
                return;
            }

            DisplayAlert("Alert", "Message sent successfully!","Ok");
        }
    }
}
