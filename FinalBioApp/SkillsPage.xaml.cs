using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FinalBioApp
{
    public partial class SkillsPage : ContentPage
    {
        public SkillsPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new StartPage());
        }
        void Bio_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MyPage());
        }
        void Contact_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ContactPage());
        }
    }
}
