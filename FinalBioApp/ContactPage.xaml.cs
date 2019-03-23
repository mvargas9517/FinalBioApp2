using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FinalBioApp
{
    public partial class ContactPage : ContentPage
    {
        public ContactPage()
        {
            InitializeComponent();
        }

        void Phone_Tapped(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ContactForm());
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new StartPage());
        }
        void Bio_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MyPage());
        }
        void Skills_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SkillsPage());
        }

    }
}
