using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace FinalBioApp
{
    public partial class SkillsPage : ContentPage
    {
        public ObservableCollection<Skill> Skills { get; set; }

        public SkillsPage()
        {
            InitializeComponent();

            this.Skills = new ObservableCollection<Skill>();

            this.Skills.Add(new Skill 
            { Description = "Building Quieries in SQL", Name = "SQL" });
            this.Skills.Add(new Skill 
            { Description = "Can work all MS Office", Name = "MS Office" });
            this.Skills.Add(new Skill 
            { Description = "Can desing in CSS", Name = "CSS" });
            this.Skills.Add(new Skill 
            { Description = "Can build websites with HTML", Name = "HTML" });
            this.Skills.Add(new Skill 
            { Description = "Can build Mockups in XD", Name = "Adobe XD" });
            this.Skills.Add(new Skill 
            { Description = "Coding in Javascript", Name = "Javascript" });

            SkillsListView.ItemsSource = this.Skills;
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
        public class Skill
        {
            public string Name { get; set; }

            public string Description { get; set; }
        }
    }
}
