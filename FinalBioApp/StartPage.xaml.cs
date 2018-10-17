using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FinalBioApp
{
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MyPage());
        }
        void Skills_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SkillsPage());
        }
        void Contact_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ContactPage());
        }
    }
}
