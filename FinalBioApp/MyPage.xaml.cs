﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FinalBioApp
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new StartPage());
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
